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

        public Form1()
        {
            InitializeComponent();
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
            Application.Exit();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            SignInGui s1 = new SignInGui();
            s1.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Program.userName = userNameTxtField.Text;

            IAdminDao adminDao = new AdminDaoImpl();
            AdminController adminController = new AdminController(adminDao);

            IPharmacistDao pharmacistDao = new PharmacistDaoImpl();
            PharmacistController pharmacistController = new PharmacistController(pharmacistDao);

            ICustomerDao customerDao = new CustomerDaoImpl();
            CustomerController customerController = new CustomerController(customerDao);

            

            if (adminController.Login(userNameTxtField.Text, passTextField.Text))
            {
                Adminstrator am = new Adminstrator();
                am.Show();
                Program.adminLog = true;
                this.Hide();
            } else if (pharmacistController.Login(userNameTxtField.Text, passTextField.Text))
            { 
                PharmacistGUI ph = new PharmacistGUI();
                ph.Show();
                Program.pharmLog = true;
                this.Hide();

            }
            else if (customerController.Login(userNameTxtField.Text, passTextField.Text))
            {
                CustomerGUI c1 = new CustomerGUI();
                c1.Show();
                Program.custLog = true;
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong user Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            SignInGui s1 = new SignInGui();
            s1.Show();
            this.Hide();
        }
    }
}
