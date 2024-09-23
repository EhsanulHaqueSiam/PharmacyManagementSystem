using PharmacyManagementSystem.DataAccess.Constants;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PharmacyManagementSystem.DataAccess {
    public class TransactionDaoImpl : ITransactionDao {
        public void Insert(Transactions transaction) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(TransactionQueries.InsertTransaction, connection)) {
                    cmd.Parameters.AddWithValue("@Date", transaction.T_Date);
                    cmd.Parameters.AddWithValue("@TotalAmount", transaction.T_TotalAmount);
                    cmd.Parameters.AddWithValue("@PaymentType", transaction.T_PaymentType);
                    cmd.Parameters.AddWithValue("@CustomerId", transaction.C_ID);

                    cmd.ExecuteNonQuery();
                }
            });
        }

        public Transactions GetById(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(TransactionQueries.GetTransactionById, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return new Transactions {
                                T_ID = (int)reader["T_ID"],
                                T_Date = (DateTime)reader["T_Date"],
                                T_TotalAmount = (decimal)reader["T_TotalAmount"],
                                T_PaymentType = reader["T_PaymentType"].ToString(),
                                C_ID = (int)reader["C_ID"]
                            };
                        }
                        return null;
                    }
                }
            });
        }

        public List<Transactions> GetAll() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var transactions = new List<Transactions>();
                using (var cmd = new SqlCommand(TransactionQueries.GetAllTransactions, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            transactions.Add(new Transactions {
                                T_ID = (int)reader["T_ID"],
                                T_Date = (DateTime)reader["T_Date"],
                                T_TotalAmount = (decimal)reader["T_TotalAmount"],
                                T_PaymentType = reader["T_PaymentType"].ToString(),
                                C_ID = (int)reader["C_ID"]
                            });
                        }
                    }
                }
                return transactions;
            });
        }

        public void Update(Transactions transaction) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(TransactionQueries.UpdateTransaction, connection)) {
                    cmd.Parameters.AddWithValue("@Id", transaction.T_ID);
                    cmd.Parameters.AddWithValue("@Date", transaction.T_Date);
                    cmd.Parameters.AddWithValue("@TotalAmount", transaction.T_TotalAmount);
                    cmd.Parameters.AddWithValue("@PaymentType", transaction.T_PaymentType);
                    cmd.Parameters.AddWithValue("@CustomerId", transaction.C_ID);

                    cmd.ExecuteNonQuery();
                }
            });
        }

        public void Delete(int id) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(TransactionQueries.DeleteTransaction, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            });
        }
    }
}
