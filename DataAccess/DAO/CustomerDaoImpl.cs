using PharmacyManagementSystem.DataAccess.Constants;
using PharmacyManagementSystem.Model;
using PharmacyManagementSystem.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PharmacyManagementSystem.DataAccess {
    public class CustomerDaoImpl : ICustomerDao {
        public void Insert(Customer customer) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CustomerQueries.InsertCustomer, connection)) {
                    cmd.Parameters.AddWithValue("@UserName", customer.C_UserName);
                    cmd.Parameters.AddWithValue("@Name", customer.C_Name);
                    cmd.Parameters.AddWithValue("@Address", customer.C_Address);
                    cmd.Parameters.AddWithValue("@Number", customer.C_Number);
                    cmd.Parameters.AddWithValue("@Pass", customer.C_Pass);
                    cmd.Parameters.AddWithValue("@Mail", customer.C_Mail);

                    cmd.ExecuteNonQuery();
                }
            });
        }

        public Customer GetById(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CustomerQueries.GetCustomerById, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return new Customer {
                                C_ID = (int)reader["C_ID"],
                                C_UserName = reader["C_UserName"].ToString(),
                                C_Name = reader["C_Name"].ToString(),
                                C_Address = reader["C_Address"].ToString(),
                                C_Number = reader["C_Number"].ToString(),
                                C_Pass = reader["C_Pass"].ToString(),
                                C_Mail = reader["C_Mail"].ToString()
                            };
                        }
                        return null;
                    }
                }
            });
        }

        public List<Customer> GetAll() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var customers = new List<Customer>();
                using (var cmd = new SqlCommand(CustomerQueries.GetAllCustomers, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            customers.Add(new Customer {
                                C_ID = (int)reader["C_ID"],
                                C_UserName = reader["C_UserName"].ToString(),
                                C_Name = reader["C_Name"].ToString(),
                                C_Address = reader["C_Address"].ToString(),
                                C_Number = reader["C_Number"].ToString(),
                                C_Pass = reader["C_Pass"].ToString(),
                                C_Mail = reader["C_Mail"].ToString()
                            });
                        }
                    }
                }
                return customers;
            });
        }

        public void Update(Customer customer) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CustomerQueries.UpdateCustomer, connection)) {
                    cmd.Parameters.AddWithValue("@Id", customer.C_ID);
                    cmd.Parameters.AddWithValue("@UserName", customer.C_UserName);
                    cmd.Parameters.AddWithValue("@Name", customer.C_Name);
                    cmd.Parameters.AddWithValue("@Address", customer.C_Address);
                    cmd.Parameters.AddWithValue("@Number", customer.C_Number);
                    cmd.Parameters.AddWithValue("@Pass", customer.C_Pass);
                    cmd.Parameters.AddWithValue("@Mail", customer.C_Mail);

                    cmd.ExecuteNonQuery();
                }
            });
        }

        public void Delete(int id) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CustomerQueries.DeleteCustomer, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            });
        }
    }
}
