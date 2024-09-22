using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Model {
    public class Pharmacist {
        public int P_ID { get; set; }
        public string P_UserName { get; set; }
        public string P_Name { get; set; }
        public DateTime? P_Dob { get; set; }
        public string P_Number { get; set; }
        public string P_Pass { get; set; }
        public string P_Mail { get; set; }

        public Pharmacist() { }

        public Pharmacist(int p_ID, string p_UserName, string p_Name, DateTime? p_Dob, string p_Number, string p_Pass, string p_Mail) {
            P_ID = p_ID;
            P_UserName = p_UserName;
            P_Name = p_Name;
            P_Dob = p_Dob;
            P_Number = p_Number;
            P_Pass = p_Pass;
            P_Mail = p_Mail;
        }
    }

}
