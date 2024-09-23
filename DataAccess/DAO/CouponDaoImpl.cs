using PharmacyManagementSystem.DataAccess.Constants;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PharmacyManagementSystem.DataAccess {
    public class CouponDaoImpl : ICouponDao {
        public Coupon GetCouponById(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CouponQueries.GET_COUPON_BY_ID, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return MapToCoupon(reader);
                        }
                        return null;
                    }
                }
            });
        }

        public bool InsertCoupon(Coupon coupon) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CouponQueries.INSERT_COUPON, connection)) {
                    AddCouponParameters(cmd, coupon);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool UpdateCoupon(Coupon coupon) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CouponQueries.UPDATE_COUPON, connection)) {
                    cmd.Parameters.AddWithValue("@Id", coupon.C_ID);
                    AddCouponParameters(cmd, coupon);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool DeleteCoupon(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CouponQueries.DELETE_COUPON, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public bool SoftDeleteCoupon(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CouponQueries.SOFT_DELETE_COUPON, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            });
        }

        public IEnumerable<Coupon> GetAllCoupons() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var coupons = new List<Coupon>();
                using (var cmd = new SqlCommand(CouponQueries.GET_ALL_COUPONS, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            coupons.Add(MapToCoupon(reader));
                        }
                    }
                }
                return coupons;
            });
        }

        public IEnumerable<Coupon> GetUnexpiredCoupons() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var coupons = new List<Coupon>();
                using (var cmd = new SqlCommand(CouponQueries.GET_UNEXPIRED_COUPONS, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            coupons.Add(MapToCoupon(reader));
                        }
                    }
                }
                return coupons;
            });
        }

        // Helper method to map SqlDataReader to Coupon model
        private Coupon MapToCoupon(SqlDataReader reader) {
            return new Coupon {
                C_ID = (int)reader["C_ID"],
                C_Code = reader["C_Code"].ToString(),
                C_DiscountPercent = (decimal)reader["C_DiscountPercent"],
                C_IsSingleUse = (bool)reader["C_IsSingleUse"],
                C_ExpiryDate = (DateTime)reader["C_ExpiryDate"]
            };
        }

        // Helper method to add parameters to SqlCommand
        private void AddCouponParameters(SqlCommand cmd, Coupon coupon) {
            cmd.Parameters.AddWithValue("@Code", coupon.C_Code);
            cmd.Parameters.AddWithValue("@DiscountPercent", coupon.C_DiscountPercent);
            cmd.Parameters.AddWithValue("@IsSingleUse", coupon.C_IsSingleUse);
            cmd.Parameters.AddWithValue("@ExpiryDate", coupon.C_ExpiryDate);
        }
    }
}
