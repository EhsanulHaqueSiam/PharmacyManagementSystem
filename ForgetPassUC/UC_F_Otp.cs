using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.DataAccess;
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
using PharmacyManagementSystem.Model;

namespace PharmacyManagementSystem.ForgetPassUC
{
    public partial class UC_F_Otp : UserControl
    {
        // Get the instance of OTPService
        OTPService otpService = OTPService.Instance;
        public UC_F_Otp()
        {
            InitializeComponent();
        }

        private void otpConfirm_btn_Click(object sender, EventArgs e)
        {
            string enteredOtp = otp_txt.Text;
                // Validate the OTP
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
                MessageBox.Show("PassWord changed");

                ICustomerDao customerDao = new CustomerDaoImpl();
                CustomerController customerController = new CustomerController(customerDao);
                
                Customer cust = customerController.GetCustomerByEmail(UC_ForgetInfo.email);

                cust.C_Pass = UC_ForgetInfo.password;
                if (string.IsNullOrEmpty(cust.C_Pass))
                {
                    MessageBox.Show("Password cannot be empty." + cust.C_Pass);
                    return;
                }


                bool confirmation = customerController.UpdateCustomer(cust);

                SignInGui.cust = null;
                if (confirmation)
                {
                    MessageBox.Show("Succesfully updated");
                }
                else
                {
                    MessageBox.Show("update failed");
                }

                // Access the parent form
                ForgetPass parentForm = this.FindForm() as ForgetPass;
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
            ForgetPass parentForm = this.FindForm() as ForgetPass;

            if (parentForm != null)
            {
                // Call the method to switch user controls
                parentForm.SwitchToInfoOtpInfoToForget();
            }
            else
            {
                MessageBox.Show("Parent form not found");
            }
        }
    }
}
