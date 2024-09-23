using PharmacyManagementSystem.DataAccess.Constants;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PharmacyManagementSystem.DataAccess {
    public class CouponDaoImpl : ICouponDao {
        public void Insert(Coupon coupon) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CouponQueries.InsertCoupon, connection)) {
                    cmd.Parameters.AddWithValue("@Code", coupon.C_Code);
                    cmd.Parameters.AddWithValue("@DiscountPercent", coupon.C_DiscountPercent);
                    cmd.Parameters.AddWithValue("@IsSingleUse", coupon.C_IsSingleUse);
                    cmd.Parameters.AddWithValue("@ExpiryDate", coupon.C_ExpiryDate);

                    cmd.ExecuteNonQuery();
                }
            });
        }

        public Coupon GetById(int id) {
            return SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CouponQueries.GetCouponById, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return new Coupon {
                                C_ID = (int)reader["C_ID"],
                                C_Code = reader["C_Code"].ToString(),
                                C_DiscountPercent = (decimal)reader["C_DiscountPercent"],
                                C_IsSingleUse = (bool)reader["C_IsSingleUse"],
                                C_ExpiryDate = (DateTime)reader["C_ExpiryDate"]
                            };
                        }
                        return null;
                    }
                }
            });
        }

        public List<Coupon> GetAll() {
            return SqlDatabaseManager.Instance.Execute(connection => {
                var coupons = new List<Coupon>();
                using (var cmd = new SqlCommand(CouponQueries.GetAllCoupons, connection)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            coupons.Add(new Coupon {
                                C_ID = (int)reader["C_ID"],
                                C_Code = reader["C_Code"].ToString(),
                                C_DiscountPercent = (decimal)reader["C_DiscountPercent"],
                                C_IsSingleUse = (bool)reader["C_IsSingleUse"],
                                C_ExpiryDate = (DateTime)reader["C_ExpiryDate"]
                            });
                        }
                    }
                }
                return coupons;
            });
        }

        public void Update(Coupon coupon) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CouponQueries.UpdateCoupon, connection)) {
                    cmd.Parameters.AddWithValue("@Id", coupon.C_ID);
                    cmd.Parameters.AddWithValue("@Code", coupon.C_Code);
                    cmd.Parameters.AddWithValue("@DiscountPercent", coupon.C_DiscountPercent);
                    cmd.Parameters.AddWithValue("@IsSingleUse", coupon.C_IsSingleUse);
                    cmd.Parameters.AddWithValue("@ExpiryDate", coupon.C_ExpiryDate);

                    cmd.ExecuteNonQuery();
                }
            });
        }

        public void Delete(int id) {
            SqlDatabaseManager.Instance.Execute(connection => {
                using (var cmd = new SqlCommand(CouponQueries.DeleteCoupon, connection)) {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            });
        }
    }
}
