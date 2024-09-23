using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System.Collections.Generic;

namespace PharmacyManagementSystem.Controllers {
    public class CustomerController {
        private readonly ICustomerDao _customerDao;

        public CustomerController(ICustomerDao customerDao) {
            _customerDao = customerDao;
        }

        public void InsertCustomer(Customer customer) {
            _customerDao.Insert(customer);
        }

        public Customer GetCustomerById(int id) {
            return _customerDao.GetById(id);
        }

        public List<Customer> GetAllCustomers() {
            return _customerDao.GetAll();
        }

        public void UpdateCustomer(Customer customer) {
            _customerDao.Update(customer);
        }

        public void DeleteCustomer(int id) {
            _customerDao.Delete(id);
        }
    }
}
