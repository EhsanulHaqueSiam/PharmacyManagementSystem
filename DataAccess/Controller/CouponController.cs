using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System.Collections.Generic;

namespace PharmacyManagementSystem.Controllers {
    public class CouponController {
        private readonly ICouponDao _couponDao;

        public CouponController(ICouponDao couponDao) {
            _couponDao = couponDao;
        }

        public void InsertCoupon(Coupon coupon) {
            _couponDao.Insert(coupon);
        }

        public Coupon GetCouponById(int id) {
            return _couponDao.GetById(id);
        }

        public List<Coupon> GetAllCoupons() {
            return _couponDao.GetAll();
        }

        public void UpdateCoupon(Coupon coupon) {
            _couponDao.Update(coupon);
        }

        public void DeleteCoupon(int id) {
            _couponDao.Delete(id);
        }
    }
}
