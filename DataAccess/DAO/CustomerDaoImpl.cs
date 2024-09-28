using PharmacyManagementSystem.DataAccess.Constants;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PharmacyManagementSystem.DataAccess {
    public class CustomerDaoImpl : ICustomerDao {

        public Customer GetCustomerById(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CustomerQueries.GET_CUSTOMER_BY_ID, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return MapToCustomer(reader);
                        }
                        return null;
                    }
                }
            });
        }

        public Customer GetCustomerByUsername(string username) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CustomerQueries.GET_CUSTOMER_BY_USERNAME, connection)) {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return MapToCustomer(reader);
                        }
                        return null;
                    }
                }
            });
        }

        public Customer GetCustomerByEmail(string email) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CustomerQueries.GET_CUSTOMER_BY_EMAIL, connection)) {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return MapToCustomer(reader);
                        }
                        return null;
                    }
                }
            });
        }

        public IEnumerable<Customer> SearchCustomersByPartialUsername(string partialUsername) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var customers = new List<Customer>();
                using (var cmd = new SqlCommand(CustomerQueries.SEARCH_CUSTOMERS_BY_PARTIAL_USERNAME, connection)) {
                    cmd.Parameters.AddWithValue("@partialUsername", "%" + partialUsername + "%");
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            customers.Add(MapToCustomer(reader));
                        }
                    }
                }
                return customers;
            });
        }

        public IEnumerable<Customer> SearchCustomersByPartialPhone(string partialPhone) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var customers = new List<Customer>();
                using (var cmd = new SqlCommand(CustomerQueries.SEARCH_CUSTOMERS_BY_PARTIAL_PHONE, connection)) {
                    cmd.Parameters.AddWithValue("@partialPhone", "%" + partialPhone + "%");
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            customers.Add(MapToCustomer(reader));
                        }
                    }
                }
                return customers;
            });
        }

        public bool InsertCustomer(Customer customer) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CustomerQueries.INSERT_CUSTOMER, connection)) {
                    AddCustomerParameters(cmd, customer);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool UpdateCustomer(Customer customer) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CustomerQueries.UPDATE_CUSTOMER, connection)) {
                    cmd.Parameters.AddWithValue("@Id", customer.C_ID);
                    AddCustomerParameters(cmd, customer);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool DeleteCustomer(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CustomerQueries.DELETE_CUSTOMER, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool SoftDeleteCustomer(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CustomerQueries.SOFT_DELETE_CUSTOMER, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public IEnumerable<Customer> GetAllCustomers() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var customers = new List<Customer>();
                using (var cmd = new SqlCommand(CustomerQueries.GET_ALL_CUSTOMERS, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            customers.Add(MapToCustomer(reader));
                        }
                    }
                }
                return customers;
            });
        }

        public int CountCustomers() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CustomerQueries.COUNT_CUSTOMERS, connection)) {
                    return (int)cmd.ExecuteScalar();
                }
            });
        }

        public bool ValidateCustomerLogin(string usernameOrEmail, string password) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CustomerQueries.VALIDATE_CUSTOMER_LOGIN, connection)) {
                    cmd.Parameters.AddWithValue("@usernameOrEmail", usernameOrEmail);
                    cmd.Parameters.AddWithValue("@password", password);
                    var result = cmd.ExecuteScalar();
                    return result != null;
                }
            });
        }

        // Helper method to map SqlDataReader to Customer model
        private Customer MapToCustomer(SqlDataReader reader) {
            return new Customer {
                C_ID = (int)reader["C_ID"],
                C_UserName = reader["C_UserName"].ToString(),
                C_Name = reader["C_Name"].ToString(),
                C_Number = reader["C_Number"].ToString(),
                C_Pass = reader["C_Pass"].ToString(),
                C_Mail = reader["C_Mail"].ToString(),
                C_Dob = (DateTime)reader["C_Dob"]
            };
        }

        // Helper method to add parameters to the SqlCommand
        private void AddCustomerParameters(SqlCommand cmd, Customer customer) {
            cmd.Parameters.AddWithValue("@UserName", customer.C_UserName);
            cmd.Parameters.AddWithValue("@Name", customer.C_Name);
            cmd.Parameters.AddWithValue("@Number", customer.C_Number);
            cmd.Parameters.AddWithValue("@Pass", customer.C_Pass);
            cmd.Parameters.AddWithValue("@Mail", customer.C_Mail);
            cmd.Parameters.AddWithValue("@Dob", customer.C_Dob);
        }
    }
}
