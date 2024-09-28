using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.DataAccess;
using PharmacyManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.CustomerUC
{
    public partial class UC_C_Profile : UserControl
    {
        public UC_C_Profile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {

            userName_lbl.Text = Program.userName;

            ICustomerDao customerDao = new CustomerDaoImpl();
            CustomerController customerController = new CustomerController(customerDao);

            Customer cus = customerController.GetCustomerByUsername(userName_lbl.Text);
            mail_txt.Text = cus.C_Mail;
            mblNo_txt.Text = cus.C_Number;
            name_txt.Text = cus.C_Name;
            pass_txt.Text = cus.C_Pass;
            dob_txt.Text = cus.C_Dob.ToString();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {           

            ICustomerDao customerDao = new CustomerDaoImpl();
            CustomerController customerController = new CustomerController(customerDao);

            Customer cus = customerController.GetCustomerByUsername(Program.userName);

            Customer cus2 = new Customer
            {
                C_UserName = cus.C_UserName,
                C_Name = name_txt.Text,
                C_Mail = mail_txt.Text,
                C_Number = mblNo_txt.Text,
                C_Pass = pass_txt.Text,
                C_Dob = DateTime.Parse(dob_txt.Text),
                C_ID = cus.C_ID
            };

            if (customerController.UpdateCustomer(cus2))
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
