using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.DataAccess;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdminstratorUC
{
    public partial class UC_AddUser : UserControl
    {
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            string role = userRole_Combobox.Text;

            if (role == "Administrator")
            {

                IAdminDao adminDao = new AdminDaoImpl();
                AdminController adminController = new AdminController(adminDao);
                Admin ad = new Admin
                {

                    A_Name = name_Textfield.Text,
                    A_Mail = mail_txtBox.Text,
                    A_Number = mblNo_txtBox.Text,
                    A_Pass = pass_txtBox.Text,
                    A_UserName = userName_txtBox.Text,
                    A_Dob = DateTime.Parse(dob_Datebox.Text),

                };


                bool confirmation = adminController.InsertAdmin(ad);

                if (confirmation)
                {
                    MessageBox.Show("Succesfull");
                }
                else
                {
                    MessageBox.Show("Faild");
                }

            }
            else if (role == "Pharmacist")
            {
                IPharmacistDao pharmacistDao = new PharmacistDaoImpl();
                PharmacistController pharmacistController = new PharmacistController(pharmacistDao);
                Pharmacist ph = new Pharmacist
                {

                    P_Name = name_Textfield.Text,
                    P_Mail = mail_txtBox.Text,
                    P_Number = mblNo_txtBox.Text,
                    P_Pass = pass_txtBox.Text,
                    P_UserName = userName_txtBox.Text,
                    P_Dob = DateTime.Parse(dob_Datebox.Text),

                };


                bool confirmation = pharmacistController.InsertPharmacist(ph);

                if (confirmation)
                {
                    MessageBox.Show("Succesfull");
                }
                else
                {
                    MessageBox.Show("Faild");
                }



            }
            else if (role == "Customer")
            {
                ICustomerDao customerDao = new CustomerDaoImpl();
                CustomerController customerController = new CustomerController(customerDao);
                Customer cust = new Customer
                {

                    C_Name = name_Textfield.Text,
                    C_Mail = mail_txtBox.Text,
                    C_Number = mblNo_txtBox.Text,
                    C_Pass = pass_txtBox.Text,
                    C_UserName = userName_txtBox.Text,
                    C_Dob = DateTime.Parse(dob_Datebox.Text),

                };


                bool confirmation = customerController.InsertCustomer(cust);

                if (confirmation)
                {
                    MessageBox.Show("Succesfull");
                }
                else
                {
                    MessageBox.Show("Faild");
                }

            }
            else
            {
                MessageBox.Show("Wrong User");
            }


        }
    }
}
