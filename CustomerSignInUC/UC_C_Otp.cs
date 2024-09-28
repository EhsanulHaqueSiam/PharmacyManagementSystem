using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.DataAccess;
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
            //bool isValid = OTPService.ValidateOTP(enteredOtp);
            // Validate the OTP
            // Get the instance of OTPService
            OTPService otpService = OTPService.Instance;
            bool isValid = otpService.ValidateOTP(enteredOtp);

            if (isValid)
            {
                Console.WriteLine("OTP validation successful.");
            }
            else
            {
                Console.WriteLine("OTP validation failed. Please try again.");
            }
            // Dispose of the OTP service
            otpService.Dispose();

            if (isValid)
            {
                Console.WriteLine("OTP validated successfully.");
                MessageBox.Show("Congratulation OTP validated successfully Please Sign In");

                ICustomerDao customerDao = new CustomerDaoImpl();
                CustomerController customerController = new CustomerController(customerDao);


                bool confirmation = customerController.InsertCustomer(SignInGui.cust);

                SignInGui.cust = null;
                if (confirmation)
                {
                    MessageBox.Show("Account Succesfully created");
                }
                else
                {
                    MessageBox.Show("Account faild to create");
                }

                // Access the parent form
                SignInGui parentForm = this.FindForm() as SignInGui;
                if (parentForm != null)
                {
                    // Remove or hide the current user control
                    parentForm.Controls.Remove(this); // Removes this user control from the parent form

                    // Call the method to switch user controls or open the next form
                    Form1 newForm = new Form1();
                    newForm.Show(); // Opens the new form

                    // Optionally close or hide the parent form
                    parentForm.Hide();
                }
                else
                {
                    MessageBox.Show("Parent form not found");
                }
            }
            else
            {
                Console.WriteLine("Invalid or expired OTP.");
                MessageBox.Show("OTP Invalid try resent button after 10 minute or check email");
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

        private void resendCode_btn_Click(object sender, EventArgs e)
        {
            // Get the instance of OTPService
            OTPService otpService = OTPService.Instance;
            // Assume you have the user's email address
            string userEmail = SignInGui.cust.C_Mail;
            // Send the OTP via email
            try
            {
                otpService.SendOTPEmail(userEmail, UC_C_Info.tempOtp);
                Console.WriteLine("OTP email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send OTP email: {ex.Message}");
                return ; // Exit if sending failed
            }
        }
    }
}
