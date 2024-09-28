using MimeKit.Tnef;
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

namespace PharmacyManagementSystem
{
    public partial class SignInGui : Form
    {
        public static Customer cust;
        public static String phoneNum;
        public SignInGui()
        {
            InitializeComponent();
        }

        private void uC_C_PhnNum1_Load(object sender, EventArgs e)
        {
        }

        private void SignInGui_Load(object sender, EventArgs e)
        {
            uC_C_PhnNum1.Visible = true;
            uC_C_Info1.Visible = false;
            uC_C_Otp1.Visible = false;
        }

        // Method to switch user controls visibility
        public void SwitchToInfo()
        {
            uC_C_PhnNum1.Visible = false;  // Hide the phone number control
            uC_C_Info1.Visible = true;     // Show the information control
            uC_C_Info1.BringToFront();     // Make sure it's brought to the front
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        public void SwitchToPhoneNumber()
        {
            uC_C_Info1.Visible = false;  // Hide the info control
            uC_C_PhnNum1.Visible = true; // Show the phone number control
            uC_C_PhnNum1.BringToFront(); // Bring it to the front
        }

        // Method to switch from UC_C_Otp to UC_C_Info
        public void SwitchToInfoFromOtp()
        {
            uC_C_Otp1.Visible = false;     // Hide the OTP control
            uC_C_Info1.Visible = true;     // Show the info control
            uC_C_Info1.BringToFront();     // Bring it to the front
        }

        public void SwitchToOtpFromInfo()
        {
        uC_C_Info1.Visible = false;    // Hide the info control
        uC_C_Otp1.Visible = true;      // Show the OTP control
        uC_C_Otp1.BringToFront();      // Bring it to the front
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_C_Info1_Load(object sender, EventArgs e)
        {

        }
    }
}
