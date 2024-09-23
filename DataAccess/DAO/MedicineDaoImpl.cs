using PharmacyManagementSystem.DataAccess.Constants;
using PharmacyManagementSystem.Model;
using PharmacyManagementSystem.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PharmacyManagementSystem.DataAccess {
    public class MedicineDaoImpl : IMedicineDao {
        public void Insert(Medicine medicine) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(MedicineQueries.InsertMedicine, connection)) {
                    cmd.Parameters.AddWithValue("@Name", medicine.M_Name);
                    cmd.Parameters.AddWithValue("@ChemicalName", medicine.M_ChemicalName);
                    cmd.Parameters.AddWithValue("@Quantity", medicine.M_Quantity);
                    cmd.Parameters.AddWithValue("@PricePerUnit", medicine.M_PricePerUnit);
                    cmd.Parameters.AddWithValue("@Date", medicine.M_Date);
                    cmd.Parameters.AddWithValue("@ExpiryDate", medicine.Expiry_Date);

                    cmd.ExecuteNonQuery();
                }
            });
        }

        public Medicine GetById(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(MedicineQueries.GetMedicineById, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return new Medicine {
                                M_ID = (int)reader["M_ID"],
                                M_Name = reader["M_Name"].ToString(),
                                M_ChemicalName = reader["M_ChemicalName"].ToString(),
                                M_Quantity = (int)reader["M_Quantity"],
                                M_PricePerUnit = (decimal)reader["M_PricePerUnit"],
                                M_Date = (DateTime)reader["M_Date"],
                                Expiry_Date = (DateTime)reader["Expiry_Date"]
                            };
                        }
                        return null;
                    }
                }
            });
        }

        public List<Medicine> GetAll() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var medicines = new List<Medicine>();
                using (var cmd = new SqlCommand(MedicineQueries.GetAllMedicines, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            medicines.Add(new Medicine {
                                M_ID = (int)reader["M_ID"],
                                M_Name = reader["M_Name"].ToString(),
                                M_ChemicalName = reader["M_ChemicalName"].ToString(),
                                M_Quantity = (int)reader["M_Quantity"],
                                M_PricePerUnit = (decimal)reader["M_PricePerUnit"],
                                M_Date = (DateTime)reader["M_Date"],
                                Expiry_Date = (DateTime)reader["Expiry_Date"]
                            });
                        }
                    }
                }
                return medicines;
            });
        }

        public void Update(Medicine medicine) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(MedicineQueries.UpdateMedicine, connection)) {
                    cmd.Parameters.AddWithValue("@Id", medicine.M_ID);
                    cmd.Parameters.AddWithValue("@Name", medicine.M_Name);
                    cmd.Parameters.AddWithValue("@ChemicalName", medicine.M_ChemicalName);
                    cmd.Parameters.AddWithValue("@Quantity", medicine.M_Quantity);
                    cmd.Parameters.AddWithValue("@PricePerUnit", medicine.M_PricePerUnit);
                    cmd.Parameters.AddWithValue("@Date", medicine.M_Date);
                    cmd.Parameters.AddWithValue("@ExpiryDate", medicine.Expiry_Date);

                    cmd.ExecuteNonQuery();
                }
            });
        }

        public void Delete(int id) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(MedicineQueries.DeleteMedicine, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            });
        }
    }
}
