using PharmacyManagementSystem.DataAccess.Constants;
using PharmacyManagementSystem.Model;
using PharmacyManagementSystem.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PharmacyManagementSystem.DataAccess {
    public class AdminDaoImpl : IAdminDao {
        public Admin GetAdminById(int adminId) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(AdminSqlQueries.GET_ADMIN_BY_ID, connection)) {
                    cmd.Parameters.AddWithValue("@adminId", adminId);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return MapToAdmin(reader);
                        }
                        return null;
                    }
                }
            });
        }

        public Admin GetAdminByUsername(string username) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(AdminSqlQueries.GET_ADMIN_BY_USERNAME, connection)) {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return MapToAdmin(reader);
                        }
                        return null;
                    }
                }
            });
        }

        public Admin GetAdminByEmail(string email) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(AdminSqlQueries.GET_ADMIN_BY_EMAIL, connection)) {
                    cmd.Parameters.AddWithValue("@email", email);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return MapToAdmin(reader);
                        }
                        return null;
                    }
                }
            });
        }

        public IEnumerable<Admin> SearchAdminsByPartialUsername(string partialUsername) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var admins = new List<Admin>();
                using (var cmd = new SqlCommand(AdminSqlQueries.SEARCH_ADMINS_BY_PARTIAL_USERNAME, connection)) {
                    cmd.Parameters.AddWithValue("@partialUsername", "%" + partialUsername + "%");
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            admins.Add(MapToAdmin(reader));
                        }
                    }
                }
                return admins;
            });
        }

        public IEnumerable<Admin> SearchAdminsByPartialPhone(string partialPhone) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var admins = new List<Admin>();
                using (var cmd = new SqlCommand(AdminSqlQueries.SEARCH_ADMINS_BY_PARTIAL_PHONE, connection)) {
                    cmd.Parameters.AddWithValue("@partialPhone", "%" + partialPhone + "%");
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            admins.Add(MapToAdmin(reader));
                        }
                    }
                }
                return admins;
            });
        }

        public bool InsertAdmin(Admin admin) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(AdminSqlQueries.INSERT_ADMIN, connection)) {
                    AddAdminParameters(cmd, admin);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool UpdateAdmin(Admin admin) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(AdminSqlQueries.UPDATE_ADMIN, connection)) {
                    cmd.Parameters.AddWithValue("@adminId", admin.A_ID);
                    AddAdminParameters(cmd, admin);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool DeleteAdmin(int adminId) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(AdminSqlQueries.DELETE_ADMIN, connection)) {
                    cmd.Parameters.AddWithValue("@adminId", adminId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool SoftDeleteAdmin(int adminId) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(AdminSqlQueries.SOFT_DELETE_ADMIN, connection)) {
                    cmd.Parameters.AddWithValue("@adminId", adminId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public IEnumerable<Admin> GetAllAdmins() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var admins = new List<Admin>();
                using (var cmd = new SqlCommand(AdminSqlQueries.GET_ALL_ADMINS, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            admins.Add(MapToAdmin(reader));
                        }
                    }
                }
                return admins;
            });
        }

        public int CountAdmins() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(AdminSqlQueries.COUNT_ADMINS, connection)) {
                    return (int)cmd.ExecuteScalar();  // Returns the count of admins.
                }
            });
        }

        public bool ValidateAdminLogin(string usernameOrEmail, string password) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(AdminSqlQueries.VALIDATE_ADMIN_LOGIN, connection)) {
                    // Check both username and email for login.
                    cmd.Parameters.AddWithValue("@UserName", usernameOrEmail);
                    cmd.Parameters.AddWithValue("@Email", usernameOrEmail);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (var reader = cmd.ExecuteReader()) {
                        // If the query returns a result, login is successful
                        return reader.HasRows;
                    }
                }
            });
        }

        // Helper method to map SqlDataReader to Admin model
        private Admin MapToAdmin(SqlDataReader reader) {
            return new Admin {
                A_ID = (int)reader["A_ID"],
                A_UserName = reader["A_UserName"].ToString(),
                A_Name = reader["A_Name"].ToString(),
                A_Dob = reader["A_Dob"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["A_Dob"],
                A_Number = reader["A_Number"].ToString(),
                A_Pass = reader["A_Pass"].ToString(),
                A_Mail = reader["A_Mail"].ToString()
            };
        }

        // Helper method to add parameters to the SqlCommand
        private void AddAdminParameters(SqlCommand cmd, Admin admin) {
            cmd.Parameters.AddWithValue("@userName", admin.A_UserName);
            cmd.Parameters.AddWithValue("@name", admin.A_Name);
            cmd.Parameters.AddWithValue("@dob", admin.A_Dob.HasValue ? (object)admin.A_Dob.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@number", admin.A_Number);
            cmd.Parameters.AddWithValue("@pass", admin.A_Pass);
            cmd.Parameters.AddWithValue("@mail", admin.A_Mail);
        }
    }
}
