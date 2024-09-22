using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Model {
    public class Transactions {
        public int T_ID { get; set; }
        public DateTime T_Date { get; set; }
        public decimal T_TotalAmount { get; set; }
        public string T_PaymentType { get; set; }
        public int C_ID { get; set; }

        public Transactions() { }

        public Transactions(int t_ID, DateTime t_Date, decimal t_TotalAmount, string t_PaymentType, int c_ID) {
            T_ID = t_ID;
            T_Date = t_Date;
            T_TotalAmount = t_TotalAmount;
            T_PaymentType = t_PaymentType;
            C_ID = c_ID;
        }
    }

}
