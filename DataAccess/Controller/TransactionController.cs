using PharmacyManagementSystem.Model;
using PharmacyManagementSystem.DataAccess;
using System.Collections.Generic;
using PharmacyManagementSystem.DataAccess.DAO;

namespace PharmacyManagementSystem.Controllers {
    public class TransactionController {
        private readonly ITransactionDao _transactionDao;

        public TransactionController(ITransactionDao transactionDao) {
            _transactionDao = transactionDao;
        }

        public Transactions GetTransactionById(int id) {
            return _transactionDao.GetTransactionById(id);
        }

        public bool InsertTransaction(Transactions transaction) {
            return _transactionDao.InsertTransaction(transaction);
        }

        public bool UpdateTransaction(Transactions transaction) {
            return _transactionDao.UpdateTransaction(transaction);
        }

        public bool DeleteTransaction(int id) {
            return _transactionDao.DeleteTransaction(id);
        }

        public IEnumerable<Transactions> GetAllTransactions() {
            return _transactionDao.GetAllTransactions();
        }

        public IEnumerable<Transactions> GetTransactionsByDateRange(string startDate, string endDate) {
            return _transactionDao.GetTransactionsByDateRange(startDate, endDate);
        }
    }
}
