using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Model {
    public class Coupon {
        public int C_ID { get; set; }
        public string C_Code { get; set; }
        public decimal C_DiscountPercent { get; set; }
        public bool C_IsSingleUse { get; set; }
        public DateTime C_ExpiryDate { get; set; }

        public Coupon() { }

        public Coupon(int c_ID, string c_Code, decimal c_DiscountPercent, bool c_IsSingleUse, DateTime c_ExpiryDate) {
            C_ID = c_ID;
            C_Code = c_Code;
            C_DiscountPercent = c_DiscountPercent;
            C_IsSingleUse = c_IsSingleUse;
            C_ExpiryDate = c_ExpiryDate;
        }
    }

}
