using PharmacyManagementSystem.DataAccess;
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

        public bool AddAdmin(Admin admin) {
            return _adminDao.AddAdmin(admin);
        }

        public bool UpdateAdmin(Admin admin) {
            return _adminDao.UpdateAdmin(admin);
        }

        public bool DeleteAdmin(int id) {
            return _adminDao.DeleteAdmin(id);
        }

        public IEnumerable<Admin> GetAllAdmins() {
            return _adminDao.GetAllAdmins();
        }
    }
}
