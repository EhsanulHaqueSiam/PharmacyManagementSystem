using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Model {
    public class CustomerMedicine {
        public int T_ID { get; set; }
        public int M_ID { get; set; }
        public int Quantity { get; set; }

        public CustomerMedicine() { }

        public CustomerMedicine(int t_ID, int m_ID, int quantity) {
            T_ID = t_ID;
            M_ID = m_ID;
            Quantity = quantity;
        }
    }

}
