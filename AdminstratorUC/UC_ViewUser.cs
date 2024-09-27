using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.DataAccess;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdminstratorUC
{
    public partial class UC_ViewUser : UserControl
    {
        public UC_ViewUser()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            //For Admins
            IAdminDao adminDao = new AdminDaoImpl();
            AdminController adminController = new AdminController(adminDao);

            IEnumerable<Admin> allAdmins = adminController.GetAllAdmins();
            adminsGrid.AutoGenerateColumns = true;
            adminsGrid.DataSource = allAdmins.ToList();
            adminsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            //For pharmacists
            IPharmacistDao pharmacistDao = new PharmacistDaoImpl();
            PharmacistController pharmacistController = new PharmacistController(pharmacistDao);

            IEnumerable<Pharmacist> allPharmacists = pharmacistController.GetAllPharmacists();
            pharmacistsGrid.AutoGenerateColumns = true;
            pharmacistsGrid.DataSource = allPharmacists.ToList();
            pharmacistsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            //For Customers
            ICustomerDao customerDao = new CustomerDaoImpl();
            CustomerController customerController = new CustomerController(customerDao);

            IEnumerable<Customer> allCustomers = customerController.GetAllCustomers();
            customersGrid.AutoGenerateColumns = true;
            customersGrid.DataSource = allCustomers.ToList();
            customersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //For Admins
            IAdminDao adminDao = new AdminDaoImpl();
            AdminController adminController = new AdminController(adminDao);

            Admin Admin1 = adminController.GetAdminByUsername(srch_box.Text);

            adminsGrid.AutoGenerateColumns = true;

            // Check if an admin is found and wrap it in a list
            if (srch_box.Text == "")
            {
                IEnumerable<Admin> allAdmins = adminController.GetAllAdmins();
                adminsGrid.AutoGenerateColumns = true;
                adminsGrid.DataSource = allAdmins.ToList();
                adminsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            else if (Admin1 != null)
            {
                adminsGrid.DataSource = new List<Admin> { Admin1 };
            }
            else
            {
                adminsGrid.DataSource = null;
                //MessageBox.Show("No admin found with the provided username.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            adminsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminsGrid.ReadOnly = true;

            //For pharmacists
            IPharmacistDao pharmacistDao = new PharmacistDaoImpl();
            PharmacistController pharmacistController = new PharmacistController(pharmacistDao);

            Pharmacist ph1 = pharmacistController.GetPharmacistByUsername(srch_box.Text);
            pharmacistsGrid.AutoGenerateColumns = true;

            // Check if an pharmacists is found and wrap it in a list
            if (srch_box.Text == "")
            {
                IEnumerable<Pharmacist> allPharmacists = pharmacistController.GetAllPharmacists();
                pharmacistsGrid.AutoGenerateColumns = true;
                pharmacistsGrid.DataSource = allPharmacists.ToList();
                pharmacistsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            else if (ph1 != null)
            {
                pharmacistsGrid.DataSource = new List<Pharmacist> { ph1 };
            }
            else
            {
                pharmacistsGrid.DataSource = null;
                //MessageBox.Show("No Pharmacist found with the provided username.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            pharmacistsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pharmacistsGrid.ReadOnly = true;

            //For Customers
            ICustomerDao customerDao = new CustomerDaoImpl();
            CustomerController customerController = new CustomerController(customerDao);

            Customer c1 = customerController.GetCustomerByUsername(srch_box.Text);
            customersGrid.AutoGenerateColumns = true;

            // Check if an admin is found and wrap it in a list
            if (srch_box.Text == "")
            {
                IEnumerable<Customer> allCustomers = customerController.GetAllCustomers();
                customersGrid.AutoGenerateColumns = true;
                customersGrid.DataSource = allCustomers.ToList();
                customersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            else if (c1 != null)
            {
                customersGrid.DataSource = new List<Customer> { c1 };
            }
            else
            {
                //MessageBox.Show("No customer found with the provided username.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                customersGrid.DataSource = null;
            }

            customersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersGrid.ReadOnly = true;
        }

        //Delete Admin

        int adminCell;

        private void adminsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                adminCell = Int32.Parse(adminsGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void deleteAdmin_btn_Click(object sender, EventArgs e)
        {
            IAdminDao adminDao = new AdminDaoImpl();
            AdminController adminController = new AdminController(adminDao);

            bool isDeleted = adminController.DeleteAdmin(adminCell);
            if (isDeleted)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted " + adminCell);
            }



        }

        //Delete Pharmacist
        int pharmacistCell;
        private void deletePha_btn_Click(object sender, EventArgs e)
        {
            IPharmacistDao pharmacistDao = new PharmacistDaoImpl();
            PharmacistController pharmacistController = new PharmacistController(pharmacistDao);

            bool isDeleted = pharmacistController.DeletePharmacist(pharmacistCell);
            if (isDeleted)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted " + pharmacistCell);
            }
        }

        private void pharmacistsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pharmacistCell = Int32.Parse(pharmacistsGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Delete Customer
        int customerCell;

        private void customersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                customerCell = Int32.Parse(customersGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void deleteCust_btn_Click(object sender, EventArgs e)
        {
            ICustomerDao customerDao = new CustomerDaoImpl();
            CustomerController customerController = new CustomerController(customerDao);

            bool isDeleted = customerController.DeleteCustomer(customerCell);
            if (isDeleted)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted " + customerCell);
            }

        }

        private void srch_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
