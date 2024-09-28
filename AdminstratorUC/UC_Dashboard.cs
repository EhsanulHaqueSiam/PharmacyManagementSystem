using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdminstratorUC
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            IAdminDao adminDao = new AdminDaoImpl();
            AdminController adminController = new AdminController(adminDao);

            admin_lbl.Text = adminController.CountAdmins().ToString();

            IPharmacistDao pharmacistDao = new PharmacistDaoImpl();
            PharmacistController pharmacistController = new PharmacistController(pharmacistDao);

            pham_lbl.Text = pharmacistController.CountPharmacists().ToString();

            ICustomerDao customerDao = new CustomerDaoImpl();
            CustomerController customerController = new CustomerController(customerDao);

            cust_lbl.Text = customerController.CountCustomers().ToString();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            guna2Button1.PerformClick();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
