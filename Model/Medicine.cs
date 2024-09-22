using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Model {
    public class Medicine {
        public int M_ID { get; set; }
        public string M_Name { get; set; }
        public string M_ChemicalName { get; set; }
        public int M_Quantity { get; set; }
        public decimal M_PricePerUnit { get; set; }
        public DateTime M_Date { get; set; }
        public DateTime Expiry_Date { get; set; }

        public Medicine() { }

        public Medicine(int m_ID, string m_Name, string m_ChemicalName, int m_Quantity, decimal m_PricePerUnit, DateTime m_Date, DateTime expiry_Date) {
            M_ID = m_ID;
            M_Name = m_Name;
            M_ChemicalName = m_ChemicalName;
            M_Quantity = m_Quantity;
            M_PricePerUnit = m_PricePerUnit;
            M_Date = m_Date;
            Expiry_Date = expiry_Date;
        }
    }

}
