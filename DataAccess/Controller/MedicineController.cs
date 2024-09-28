using PharmacyManagementSystem.Model;
using PharmacyManagementSystem.DataAccess.DAO;
using System.Collections.Generic;
using System;

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

        public IEnumerable<Medicine> GetMedicineByChemicalName(string chemicalName) {
            return _medicineDao.GetMedicineByChemicalName(chemicalName);
        }

        public IEnumerable<Medicine> GetAllMedicines() {
            return _medicineDao.GetAllMedicines();
        }

        public IEnumerable<Medicine> GetExpiredMedicines() {
            return _medicineDao.GetExpiredMedicines();
        }

        public IEnumerable<Medicine> GetValidMedicines() {
            return _medicineDao.GetValidMedicines();
        }

        public IEnumerable<Medicine> GetMedicinesByDateRange(DateTime startDate, DateTime endDate) {
            return _medicineDao.GetMedicinesByDateRange(startDate, endDate);
        }

        public IEnumerable<Medicine> GetMedicinesByPriceRange(decimal minPrice, decimal maxPrice) {
            return _medicineDao.GetMedicinesByPriceRange(minPrice, maxPrice);
        }

        public IEnumerable<Medicine> GetLowStockMedicines(int threshold) {
            return _medicineDao.GetLowStockMedicines(threshold);
        }

        public IEnumerable<Medicine> GetMedicinesCloseToExpiry(DateTime expiryDate) {
            return _medicineDao.GetMedicinesCloseToExpiry(expiryDate);
        }

        public IEnumerable<Medicine> GetMostPurchasedMedicines() {
            return _medicineDao.GetMostPurchasedMedicines();
        }

        public IEnumerable<Medicine> GetMostExpensiveMedicines() {
            return _medicineDao.GetMostExpensiveMedicines();
        }

        public IEnumerable<Medicine> GetCheapestMedicines() {
            return _medicineDao.GetCheapestMedicines();
        }

        public IEnumerable<Medicine> GetRecentlyAddedMedicines(DateTime startDate, DateTime endDate) {
            return _medicineDao.GetRecentlyAddedMedicines(startDate, endDate);
        }

        public int CountTotalMedicine() {
            return _medicineDao.GetCountOfTotalMedicines();
        }

        public int CountValidMedicine() {
            return _medicineDao.GetCountOfValidMedicines();
        }

        public int CountExpiredMedicine() {
            return _medicineDao.GetCountOfExpiredMedicines();
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

        public bool SoftDeleteMedicine(int id) {
            return _medicineDao.SoftDeleteMedicine(id);
        }
    }
}
