using PharmacyManagementSystem.OTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.CustomerSignInUC
{
    public partial class UC_C_Otp : UserControl
    {
        public UC_C_Otp()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void otpConfirm_btn_Click(object sender, EventArgs e)
        {
            string enteredOtp = otp_txt.Text;
            // Validate the OTP
            bool isValid = OTPService.ValidateOTP(enteredOtp);

            if (isValid)
            {
                Console.WriteLine("OTP validated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid or expired OTP.");
            }
        }

        private void otpBack_btn_Click(object sender, EventArgs e)
        {
            // Access the parent form
            SignInGui parentForm = this.FindForm() as SignInGui;

            if (parentForm != null)
            {
                // Call the method to switch to the OTP control
                parentForm.SwitchToInfoFromOtp();
            }
            else
            {
                MessageBox.Show("Parent form not found");
            }
        }
    }
}
