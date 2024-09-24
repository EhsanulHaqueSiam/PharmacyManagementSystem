using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_UpdateMedicine : UserControl
    {
        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void clearAll() {
            medId_txtBox.ResetText();
            addQ_txtBox.Clear();
            chemName_txtBox.Clear();
            avlQ_txtBox.Clear();
            expireDate_txt.ResetText();
            manufactDate_txtbox.ResetText();
            medName_txtBox.ResetText();
            if (ppU_txtBox.Text != "0")
            {
                ppU_txtBox.ResetText();
            }
            else {
                ppU_txtBox.ResetText();
            }
            
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
