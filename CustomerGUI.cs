using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class CustomerGUI : Form
    {
        public CustomerGUI()
        {
            InitializeComponent();
        }

        private void uC_ViewUser1_Load(object sender, EventArgs e)
        {

        }

        private void CustomerGUI_Load(object sender, EventArgs e)
        {
            uC_C_Profile1.Visible = false;
            uC_P_SellMedicine1.Visible=false;
            Cprofile_Button.PerformClick();

        }

        private void Cprofile_Button_Click(object sender, EventArgs e)
        {
            uC_C_Profile1.Visible = true;
            uC_C_Profile1.BringToFront();
        }

        private void logout_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void buyMed_btn_Click(object sender, EventArgs e)
        {
            uC_P_SellMedicine1.Visible = true;
            uC_P_SellMedicine1.BringToFront();
        }
    }
}
