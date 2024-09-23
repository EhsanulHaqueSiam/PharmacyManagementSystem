using PharmacyManagementSystem.Model;
using PharmacyManagementSystem.DataAccess;
using System.Collections.Generic;
using PharmacyManagementSystem.DataAccess.DAO;

namespace PharmacyManagementSystem.Controllers {
    public class CouponController {
        private readonly ICouponDao _couponDao;

        public CouponController(ICouponDao couponDao) {
            _couponDao = couponDao;
        }

        public Coupon GetCouponById(int id) {
            return _couponDao.GetCouponById(id);
        }

        public bool InsertCoupon(Coupon coupon) {
            return _couponDao.InsertCoupon(coupon);
        }

        public bool UpdateCoupon(Coupon coupon) {
            return _couponDao.UpdateCoupon(coupon);
        }

        public bool DeleteCoupon(int id) {
            return _couponDao.DeleteCoupon(id);
        }

        public IEnumerable<Coupon> GetAllCoupons() {
            return _couponDao.GetAllCoupons();
        }

        public IEnumerable<Coupon> GetUnexpiredCoupons() {
            return _couponDao.GetUnexpiredCoupons();
        }

        public bool SoftDeleteCoupon(int id) {
            return _couponDao.SoftDeleteCoupon(id);
        }
    }
}
