using PharmacyManagementSystem.DataAccess.Constants;
using PharmacyManagementSystem.Model;
using PharmacyManagementSystem.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PharmacyManagementSystem.DataAccess {
    public class PharmacistDaoImpl : IPharmacistDao {
        public void Insert(Pharmacist pharmacist) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(PharmacistQueries.InsertPharmacist, connection)) {
                    cmd.Parameters.AddWithValue("@UserName", pharmacist.P_UserName);
                    cmd.Parameters.AddWithValue("@Name", pharmacist.P_Name);
                    cmd.Parameters.AddWithValue("@Dob", pharmacist.P_Dob);
                    cmd.Parameters.AddWithValue("@Number", pharmacist.P_Number);
                    cmd.Parameters.AddWithValue("@Pass", pharmacist.P_Pass);
                    cmd.Parameters.AddWithValue("@Mail", pharmacist.P_Mail);

                    cmd.ExecuteNonQuery();
                }
            });
        }

        public Pharmacist GetById(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(PharmacistQueries.GetPharmacistById, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return new Pharmacist {
                                P_ID = (int)reader["P_ID"],
                                P_UserName = reader["P_UserName"].ToString(),
                                P_Name = reader["P_Name"].ToString(),
                                P_Dob = (DateTime?)reader["P_Dob"],
                                P_Number = reader["P_Number"].ToString(),
                                P_Pass = reader["P_Pass"].ToString(),
                                P_Mail = reader["P_Mail"].ToString()
                            };
                        }
                        return null;
                    }
                }
            });
        }

        public List<Pharmacist> GetAll() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var pharmacists = new List<Pharmacist>();
                using (var cmd = new SqlCommand(PharmacistQueries.GetAllPharmacists, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            pharmacists.Add(new Pharmacist {
                                P_ID = (int)reader["P_ID"],
                                P_UserName = reader["P_UserName"].ToString(),
                                P_Name = reader["P_Name"].ToString(),
                                P_Dob = (DateTime?)reader["P_Dob"],
                                P_Number = reader["P_Number"].ToString(),
                                P_Pass = reader["P_Pass"].ToString(),
                                P_Mail = reader["P_Mail"].ToString()
                            });
                        }
                    }
                }
                return pharmacists;
            });
        }

        public void Update(Pharmacist pharmacist) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(PharmacistQueries.UpdatePharmacist, connection)) {
                    cmd.Parameters.AddWithValue("@Id", pharmacist.P_ID);
                    cmd.Parameters.AddWithValue("@UserName", pharmacist.P_UserName);
                    cmd.Parameters.AddWithValue("@Name", pharmacist.P_Name);
                    cmd.Parameters.AddWithValue("@Dob", pharmacist.P_Dob);
                    cmd.Parameters.AddWithValue("@Number", pharmacist.P_Number);
                    cmd.Parameters.AddWithValue("@Pass", pharmacist.P_Pass);
                    cmd.Parameters.AddWithValue("@Mail", pharmacist.P_Mail);

                    cmd.ExecuteNonQuery();
                }
            });
        }

        public void Delete(int id) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(PharmacistQueries.DeletePharmacist, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            });
        }
    }
}
