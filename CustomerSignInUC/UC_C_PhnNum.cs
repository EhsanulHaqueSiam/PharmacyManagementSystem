using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManagementSystem.Model;

namespace PharmacyManagementSystem.CustomerSignInUC
{
    public partial class UC_C_PhnNum : UserControl
    {
        public UC_C_PhnNum()
        {
            InitializeComponent();
        }

        private void phnBack_btn_Click(object sender, EventArgs e)
        {            
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void phnNumNext_btn_Click(object sender, EventArgs e)
        {
            if (IsValidPhoneNumber(phnNumSearch_txtBox.Text))
            {
                if (numberExist(phnNumSearch_txtBox.Text) == 1)
                {
                    MessageBox.Show("You already Purchase from Offline store \nplease Complete the registration process");

                    SignInGui.phoneNum = phnNumSearch_txtBox.Text;
                    // Access the parent form
                    SignInGui parentForm = this.FindForm() as SignInGui;

                    if (parentForm != null)
                    {
                        // Call the method to switch user controls
                        parentForm.SwitchToInfo();
                    }
                    else
                    {
                        MessageBox.Show("Parent form not found");
                    }
                }
                else if (numberExist(phnNumSearch_txtBox.Text) == 2)
                {
                    MessageBox.Show("The number already have A Account please Sign in Or use Forget password");

                    SignInGui.phoneNum = phnNumSearch_txtBox.Text;
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
                else if (numberExist(phnNumSearch_txtBox.Text) == 0)
                {
                    MessageBox.Show("Phone Number Valid Please Complete your registration");

                    SignInGui.phoneNum = phnNumSearch_txtBox.Text;
                    // Access the parent form
                    SignInGui parentForm = this.FindForm() as SignInGui;

                    if (parentForm != null)
                    {
                        // Call the method to switch user controls
                        parentForm.SwitchToInfo();
                    }
                    else
                    {
                        MessageBox.Show("Parent form not found");
                    }
                }
                else {
                    MessageBox.Show("Something went wrong please try again");
                }
                /*
                SignInGui.phoneNum = phnNumSearch_txtBox.Text;
                // Access the parent form
                SignInGui parentForm = this.FindForm() as SignInGui;

                if (parentForm != null)
                {
                    // Call the method to switch user controls
                    parentForm.SwitchToInfo();
                }
                else
                {
                    MessageBox.Show("Parent form not found");
                }
                */
            }
            else {
                MessageBox.Show("Please put 11 numbers");
            }

        }
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression for validating the phone number
            // This pattern checks for numbers starting with '01' followed by 9 digits
            string pattern = @"^01[3-9]\d{8}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        public static int numberExist(string phoneNumber) {

            ICustomerDao customerDao = new CustomerDaoImpl();
            CustomerController customerController = new CustomerController(customerDao);

            
            IEnumerable<Customer> custs = customerController.SearchCustomersByPartialPhone(phoneNumber);

            if (custs.Count() == 1)
            {
                Customer customer = custs.FirstOrDefault();

                if (customer.C_Mail == null)
                {
                    //MessageBox.Show("You already Purchase from Offline store \nplease Complete the registration process");
                    return 1;
                }
                else {
                    //MessageBox.Show("The number already have A Account please Sign in Or use Forget password");
                    return 2;
                }
            }
            else {
                return 0;
            }

        }
    }
}
