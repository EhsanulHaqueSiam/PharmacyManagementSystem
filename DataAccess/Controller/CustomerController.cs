using PharmacyManagementSystem.Model;
using PharmacyManagementSystem.DataAccess.DAO;
using System.Collections.Generic;

namespace PharmacyManagementSystem.Controllers {
    public class CustomerController {
        private readonly ICustomerDao _customerDao;

        public CustomerController(ICustomerDao customerDao) {
            _customerDao = customerDao;
        }

        public Customer GetCustomerById(int id) {
            return _customerDao.GetCustomerById(id);
        }

        public Customer GetCustomerByUsername(string username) {
            return _customerDao.GetCustomerByUsername(username);
        }

        public Customer GetCustomerByEmail(string email) {
            return _customerDao.GetCustomerByEmail(email);
        }

        public IEnumerable<Customer> SearchCustomersByPartialUsername(string partialUsername) {
            return _customerDao.SearchCustomersByPartialUsername(partialUsername);
        }

        public IEnumerable<Customer> SearchCustomersByPartialPhone(string partialPhone) {
            return _customerDao.SearchCustomersByPartialPhone(partialPhone);
        }

        public bool InsertCustomer(Customer customer) {
            return _customerDao.InsertCustomer(customer);
        }

        public bool UpdateCustomer(Customer customer) {
            return _customerDao.UpdateCustomer(customer);
        }

        public bool DeleteCustomer(int id) {
            return _customerDao.DeleteCustomer(id);
        }

        public bool SoftDeleteCustomer(int id) {
            return _customerDao.SoftDeleteCustomer(id);
        }

        public IEnumerable<Customer> GetAllCustomers() {
            return _customerDao.GetAllCustomers();
        }

        public int CountCustomers() { 
            return _customerDao.CountCustomers();
        }

        public bool Login(string usernameOrEmail, string password) {
            return _customerDao.ValidateCustomerLogin(usernameOrEmail, password);
        }
    }
}
