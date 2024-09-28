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
    public partial class ForgetPass : Form
    {
        public ForgetPass()
        {
            InitializeComponent();
        }

        private void ForgetPass_Load(object sender, EventArgs e)
        {
            uC_ForgetInfo1.Visible = true;
            uC_ForgetInfo1.BringToFront();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void uC_ForgetInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
