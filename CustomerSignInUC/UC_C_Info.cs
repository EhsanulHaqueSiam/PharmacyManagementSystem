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
        public UC_C_Info()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CInfoBack_btn_Click(object sender, EventArgs e)
        {
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
            // Access the parent form
            SignInGui parentForm = this.FindForm() as SignInGui;
            OTPService.LoadConfiguration();

            string recipientEmail = ;

            // Generate OTP
            string otp = OTPService.GenerateOTP();
            Console.WriteLine(otp);

            // Send OTP email
            try
            {
                OTPService.SendOTPEmail(recipientEmail, otp);
                Console.WriteLine("OTP sent successfully to your email.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send OTP: {ex.Message}");
            }

            // Ask user to input OTP to verify
            Console.WriteLine("Enter the OTP you received:");
            string enteredOtp = Console.ReadLine();

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
