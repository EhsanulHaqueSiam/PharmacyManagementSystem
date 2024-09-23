using PharmacyManagementSystem.DataAccess.Constants;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PharmacyManagementSystem.DataAccess {
    public class MedicineDaoImpl : IMedicineDao {
        public Medicine GetMedicineById(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(MedicineQueries.GET_MEDICINE_BY_ID, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return MapToMedicine(reader);
                        }
                        return null;
                    }
                }
            });
        }

        public IEnumerable<Medicine> GetMedicineByName(string name) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var medicines = new List<Medicine>();
                using (var cmd = new SqlCommand(MedicineQueries.GET_MEDICINE_BY_NAME, connection)) {
                    cmd.Parameters.AddWithValue("@Name", "%" + name + "%");
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            medicines.Add(MapToMedicine(reader));
                        }
                    }
                }
                return medicines;
            });
        }

        public bool InsertMedicine(Medicine medicine) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(MedicineQueries.INSERT_MEDICINE, connection)) {
                    AddMedicineParameters(cmd, medicine);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool UpdateMedicine(Medicine medicine) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(MedicineQueries.UPDATE_MEDICINE, connection)) {
                    cmd.Parameters.AddWithValue("@Id", medicine.M_ID);
                    AddMedicineParameters(cmd, medicine);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool DeleteMedicine(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(MedicineQueries.DELETE_MEDICINE, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool SoftDeleteMedicine(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(MedicineQueries.SOFT_DELETE_MEDICINE, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public IEnumerable<Medicine> GetAllMedicines() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var medicines = new List<Medicine>();
                using (var cmd = new SqlCommand(MedicineQueries.GET_ALL_MEDICINES, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            medicines.Add(MapToMedicine(reader));
                        }
                    }
                }
                return medicines;
            });
        }

        public IEnumerable<Medicine> GetExpiredMedicines() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var medicines = new List<Medicine>();
                using (var cmd = new SqlCommand(MedicineQueries.GET_EXPIRED_MEDICINES, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            medicines.Add(MapToMedicine(reader));
                        }
                    }
                }
                return medicines;
            });
        }

        public IEnumerable<Medicine> GetMedicinesByDateRange(string startDate, string endDate) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var medicines = new List<Medicine>();
                using (var cmd = new SqlCommand(MedicineQueries.GET_MEDICINES_BY_DATE_RANGE, connection)) {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            medicines.Add(MapToMedicine(reader));
                        }
                    }
                }
                return medicines;
            });
        }

        public IEnumerable<Medicine> GetMostPurchasedMedicines() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var medicines = new List<Medicine>();
                using (var cmd = new SqlCommand(MedicineQueries.GET_MOST_PURCHASED_MEDICINES, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            // Assuming we retrieve the medicine ID only, need further implementation to retrieve full medicine details based on M_ID
                            int medicineId = (int)reader["M_ID"];
                            var medicine = GetMedicineById(medicineId);
                            if (medicine != null) {
                                medicines.Add(medicine);
                            }
                        }
                    }
                }
                return medicines;
            });
        }

        // Helper method to map SqlDataReader to Medicine model
        private Medicine MapToMedicine(SqlDataReader reader) {
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

        // Helper method to add parameters to the SqlCommand
        private void AddMedicineParameters(SqlCommand cmd, Medicine medicine) {
            cmd.Parameters.AddWithValue("@Name", medicine.M_Name);
            cmd.Parameters.AddWithValue("@ChemicalName", medicine.M_ChemicalName);
            cmd.Parameters.AddWithValue("@Quantity", medicine.M_Quantity);
            cmd.Parameters.AddWithValue("@PricePerUnit", medicine.M_PricePerUnit);
            cmd.Parameters.AddWithValue("@Date", medicine.M_Date);
            cmd.Parameters.AddWithValue("@ExpiryDate", medicine.Expiry_Date);
        }
    }
}
