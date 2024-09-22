using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Model {
    public class Admin {
        public int A_ID { get; set; }
        public string A_UserName { get; set; }
        public string A_Name { get; set; }
        public DateTime? A_Dob { get; set; }
        public string A_Number { get; set; }
        public string A_Pass { get; set; }
        public string A_Mail { get; set; }

        public Admin() { }

        public Admin(int a_ID, string a_UserName, string a_Name, DateTime? a_Dob, string a_Number, string a_Pass, string a_Mail) {
            A_ID = a_ID;
            A_UserName = a_UserName;
            A_Name = a_Name;
            A_Dob = a_Dob;
            A_Number = a_Number;
            A_Pass = a_Pass;
            A_Mail = a_Mail;
        }
    }


}
