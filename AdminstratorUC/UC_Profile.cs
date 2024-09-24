using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.DataAccess;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdminstratorUC
{
    public partial class UC_Profile : UserControl
    {
        public UC_Profile()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            reset_btn.PerformClick();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            userName_lbl.Text = Program.userName;

            if (Program.adminLog)
            {
                IAdminDao adminDao = new AdminDaoImpl();
                AdminController adminController = new AdminController(adminDao);

                Admin ad = adminController.GetAdminByUsername(userName_lbl.Text);
                mail_txt.Text = ad.A_Mail;
                mbl_txt.Text = ad.A_Number;
                name_txtBox.Text = ad.A_Name;
                pass_txt.Text = ad.A_Pass;
                dob_txt.Text = ad.A_Dob.ToString();
            }
            else if (Program.pharmLog)
            {
                IPharmacistDao pharmacistDao = new PharmacistDaoImpl();
                PharmacistController pharmacistController = new PharmacistController(pharmacistDao);

                Pharmacist ph = pharmacistController.GetPharmacistByUsername(userName_lbl.Text);
                mail_txt.Text = ph.P_Mail;
                mbl_txt.Text = ph.P_Number;
                name_txtBox.Text = ph.P_Name;
                pass_txt.Text = ph.P_Pass;
                dob_txt.Text = ph.P_Dob.ToString();
            }
            else if (Program.custLog)
            {
                ICustomerDao customerDao = new CustomerDaoImpl();
                CustomerController customerController = new CustomerController(customerDao);

                Customer cus = customerController.GetCustomerByUsername(userName_lbl.Text);
                mail_txt.Text = cus.C_Mail;
                mbl_txt.Text = cus.C_Number;
                name_txtBox.Text = cus.C_Name;
                pass_txt.Text = cus.C_Pass;
                dob_txt.Text = cus.C_Dob.ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            userName_lbl.Text = Program.userName;

            if (Program.adminLog)
            {
                IAdminDao adminDao = new AdminDaoImpl();
                AdminController adminController = new AdminController(adminDao);

                Admin ad = adminController.GetAdminByUsername(userName_lbl.Text);

                Admin ad2 = new Admin
                {
                    A_UserName = ad.A_UserName,
                    A_Name = name_txtBox.Text,
                    A_Mail = mail_txt.Text,
                    A_Number = mbl_txt.Text,
                    A_Pass = pass_txt.Text,
                    A_Dob = DateTime.Parse(dob_txt.Text),
                    A_ID = ad.A_ID
                };

                if (adminController.UpdateAdmin(ad2))
                {
                    MessageBox.Show("Updated");
                }
                else {
                    MessageBox.Show("Failed");
                }
    
            }
            else if (Program.pharmLog)
            {
                IPharmacistDao pharmacistDao = new PharmacistDaoImpl();
                PharmacistController pharmacistController = new PharmacistController(pharmacistDao);

                Pharmacist ph = pharmacistController.GetPharmacistByUsername(userName_lbl.Text);

                Pharmacist ph2 = new Pharmacist
                {
                    P_UserName = ph.P_UserName,
                    P_Name = name_txtBox.Text,
                    P_Mail = mail_txt.Text,
                    P_Number = mbl_txt.Text,
                    P_Pass = pass_txt.Text,
                    P_Dob = DateTime.Parse(dob_txt.Text),
                    P_ID = ph.P_ID
                };

                
                if (pharmacistController.UpdatePharmacist(ph2))
                {
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else if (Program.custLog)
            {
                ICustomerDao customerDao = new CustomerDaoImpl();
                CustomerController customerController = new CustomerController(customerDao);

                Customer cus = customerController.GetCustomerByUsername(userName_lbl.Text);

                Customer cus2 = new Customer
                {
                    C_UserName = cus.C_UserName,
                    C_Name = name_txtBox.Text,
                    C_Mail = mail_txt.Text,
                    C_Number = mbl_txt.Text,
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
}
