using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.DataAccess;
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
using System.Diagnostics.Eventing.Reader;
using Guna.UI2.WinForms;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_SellMedicine : UserControl
    {
        public UC_P_SellMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
            list_txt.Items.Clear();
            IMedicineDao medicineDao = new MedicineDaoImpl();
            MedicineController medicineController = new MedicineController(medicineDao);

            IEnumerable<Medicine> medname = medicineController.GetAllMedicines();

            foreach (Medicine m in medname) { 
                list_txt.Items.Add(m.M_Name);

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicine_Load(this, null);
        }

        private void list_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            nou_txt.Clear();
            
            string name = list_txt.GetItemText(list_txt.SelectedItem);
            mname_txt.Text = name;

            IMedicineDao medicineDao = new MedicineDaoImpl();
            MedicineController medicineController = new MedicineController(medicineDao);

            IEnumerable<Medicine> medname  = medicineController.GetMedicineByName(name);
            // Get the first medicine from the list
            Medicine selectedMedicine = medname.FirstOrDefault();

            if (selectedMedicine != null)
            {
                // Set the medicine properties to text fields
                mId_txt.Text = selectedMedicine.M_ID.ToString();
                exp_txt.Text = selectedMedicine.Expiry_Date.ToString();
                ppu_txt.Text = selectedMedicine.M_PricePerUnit.ToString();

                // Safely parse the quantity (nou_txt.Text), defaulting to 0 if empty or invalid
                int nOU = 0;
                if (!Int32.TryParse(nou_txt.Text, out nOU))
                {
                    nOU = 0;  // If nou_txt is empty or invalid, default to 0
                }

                // Calculate the total price (PricePerUnit * Quantity) and display it
                tp_txt.Text = (selectedMedicine.M_PricePerUnit * nOU).ToString();


            }
            else
            {
                // Handle case where no medicine was found
                MessageBox.Show("No medicine found with the given name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void addToCart_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mId_txt.Text))
            {
                IMedicineDao medicineDao = new MedicineDaoImpl();
                MedicineController medicineController = new MedicineController(medicineDao);

                // Safely parse mId_txt.Text
                if (Int32.TryParse(mId_txt.Text, out int medicineId))
                {
                    Medicine m1 = medicineController.GetMedicineById(medicineId);

                    // Safely parse nou_txt.Text (Quantity), defaulting to 0 if invalid
                    if (Int32.TryParse(nou_txt.Text, out int enteredQuantity))
                    {
                        // Adjust the quantity
                        m1.M_Quantity -= enteredQuantity;

                        // Update the medicine in the database
                        medicineController.UpdateMedicine(m1);

                        // Ensure there's enough stock
                        if (m1.M_Quantity >= 0)
                        {
                            // Add row to the DataGridView
                            n = grid_txt.Rows.Add();
                            grid_txt.Rows[n].Cells[0].Value = mId_txt.Text;    // Medicine ID
                            grid_txt.Rows[n].Cells[1].Value = mname_txt.Text;  // Medicine Name
                            grid_txt.Rows[n].Cells[2].Value = exp_txt.Text;    // Expiry Date
                            grid_txt.Rows[n].Cells[3].Value = ppu_txt.Text;    // Price Per Unit
                            grid_txt.Rows[n].Cells[4].Value = nou_txt.Text;    // Quantity
                            grid_txt.Rows[n].Cells[5].Value = tp_txt.Text;     // Total Price

                            // Safely parse tp_txt.Text (Total Price), defaulting to 0 if invalid
                            if (Int32.TryParse(tp_txt.Text, out int totalPrice))
                            {
                                totalAmount += totalPrice;
                                Tk_txt.Text = "Tk " + totalAmount.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Total price is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Out Of Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid quantity entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Medicine ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void update_button_Click(object sender, EventArgs e)
        {
            string name = list_txt.GetItemText(list_txt.SelectedItem);
            mname_txt.Text = name;

            IMedicineDao medicineDao = new MedicineDaoImpl();
            MedicineController medicineController = new MedicineController(medicineDao);

            IEnumerable<Medicine> medname = medicineController.GetMedicineByName(name);
            // Get the first medicine from the list
            Medicine selectedMedicine = medname.FirstOrDefault();
            // Safely parse the quantity (nou_txt.Text), defaulting to 0 if empty or invalid
            int nOU = 0;
            if (!Int32.TryParse(nou_txt.Text, out nOU))
            {
                nOU = 0;  // If nou_txt is empty or invalid, default to 0
            }

            // Calculate the total price (PricePerUnit * Quantity) and display it
            tp_txt.Text = (selectedMedicine.M_PricePerUnit * nOU).ToString();
        }
    }
}
