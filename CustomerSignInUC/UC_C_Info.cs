using PharmacyManagementSystem.Model;
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
    public partial class UC_C_Info : UserControl
    {
        public static string tempOtp;
        public UC_C_Info()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CInfoBack_btn_Click(object sender, EventArgs e)
        {
            SignInGui.cust = null;
            // Access the parent form
            SignInGui parentForm = this.FindForm() as SignInGui;

            if (parentForm != null)
            {
                // Call the method to switch back to the phone number control
                parentForm.SwitchToPhoneNumber();
            }
            else
            {
                MessageBox.Show("Parent form not found");
            }

        }

        private void UC_C_Info_Load(object sender, EventArgs e)
        {

        }


        private void CinfoOTP_btn_Click_1(object sender, EventArgs e)
        {
            // Access the parent form
            SignInGui parentForm = this.FindForm() as SignInGui;

            if (parentForm != null)
            {
                // Call the method to switch to the OTP control
                parentForm.SwitchToOtpFromInfo();
            }
            else
            {
                MessageBox.Show("Parent form not found");
            }
        }

        private void otp_btn_Click(object sender, EventArgs e)
        {
            // Validate all text fields are not empty
            if (string.IsNullOrWhiteSpace(name_txt.Text) ||
                string.IsNullOrWhiteSpace(SignInGui.phoneNum) ||
                string.IsNullOrWhiteSpace(dob_txt.Text) ||
                string.IsNullOrWhiteSpace(mail_txt.Text) ||
                string.IsNullOrWhiteSpace(userName_txt.Text) ||
                string.IsNullOrWhiteSpace(pass_txt.Text))
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if any field is empty
            }

            SignInGui.cust = new Customer {
                C_Name = name_txt.Text,
                C_Number = SignInGui.phoneNum,
                C_Dob = DateTime.Parse(dob_txt.Text),
                C_Mail = mail_txt.Text,
                C_UserName = userName_txt.Text,
                C_Pass = pass_txt.Text
            };

            


            // Access the parent form
            SignInGui parentForm = this.FindForm() as SignInGui;

            OTPService otpService = OTPService.Instance;
            // Generate an OTP
            string otp = otpService.GenerateOTP();
            UC_C_Info.tempOtp = otp;
            Console.WriteLine($"Generated OTP: {otp}");
            // Assume you have the user's email address
            string userEmail = mail_txt.Text;
            // Send the OTP via email
            try
            {
                otpService.SendOTPEmail(userEmail, otp);
                Console.WriteLine("OTP email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send OTP email: {ex.Message}");
                return; // Exit if sending failed
            }
            /*
            OTPService.LoadConfiguration();

            string recipientEmail = mail_txt.Text;

            // Generate OTP
            tempOtp = OTPService.GenerateOTP();
            Console.WriteLine(tempOtp);

            // Send OTP email
            try
            {
                OTPService.SendOTPEmail(recipientEmail, tempOtp);
                Console.WriteLine("OTP sent successfully to your email.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send OTP: {ex.Message}");
            }
            */

            if (parentForm != null)
            {
                // Call the method to switch to the OTP control
                parentForm.SwitchToOtpFromInfo();
            }
            else
            {
                MessageBox.Show("Parent form not found");
            }
        }
    }
}
