using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Model {
    public class Customer {
        public int C_ID { get; set; }
        public string C_UserName { get; set; }
        public string C_Name { get; set; }
        public string C_Address { get; set; }
        public string C_Number { get; set; }
        public string C_Pass { get; set; }
        public string C_Mail { get; set; }
        public DateTime C_Dob { get; set; } // Added Date of Birth for consistency with the DB schema

        // Parameterless constructor
        public Customer() { }

        // Parameterized constructor
        public Customer(int c_ID, string c_UserName, string c_Name, string c_Address, string c_Number, string c_Pass, string c_Mail, DateTime c_Dob) {
            C_ID = c_ID;
            C_UserName = c_UserName;
            C_Name = c_Name;
            C_Address = c_Address;
            C_Number = c_Number;
            C_Pass = c_Pass;
            C_Mail = c_Mail;
            C_Dob = c_Dob; // Date of Birth included
        }
    }

}
