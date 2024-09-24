using PharmacyManagementSystem.Model;
using System.Collections.Generic;

namespace PharmacyManagementSystem.DataAccess.DAO {
    public interface IAdminDao {
        Admin GetAdminById(int adminId);
        Admin GetAdminByUsername(string username);
        Admin GetAdminByEmail(string email);
        IEnumerable<Admin> SearchAdminsByPartialUsername(string partialUsername);
        IEnumerable<Admin> SearchAdminsByPartialPhone(string partialPhone);
        bool InsertAdmin(Admin admin);
        bool UpdateAdmin(Admin admin);
        bool DeleteAdmin(int adminId);
        IEnumerable<Admin> GetAllAdmins();
        bool SoftDeleteAdmin(int adminId);
    }

    public interface IPharmacistDao {
        Pharmacist GetPharmacistById(int id);
        Pharmacist GetPharmacistByUsername(string username);
        Pharmacist GetPharmacistByEmail(string email);
        IEnumerable<Pharmacist> SearchPharmacistsByPartialUsername(string partialUsername);
        IEnumerable<Pharmacist> SearchPharmacistsByPartialPhone(string partialPhone);
        bool InsertPharmacist(Pharmacist pharmacist);
        bool UpdatePharmacist(Pharmacist pharmacist);
        bool DeletePharmacist(int id);
        IEnumerable<Pharmacist> GetAllPharmacists();
        bool SoftDeletePharmacist(int id);
    }

    public interface ICustomerDao {
        Customer GetCustomerById(int id);  // Get a customer by their ID
        Customer GetCustomerByUsername(string username);  // Get a customer by their username
        Customer GetCustomerByEmail(string email);  // Get a customer by their email
        IEnumerable<Customer> SearchCustomersByPartialUsername(string partialUsername);  // Search by username pattern
        IEnumerable<Customer> SearchCustomersByPartialPhone(string partialPhone);  // Search by phone number pattern
        bool InsertCustomer(Customer customer);  // Insert a new customer
        bool UpdateCustomer(Customer customer);  // Update an existing customer
        bool DeleteCustomer(int id);  // Hard delete (permanent)
        IEnumerable<Customer> GetAllCustomers();  // Get all customers
        bool SoftDeleteCustomer(int id);  // Soft delete (sets IsDeleted flag)
    }

    public interface IMedicineDao {
        Medicine GetMedicineById(int id);
        IEnumerable<Medicine> GetMedicineByName(string name);
        bool InsertMedicine(Medicine medicine);
        bool UpdateMedicine(Medicine medicine);
        bool DeleteMedicine(int id);
        IEnumerable<Medicine> GetAllMedicines();
        IEnumerable<Medicine> GetExpiredMedicines();
        IEnumerable<Medicine> GetMedicinesByDateRange(string startDate, string endDate);
        IEnumerable<Medicine> GetMostPurchasedMedicines();
        bool SoftDeleteMedicine(int id);
    }

    public interface ICouponDao {
        Coupon GetCouponById(int id);
        bool InsertCoupon(Coupon coupon);
        bool UpdateCoupon(Coupon coupon);
        bool DeleteCoupon(int id);
        IEnumerable<Coupon> GetAllCoupons();
        IEnumerable<Coupon> GetUnexpiredCoupons();
        bool SoftDeleteCoupon(int id);
    }

    public interface ITransactionDao {
        Transactions GetTransactionById(int id);
        bool InsertTransaction(Transactions transaction);
        bool UpdateTransaction(Transactions transaction);
        bool DeleteTransaction(int id);
        IEnumerable<Transactions> GetAllTransactions();
        IEnumerable<Transactions> GetTransactionsByDateRange(string startDate, string endDate);
    }
}
