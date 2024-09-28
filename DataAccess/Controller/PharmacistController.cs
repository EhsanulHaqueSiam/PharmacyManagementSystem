using PharmacyManagementSystem.Model;
using PharmacyManagementSystem.DataAccess.DAO;
using System.Collections.Generic;

namespace PharmacyManagementSystem.Controllers {
    public class PharmacistController {
        private readonly IPharmacistDao _pharmacistDao;

        public PharmacistController(IPharmacistDao pharmacistDao) {
            _pharmacistDao = pharmacistDao;
        }

        public Pharmacist GetPharmacistById(int id) {
            return _pharmacistDao.GetPharmacistById(id);
        }

        public Pharmacist GetPharmacistByUsername(string username) {
            return _pharmacistDao.GetPharmacistByUsername(username);
        }

        public Pharmacist GetPharmacistByEmail(string email) {
            return _pharmacistDao.GetPharmacistByEmail(email);
        }

        public IEnumerable<Pharmacist> SearchPharmacistsByPartialUsername(string partialUsername) {
            return _pharmacistDao.SearchPharmacistsByPartialUsername(partialUsername);
        }

        public IEnumerable<Pharmacist> SearchPharmacistsByPartialPhone(string partialPhone) {
            return _pharmacistDao.SearchPharmacistsByPartialPhone(partialPhone);
        }

        public bool InsertPharmacist(Pharmacist pharmacist) {
            return _pharmacistDao.InsertPharmacist(pharmacist);
        }

        public bool UpdatePharmacist(Pharmacist pharmacist) {
            return _pharmacistDao.UpdatePharmacist(pharmacist);
        }

        public bool DeletePharmacist(int id) {
            return _pharmacistDao.DeletePharmacist(id);
        }

        public bool SoftDeletePharmacist(int id) {
            return _pharmacistDao.SoftDeletePharmacist(id);
        }

        public IEnumerable<Pharmacist> GetAllPharmacists() {
            return _pharmacistDao.GetAllPharmacists();
        }

        public int CountPharmacists() {
            return _pharmacistDao.CountPharmacists();
        }

        public bool Login(string usernameOrEmail, string password) {
            return _pharmacistDao.ValidatePharmacistLogin(usernameOrEmail, password);
        }
    }
}
