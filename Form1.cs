using PharmacyManagementSystem.CustomerSignInUC;
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
            if (userNameTxtField.Text == "Siam" && passTextField.Text == "siam")
            {
                Adminstrator am = new Adminstrator();
                am.Show();
                this.Hide();
            } else if (userNameTxtField.Text == "nit" && passTextField.Text == "nit")
            { 
                PharmacistGUI ph = new PharmacistGUI();
                ph.Show();
                this.Hide();

            }
            else if (userNameTxtField.Text == "kit" && passTextField.Text == "kit")
            {
                CustomerGUI c1 = new CustomerGUI();
                c1.Show();
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
    }
}
