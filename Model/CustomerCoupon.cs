using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Model {
    public class CustomerCoupon {
        public int C_ID { get; set; }
        public int C_ID_Coupon { get; set; }

        public CustomerCoupon() { }

        public CustomerCoupon(int c_ID, int c_ID_Coupon) {
            C_ID = c_ID;
            C_ID_Coupon = c_ID_Coupon;
        }
    }

}
