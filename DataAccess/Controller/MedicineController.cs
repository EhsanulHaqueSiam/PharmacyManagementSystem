using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System.Collections.Generic;

namespace PharmacyManagementSystem.Controllers {
    public class MedicineController {
        private readonly IMedicineDao _medicineDao;

        public MedicineController(IMedicineDao medicineDao) {
            _medicineDao = medicineDao;
        }

        public void InsertMedicine(Medicine medicine) {
            _medicineDao.Insert(medicine);
        }

        public Medicine GetMedicineById(int id) {
            return _medicineDao.GetById(id);
        }

        public List<Medicine> GetAllMedicines() {
            return _medicineDao.GetAll();
        }

        public void UpdateMedicine(Medicine medicine) {
            _medicineDao.Update(medicine);
        }

        public void DeleteMedicine(int id) {
            _medicineDao.Delete(id);
        }
    }
}
