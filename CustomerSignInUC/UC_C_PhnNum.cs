using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.CustomerSignInUC
{
    public partial class UC_C_PhnNum : UserControl
    {
        public UC_C_PhnNum()
        {
            InitializeComponent();
        }

        private void phnBack_btn_Click(object sender, EventArgs e)
        {            
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void phnNumNext_btn_Click(object sender, EventArgs e)
        {
            // Access the parent form
            SignInGui parentForm = this.FindForm() as SignInGui;



            if (parentForm != null)
            {
                // Call the method to switch user controls
                parentForm.SwitchToInfo();
            }
            else
            {
                MessageBox.Show("Parent form not found");
            }

        }
    }
}
