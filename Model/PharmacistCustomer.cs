using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Model {
    public class PharmacistCustomer {
        public int P_ID { get; set; }
        public int C_ID { get; set; }

        public PharmacistCustomer() { }

        public PharmacistCustomer(int p_ID, int c_ID) {
            P_ID = p_ID;
            C_ID = c_ID;
        }
    }

}
