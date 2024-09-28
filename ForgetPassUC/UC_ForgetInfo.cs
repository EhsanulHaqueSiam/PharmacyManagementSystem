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
        public static string email;
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
                email = customer.C_Mail;
                Console.WriteLine("Email: " + customer.C_Mail);
                // Generate OTP

                UC_C_Info.tempOtp = OTPService.GenerateOTP();
                Console.WriteLine(UC_C_Info.tempOtp);

                // Send OTP email
                try
                {
                    OTPService.SendOTPEmail(email, UC_C_Info.tempOtp);
                    Console.WriteLine("OTP sent successfully to your email.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to send OTP: {ex.Message}");
                }
                SwitchToOtp();

            }
            else
            {
                MessageBox.Show("Number Not Found please check Number or sign in");
            }



        }
    }
}
