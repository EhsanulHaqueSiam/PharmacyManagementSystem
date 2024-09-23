using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System.Collections.Generic;

namespace PharmacyManagementSystem.Controllers {
    public class TransactionController {
        private readonly ITransactionDao _transactionDao;

        public TransactionController(ITransactionDao transactionDao) {
            _transactionDao = transactionDao;
        }

        public void InsertTransaction(Transactions transaction) {
            _transactionDao.Insert(transaction);
        }

        public Transactions GetTransactionById(int id) {
            return _transactionDao.GetById(id);
        }

        public List<Transactions> GetAllTransactions() {
            return _transactionDao.GetAll();
        }

        public void UpdateTransaction(Transactions transaction) {
            _transactionDao.Update(transaction);
        }

        public void DeleteTransaction(int id) {
            _transactionDao.Delete(id);
        }
    }
}
