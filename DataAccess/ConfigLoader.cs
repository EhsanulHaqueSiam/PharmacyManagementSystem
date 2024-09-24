using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace PharmacyManagementSystem.DataAccess {
    public sealed class ConfigLoader {
        private static readonly Lazy<ConfigLoader> instance =
            new Lazy<ConfigLoader>(() => new ConfigLoader());

        public static ConfigLoader Instance => instance.Value;

        private readonly string _configFilePath;
        private readonly XDocument _config;

        private ConfigLoader() {
            // Constant for configuration file name
            const string configFileName = "config.xml";

            // Construct config file path using constant
            _configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", configFileName);
            _config = LoadConfig();
        }

        private XDocument LoadConfig() {
            try {
                return XDocument.Load(_configFilePath);
            } catch (FileNotFoundException ex) {
                throw new ConfigurationException($"Configuration file not found: {_configFilePath}", ex);
            } catch (Exception ex) {
                throw new ConfigurationException($"Error loading configuration from {_configFilePath}", ex);
            }
        }

        public string GetValue(string key) {
            // Split the key by "/" to navigate through nested elements
            var keys = key.Split('/');
            XElement element = _config.Root;

            // Traverse through the XML tree to find the desired value
            foreach (var k in keys) {
                element = element.Element(k);
                if (element == null) {
                    return null; // Return null if any part of the path is invalid
                }
            }

            return element.Value;
        }


        public TValue GetValue<TValue>(string key) {
            string value = GetValue(key);
            if (value == null) {
                return default(TValue); // Return default value for type TValue
            }

            try {
                return (TValue)Convert.ChangeType(value, typeof(TValue));
            } catch (Exception ex) {
                throw new ConfigurationException($"Error converting value for key '{key}' to type {typeof(TValue)}", ex);
            }
        }

        public Dictionary<string, string> GetAllValues() {
            var elements = _config.Element("configuration")?.Elements();
            if (elements == null) {
                return new Dictionary<string, string>();
            }

            return elements.ToDictionary(x => x.Name.LocalName, x => x.Value);
        }

        public string GetSqlServerName() {
            return GetValue("SqlServerName");
        }

        public string GetDatabaseName() {
            return GetValue("DatabaseName");
        }

        public string GetDatabaseFilePath() {
            return GetValue("DatabaseFilePath");
        }

        public string GetUserId() {
            return GetValue("UserId");
        }

        public string GetPassword() {
            return GetValue("Password");
        }

        public string GetConnectionString() {
            var serverName = GetSqlServerName();
            var databaseName = GetDatabaseName();
            var databaseFilePath = GetDatabaseFilePath();
            var userId = GetUserId();
            var password = GetPassword();

            // Check if server name is provided
            if (!string.IsNullOrEmpty(serverName)) {
                // Prioritize server connection
                var builder = new SqlConnectionStringBuilder {
                    DataSource = serverName,
                    InitialCatalog = databaseName,
                    IntegratedSecurity = string.IsNullOrEmpty(userId) && string.IsNullOrEmpty(password)
                };

                if (!builder.IntegratedSecurity) {
                    if (string.IsNullOrEmpty(userId)) {
                        throw new ConfigurationException("User ID is not specified in the configuration.");
                    }
                    if (string.IsNullOrEmpty(password)) {
                        throw new ConfigurationException("Password is not specified in the configuration.");
                    }
                    builder.UserID = userId;
                    builder.Password = password;
                }

                return builder.ConnectionString;
            }
            // Fallback to LocalDB connection with AttachDbFilename
            else if (!string.IsNullOrEmpty(databaseFilePath)) {
                var builder = new SqlConnectionStringBuilder {
                    DataSource = @"(LocalDB)\MSSQLLocalDB",
                    AttachDBFilename = databaseFilePath,
                    IntegratedSecurity = true // Assuming Integrated Security for LocalDB
                };

                return builder.ConnectionString;
            }

            // If neither are provided, throw an exception
            throw new ConfigurationException("Either SQL Server name or Database file path must be specified in the configuration.");
        }

        // New methods for SMTP Configuration
        public string GetSmtpEmail() {
            return GetValue("SMTP/Email");
        }

        public string GetSmtpPassword() {
            return GetValue("SMTP/AppPassword");
        }

        public string GetSmtpServer() {
            return GetValue("SMTP/SmtpServer");
        }

        public int GetSmtpPort() {
            return GetValue<int>("SMTP/Port");
        }
    }

    public class ConfigurationException : Exception {
        public ConfigurationException(string message, Exception innerException = null)
            : base(message, innerException) {
        }
    }
}
