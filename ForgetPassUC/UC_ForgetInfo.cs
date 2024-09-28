using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.CustomerSignInUC;
using PharmacyManagementSystem.DataAccess;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using PharmacyManagementSystem.OTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PharmacyManagementSystem.ForgetPassUC
{
    public partial class UC_ForgetInfo : UserControl
    {
        public static string email = "";
        public static string password;
        public UC_ForgetInfo()
        {
            InitializeComponent();
        }

        private void SwitchToOtp()
        {
            // Assuming that uC_F_Otp1 is an instance of the OTP control on the parent form
            ForgetPass parentForm = this.FindForm() as ForgetPass;
            if (parentForm != null)
            {
                // Hide the current control (UC_ForgetInfo)
                this.Visible = false;

                // Show the OTP user control (uC_F_Otp1)
                UC_F_Otp otpControl = new UC_F_Otp();
                otpControl.Dock = DockStyle.Fill; // Ensure it takes up the full parent form's space
                parentForm.Controls.Add(otpControl);

                otpControl.BringToFront(); // Bring the OTP control to the front for visibility
            }
            else
            {
                MessageBox.Show("Parent form not found.");
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            ICustomerDao customerDao = new CustomerDaoImpl();
            CustomerController customerController = new CustomerController(customerDao);

            int temp = UC_C_PhnNum.numberExist(phnNum_txt.Text);
            

            if (temp == 1 || temp == 2)
            {
                IEnumerable<Customer> custs = customerController.SearchCustomersByPartialPhone(phnNum_txt.Text);

                Customer customer = custs.FirstOrDefault();
                email = customer.C_Mail?.Trim(); // Trim any potential whitespaces
                Console.WriteLine("Email: '" + email + "'");

                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Invalid email address.");
                    return;
                }

                password = newPass_txt.Text;

                // Get the instance of OTPService
                OTPService otpService = OTPService.Instance;
                // Generate an OTP
                string otp = otpService.GenerateOTP();
                Console.WriteLine($"Generated OTP: {otp}");
                // Assume you have the user's email address
                string userEmail = email;
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

                // Access the parent form
                ForgetPass parentForm = this.FindForm() as ForgetPass;

                if (parentForm != null)
                {
                    // Call the method to switch user controls
                    parentForm.SwitchToInfoForgetInfoToOtp();
                }
                else
                {
                    MessageBox.Show("Parent form not found");
                }
            }
            else
            {
                MessageBox.Show("Number Not Found please check Number or sign in");
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
