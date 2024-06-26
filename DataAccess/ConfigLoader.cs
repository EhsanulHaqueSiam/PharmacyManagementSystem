﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            XElement element = _config.Element("configuration")?.Element(key);
            return element?.Value;
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

        public string GetUserId() {
            return GetValue("UserId");
        }

        public string GetPassword() {
            return GetValue("Password");
        }

        public string GetConnectionString() {
            var serverName = GetSqlServerName();
            var databaseName = GetDatabaseName();
            var userId = GetUserId();
            var password = GetPassword();

            if (string.IsNullOrEmpty(serverName)) {
                throw new ConfigurationException("SQL Server name is not specified in the configuration.");
            }
            if (string.IsNullOrEmpty(databaseName)) {
                throw new ConfigurationException("Database name is not specified in the configuration.");
            }

            var builder = new System.Data.SqlClient.SqlConnectionStringBuilder {
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
    }

    public class ConfigurationException : Exception {
        public ConfigurationException(string message, Exception innerException = null)
            : base(message, innerException) {
        }
    }
}
