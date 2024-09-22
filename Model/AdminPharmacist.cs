using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Model {
    public class AdminPharmacist {
        public int A_ID { get; set; }
        public int P_ID { get; set; }

        public AdminPharmacist() { }

        public AdminPharmacist(int a_ID, int p_ID) {
            A_ID = a_ID;
            P_ID = p_ID;
        }
    }

}
