using PharmacyManagementSystem.DataAccess.Constants;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PharmacyManagementSystem.DataAccess {
    public class TransactionDaoImpl : ITransactionDao {
        public Transactions GetTransactionById(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(TransactionQueries.GET_TRANSACTION_BY_ID, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return MapToTransaction(reader);
                        }
                        return null;
                    }
                }
            });
        }

        public bool InsertTransaction(Transactions transaction) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(TransactionQueries.INSERT_TRANSACTION, connection)) {
                    AddTransactionParameters(cmd, transaction);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool UpdateTransaction(Transactions transaction) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(TransactionQueries.UPDATE_TRANSACTION, connection)) {
                    cmd.Parameters.AddWithValue("@Id", transaction.T_ID);
                    AddTransactionParameters(cmd, transaction);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool DeleteTransaction(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(TransactionQueries.DELETE_TRANSACTION, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public IEnumerable<Transactions> GetAllTransactions() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var transactions = new List<Transactions>();
                using (var cmd = new SqlCommand(TransactionQueries.GET_ALL_TRANSACTIONS, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            transactions.Add(MapToTransaction(reader));
                        }
                    }
                }
                return transactions;
            });
        }

        public IEnumerable<Transactions> GetTransactionsByDateRange(DateTime startDate, DateTime endDate) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var transactions = new List<Transactions>();
                using (var cmd = new SqlCommand(TransactionQueries.GET_TRANSACTIONS_BY_DATE_RANGE, connection)) {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            transactions.Add(MapToTransaction(reader));
                        }
                    }
                }
                return transactions;
            });
        }

        // Helper method to map SqlDataReader to Transactions model
        private Transactions MapToTransaction(SqlDataReader reader) {
            return new Transactions {
                T_ID = (int)reader["T_ID"],
                T_Date = (DateTime)reader["T_Date"],
                T_TotalAmount = (decimal)reader["T_TotalAmount"],
                T_PaymentType = reader["T_PaymentType"].ToString(),
                C_ID = (int)reader["C_ID"]
            };
        }

        // Helper method to add parameters to SqlCommand
        private void AddTransactionParameters(SqlCommand cmd, Transactions transaction) {
            cmd.Parameters.AddWithValue("@Date", transaction.T_Date);
            cmd.Parameters.AddWithValue("@TotalAmount", transaction.T_TotalAmount);
            cmd.Parameters.AddWithValue("@PaymentType", transaction.T_PaymentType);
            cmd.Parameters.AddWithValue("@CustomerId", transaction.C_ID);
        }
    }
}
