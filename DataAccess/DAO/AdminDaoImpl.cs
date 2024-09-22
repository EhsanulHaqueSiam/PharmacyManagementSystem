using PharmacyManagementSystem.DataAccess.DAO.Query;
using PharmacyManagementSystem.Model;
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
                            return new Admin {
                                A_ID = (int)reader["A_ID"],
                                A_UserName = reader["A_UserName"].ToString(),
                                A_Name = reader["A_Name"].ToString(),
                                A_Dob = (DateTime)reader["A_Dob"],
                                A_Number = reader["A_Number"].ToString(),
                                A_Pass = reader["A_Pass"].ToString(),
                                A_Mail = reader["A_Mail"].ToString()
                            };
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
                            return new Admin {
                                A_ID = (int)reader["A_ID"],
                                A_UserName = reader["A_UserName"].ToString(),
                                A_Name = reader["A_Name"].ToString(),
                                A_Dob = (DateTime)reader["A_Dob"],
                                A_Number = reader["A_Number"].ToString(),
                                A_Pass = reader["A_Pass"].ToString(),
                                A_Mail = reader["A_Mail"].ToString()
                            };
                        }
                        return null;
                    }
                }
            });
        }

        public bool AddAdmin(Admin admin) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(AdminSqlQueries.INSERT_ADMIN, connection)) {
                    cmd.Parameters.AddWithValue("@userName", admin.A_UserName);
                    cmd.Parameters.AddWithValue("@name", admin.A_Name);
                    cmd.Parameters.AddWithValue("@dob", admin.A_Dob);
                    cmd.Parameters.AddWithValue("@number", admin.A_Number);
                    cmd.Parameters.AddWithValue("@pass", admin.A_Pass);
                    cmd.Parameters.AddWithValue("@mail", admin.A_Mail);

                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool UpdateAdmin(Admin admin) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(AdminSqlQueries.UPDATE_ADMIN, connection)) {
                    cmd.Parameters.AddWithValue("@adminId", admin.A_ID);
                    cmd.Parameters.AddWithValue("@userName", admin.A_UserName);
                    cmd.Parameters.AddWithValue("@name", admin.A_Name);
                    cmd.Parameters.AddWithValue("@dob", admin.A_Dob);
                    cmd.Parameters.AddWithValue("@number", admin.A_Number);
                    cmd.Parameters.AddWithValue("@pass", admin.A_Pass);
                    cmd.Parameters.AddWithValue("@mail", admin.A_Mail);

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

        public IEnumerable<Admin> GetAllAdmins() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var admins = new List<Admin>();
                using (var cmd = new SqlCommand(AdminSqlQueries.GET_ALL_ADMINS, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            admins.Add(new Admin {
                                A_ID = (int)reader["A_ID"],
                                A_UserName = reader["A_UserName"].ToString(),
                                A_Name = reader["A_Name"].ToString(),
                                A_Dob = (DateTime)reader["A_Dob"],
                                A_Number = reader["A_Number"].ToString(),
                                A_Pass = reader["A_Pass"].ToString(),
                                A_Mail = reader["A_Mail"].ToString()
                            });
                        }
                    }
                }
                return admins;
            });
        }
    }
}
