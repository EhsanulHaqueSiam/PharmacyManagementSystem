using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System.Collections.Generic;

namespace PharmacyManagementSystem.Controllers {
    public class PharmacistController {
        private readonly IPharmacistDao _pharmacistDao;

        public PharmacistController(IPharmacistDao pharmacistDao) {
            _pharmacistDao = pharmacistDao;
        }

        public void InsertPharmacist(Pharmacist pharmacist) {
            _pharmacistDao.Insert(pharmacist);
        }

        public Pharmacist GetPharmacistById(int id) {
            return _pharmacistDao.GetById(id);
        }

        public List<Pharmacist> GetAllPharmacists() {
            return _pharmacistDao.GetAll();
        }

        public void UpdatePharmacist(Pharmacist pharmacist) {
            _pharmacistDao.Update(pharmacist);
        }

        public void DeletePharmacist(int id) {
            _pharmacistDao.Delete(id);
        }
    }
}
