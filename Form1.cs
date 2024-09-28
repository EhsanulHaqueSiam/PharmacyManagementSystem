using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.CustomerSignInUC;
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

namespace PharmacyManagementSystem
{


    public partial class Form1 : Form
    {
        private readonly IAdminDao _adminDao;
        private readonly IPharmacistDao _pharmacistDao;
        private readonly ICustomerDao _customerDao;

        public Form1()
        {
            InitializeComponent();
            _adminDao = new AdminDaoImpl();
            _pharmacistDao = new PharmacistDaoImpl();
            _customerDao = new CustomerDaoImpl();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                LogError("Error during application exit", ex);
                MessageBox.Show("An error occurred while closing the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var signInForm = new SignInGui();
                signInForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                LogError("Error during form reset", ex);
                MessageBox.Show("An error occurred while resetting the form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = userNameTxtField.Text;
            string password = passTextField.Text;
            Program.userName = username;

            try
            {
                if (TryLoginAsAdmin(username, password) ||
                    TryLoginAsPharmacist(username, password) ||
                    TryLoginAsCustomer(username, password))
                {
                    // Login successful
                    return;
                }

                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                LogError("Error during login", ex);
                MessageBox.Show("An error occurred while processing your login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryLoginAsAdmin(string username, string password)
        {
            var adminController = new AdminController(_adminDao);
            if (adminController.Login(username, password))
            {
                Program.adminLog = true;
                var adminForm = new Adminstrator();
                adminForm.Show();
                this.Hide();
                return true;
            }
            return false;
        }

        private bool TryLoginAsPharmacist(string username, string password)
        {
            var pharmacistController = new PharmacistController(_pharmacistDao);
            if (pharmacistController.Login(username, password))
            {
                Program.pharmLog = true;
                var pharmacistForm = new PharmacistGUI();
                pharmacistForm.Show();
                this.Hide();
                return true;
            }
            return false;
        }

        private bool TryLoginAsCustomer(string username, string password)
        {
            var customerController = new CustomerController(_customerDao);
            try
            {
                if (customerController.Login(username, password))
                {
                    Program.custLog = true;
                    var customerForm = new CustomerGUI();
                    customerForm.Show();
                    this.Hide();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Customer login failed: {ex.Message}");
                throw;  // Rethrow the exception for global error handling
            }
        }

        private void passTextField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void forgetPass_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                var fr1 = new ForgetPass();
                fr1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                LogError("Error during forget password", ex);
                MessageBox.Show("An error occurred while opening the forget password form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var signUpForm = new SignInGui();
                signUpForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                LogError("Error during sign-up", ex);
                MessageBox.Show("An error occurred while opening the sign-up form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void medicinePicture_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogError(string message, Exception ex)
        {
            // Logging the error for further debugging purposes
            Console.WriteLine($"{message}: {ex.Message}");
            // Additional logging mechanism like logging to a file or database can be added here
        }
    }
}
