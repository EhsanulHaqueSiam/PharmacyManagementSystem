using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System.Collections.Generic;

namespace PharmacyManagementSystem.Controllers {
    public class AdminController {
        private readonly IAdminDao _adminDao;

        public AdminController(IAdminDao adminDao) {
            _adminDao = adminDao;
        }

        public Admin GetAdminById(int id) {
            return _adminDao.GetAdminById(id);
        }

        public Admin GetAdminByUsername(string username) {
            return _adminDao.GetAdminByUsername(username);
        }

        public Admin GetAdminByEmail(string email) {
            return _adminDao.GetAdminByEmail(email);
        }

        public IEnumerable<Admin> SearchAdminsByPartialUsername(string partialUsername) {
            return _adminDao.SearchAdminsByPartialUsername(partialUsername);
        }

        public IEnumerable<Admin> SearchAdminsByPartialPhone(string partialPhone) {
            return _adminDao.SearchAdminsByPartialPhone(partialPhone);
        }

        public bool InsertAdmin(Admin admin) {
            return _adminDao.InsertAdmin(admin);
        }

        public bool UpdateAdmin(Admin admin) {
            return _adminDao.UpdateAdmin(admin);
        }

        public bool DeleteAdmin(int id) {
            return _adminDao.DeleteAdmin(id);
        }

        public bool SoftDeleteAdmin(int id) {
            return _adminDao.SoftDeleteAdmin(id);
        }

        public IEnumerable<Admin> GetAllAdmins() {
            return _adminDao.GetAllAdmins();
        }

        public int CountAdmins() {
            return _adminDao.CountAdmins();
        }
        public bool Login(string usernameOrEmail, string password) {
            return _adminDao.ValidateAdminLogin(usernameOrEmail, password);
        }
    }
}
