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
        public UC_F_Otp()
        {
            InitializeComponent();
        }

        private void otpConfirm_btn_Click(object sender, EventArgs e)
        {
            string enteredOtp = otp_txt.Text;
            // Validate the OTP
            bool isValid = OTPService.ValidateOTP(enteredOtp);

            if (isValid)
            {
                Console.WriteLine("OTP validated successfully.");
                MessageBox.Show("PassWord changed");

                ICustomerDao customerDao = new CustomerDaoImpl();
                CustomerController customerController = new CustomerController(customerDao);
                
                Customer cust = customerController.GetCustomerByEmail(UC_ForgetInfo.email);

                cust.C_Pass = UC_ForgetInfo.password;



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
                // Hide or remove the current OTP control (UC_F_Otp)
                parentForm.Controls.Remove(this);

                // Assuming UC_ForgetInfo is already on the form, make it visible again
                UC_ForgetInfo forgetInfoControl = new UC_ForgetInfo();
                forgetInfoControl.Dock = DockStyle.Fill;
                parentForm.Controls.Add(forgetInfoControl);
                forgetInfoControl.BringToFront(); // Bring it to the front
            }
            else
            {
                MessageBox.Show("Parent form not found.");
            }
        }
    }
}
