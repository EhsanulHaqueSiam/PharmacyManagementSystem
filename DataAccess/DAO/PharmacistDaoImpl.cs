using PharmacyManagementSystem.DataAccess.Constants;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PharmacyManagementSystem.DataAccess {
    public class PharmacistDaoImpl : IPharmacistDao {
        public Pharmacist GetPharmacistById(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(PharmacistQueries.GET_PHARMACIST_BY_ID, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return MapToPharmacist(reader);
                        }
                        return null;
                    }
                }
            });
        }

        public Pharmacist GetPharmacistByUsername(string username) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(PharmacistQueries.GET_PHARMACIST_BY_USERNAME, connection)) {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return MapToPharmacist(reader);
                        }
                        return null;
                    }
                }
            });
        }

        public Pharmacist GetPharmacistByEmail(string email) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(PharmacistQueries.GET_PHARMACIST_BY_EMAIL, connection)) {
                    cmd.Parameters.AddWithValue("@email", email);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return MapToPharmacist(reader);
                        }
                        return null;
                    }
                }
            });
        }

        public IEnumerable<Pharmacist> SearchPharmacistsByPartialUsername(string partialUsername) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var pharmacists = new List<Pharmacist>();
                using (var cmd = new SqlCommand(PharmacistQueries.SEARCH_PHARMACISTS_BY_PARTIAL_USERNAME, connection)) {
                    cmd.Parameters.AddWithValue("@partialUsername", "%" + partialUsername + "%");
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            pharmacists.Add(MapToPharmacist(reader));
                        }
                    }
                }
                return pharmacists;
            });
        }

        public IEnumerable<Pharmacist> SearchPharmacistsByPartialPhone(string partialPhone) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var pharmacists = new List<Pharmacist>();
                using (var cmd = new SqlCommand(PharmacistQueries.SEARCH_PHARMACISTS_BY_PARTIAL_PHONE, connection)) {
                    cmd.Parameters.AddWithValue("@partialPhone", "%" + partialPhone + "%");
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            pharmacists.Add(MapToPharmacist(reader));
                        }
                    }
                }
                return pharmacists;
            });
        }

        public bool InsertPharmacist(Pharmacist pharmacist) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(PharmacistQueries.INSERT_PHARMACIST, connection)) {
                    AddPharmacistParameters(cmd, pharmacist);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool UpdatePharmacist(Pharmacist pharmacist) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(PharmacistQueries.UPDATE_PHARMACIST, connection)) {
                    cmd.Parameters.AddWithValue("@Id", pharmacist.P_ID);
                    AddPharmacistParameters(cmd, pharmacist);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool DeletePharmacist(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(PharmacistQueries.DELETE_PHARMACIST, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool SoftDeletePharmacist(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(PharmacistQueries.SOFT_DELETE_PHARMACIST, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public IEnumerable<Pharmacist> GetAllPharmacists() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var pharmacists = new List<Pharmacist>();
                using (var cmd = new SqlCommand(PharmacistQueries.GET_ALL_PHARMACISTS, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            pharmacists.Add(MapToPharmacist(reader));
                        }
                    }
                }
                return pharmacists;
            });
        }

        public int CountPharmacists() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(PharmacistQueries.COUNT_PHARMACISTS, connection)) {
                    return (int)cmd.ExecuteScalar();  // Returns the count of pharmacists.
                }
            });
        }

        public bool ValidatePharmacistLogin(string usernameOrEmail, string password) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(PharmacistQueries.VALIDATE_PHARMACIST_LOGIN, connection)) {
                    // Check both username and email for login
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


        // Helper method to map SqlDataReader to Pharmacist model
        private Pharmacist MapToPharmacist(SqlDataReader reader) {
            return new Pharmacist {
                P_ID = (int)reader["P_ID"],
                P_UserName = reader["P_UserName"].ToString(),
                P_Name = reader["P_Name"].ToString(),
                P_Dob = reader["P_Dob"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["P_Dob"],
                P_Number = reader["P_Number"].ToString(),
                P_Pass = reader["P_Pass"].ToString(),
                P_Mail = reader["P_Mail"].ToString()
            };
        }

        // Helper method to add parameters to the SqlCommand
        private void AddPharmacistParameters(SqlCommand cmd, Pharmacist pharmacist) {
            cmd.Parameters.AddWithValue("@UserName", pharmacist.P_UserName);
            cmd.Parameters.AddWithValue("@Name", pharmacist.P_Name);
            cmd.Parameters.AddWithValue("@Dob", pharmacist.P_Dob.HasValue ? (object)pharmacist.P_Dob.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@Number", pharmacist.P_Number);
            cmd.Parameters.AddWithValue("@Pass", pharmacist.P_Pass);
            cmd.Parameters.AddWithValue("@Mail", pharmacist.P_Mail);
        }
    }
}
