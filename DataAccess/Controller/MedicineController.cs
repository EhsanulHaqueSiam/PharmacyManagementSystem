using PharmacyManagementSystem.Model;
using PharmacyManagementSystem.DataAccess.DAO;
using System.Collections.Generic;

namespace PharmacyManagementSystem.Controllers {
    public class MedicineController {
        private readonly IMedicineDao _medicineDao;

        public MedicineController(IMedicineDao medicineDao) {
            _medicineDao = medicineDao;
        }

        public Medicine GetMedicineById(int id) {
            return _medicineDao.GetMedicineById(id);
        }

        public IEnumerable<Medicine> GetMedicineByName(string name) {
            return _medicineDao.GetMedicineByName(name);
        }

        public bool InsertMedicine(Medicine medicine) {
            return _medicineDao.InsertMedicine(medicine);
        }

        public bool UpdateMedicine(Medicine medicine) {
            return _medicineDao.UpdateMedicine(medicine);
        }

        public bool DeleteMedicine(int id) {
            return _medicineDao.DeleteMedicine(id);
        }

        public IEnumerable<Medicine> GetAllMedicines() {
            return _medicineDao.GetAllMedicines();
        }

        public IEnumerable<Medicine> GetExpiredMedicines() {
            return _medicineDao.GetExpiredMedicines();
        }

        public IEnumerable<Medicine> GetMedicinesByDateRange(string startDate, string endDate) {
            return _medicineDao.GetMedicinesByDateRange(startDate, endDate);
        }

        public IEnumerable<Medicine> GetMostPurchasedMedicines() {
            return _medicineDao.GetMostPurchasedMedicines();
        }

        public bool SoftDeleteMedicine(int id) {
            return _medicineDao.SoftDeleteMedicine(id);
        }
    }
}
