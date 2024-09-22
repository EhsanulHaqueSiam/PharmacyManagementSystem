using PharmacyManagementSystem.Model;
using System.Collections.Generic;


namespace PharmacyManagementSystem.DataAccess.DAO {
    public interface IAdminDao {
        Admin GetAdminById(int adminId);
        Admin GetAdminByUsername(string username);
        bool AddAdmin(Admin admin);
        bool UpdateAdmin(Admin admin);
        bool DeleteAdmin(int adminId);
        IEnumerable<Admin> GetAllAdmins();
    }

    public interface IPharmacistDao {
        void Insert(Pharmacist pharmacist);
        Pharmacist GetById(int id);
        List<Pharmacist> GetAll();
        void Update(Pharmacist pharmacist);
        void Delete(int id);
    }

    public interface ICustomerDao {
        void Insert(Customer customer);
        Customer GetById(int id);
        List<Customer> GetAll();
        void Update(Customer customer);
        void Delete(int id);
    }

    public interface IMedicineDao {
        void Insert(Medicine medicine);
        Medicine GetById(int id);
        List<Medicine> GetAll();
        void Update(Medicine medicine);
        void Delete(int id);
    }

    public interface ICouponDao {
        void Insert(Coupon coupon);
        Coupon GetById(int id);
        List<Coupon> GetAll();
        void Update(Coupon coupon);
        void Delete(int id);
    }

    public interface ITransactionDao {
        void Insert(Transactions transaction);
        Transactions GetById(int id);
        List<Transactions> GetAll();
        void Update(Transactions transaction);
        void Delete(int id);
    }
}
