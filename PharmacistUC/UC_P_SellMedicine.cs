using DGVPrinterHelper;
using Guna.UI2.WinForms;
using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.DataAccess;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUC {

    public partial class UC_P_SellMedicine : UserControl {

        double valueAmount;
        int valueId;
        int noOfUnit;
        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        public UC_P_SellMedicine() {
            InitializeComponent();
        }

        private void UC_P_SellMedicine_Load(object sender, EventArgs e) {
            grid_txt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoadMedicineNames();
        }

        // Load all medicine names into the dropdown (list_txt)
        private void LoadMedicineNames() {
            try {
                list_txt.Items.Clear();
                IMedicineDao medicineDao = new MedicineDaoImpl();
                MedicineController medicineController = new MedicineController(medicineDao);

                var medicines = medicineController.GetAllMedicines();
                foreach (Medicine m in medicines) {
                    list_txt.Items.Add(m.M_Name);
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error loading medicine names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Refresh the medicine list on button click
        private void guna2Button2_Click(object sender, EventArgs e) {
            LoadMedicineNames();
        }

        // Load selected medicine details when a medicine is selected from the list
        private void list_txt_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                nou_txt.Clear();
                string name = list_txt.GetItemText(list_txt.SelectedItem);
                mname_txt.Text = name;

                IMedicineDao medicineDao = new MedicineDaoImpl();
                MedicineController medicineController = new MedicineController(medicineDao);

                var selectedMedicine = medicineController.GetMedicineByName(name).FirstOrDefault();
                if (selectedMedicine != null) {
                    mId_txt.Text = selectedMedicine.M_ID.ToString();
                    exp_txt.Text = selectedMedicine.Expiry_Date.ToString("yyyy-MM-dd");
                    ppu_txt.Text = selectedMedicine.M_PricePerUnit.ToString();

                    CalculateTotalPrice();
                } else {
                    MessageBox.Show("No medicine found with the given name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error loading selected medicine details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Calculate total price based on the quantity entered
        private void CalculateTotalPrice() {
            try {
                if (decimal.TryParse(ppu_txt.Text, out decimal pricePerUnit) && int.TryParse(nou_txt.Text, out int quantity)) {
                    tp_txt.Text = (pricePerUnit * quantity).ToString();
                } else {
                    tp_txt.Text = "0";
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error calculating total price: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void rmv_btn_Click(object sender, EventArgs e)
        {
            if (valueId != 0)
            {
                try
                {
                    grid_txt.Rows.RemoveAt(this.grid_txt.SelectedRows[0].Index);
                }
                catch (Exception)
                {
                }
                finally {
                    IMedicineDao medicineDao = new MedicineDaoImpl();
                    MedicineController medicineController = new MedicineController(medicineDao);
                    Medicine selectedMedicine = medicineController.GetMedicineById(valueId);

                    selectedMedicine.M_Quantity += noOfUnit;
                    medicineController.UpdateMedicine(selectedMedicine);
                    Tk_txt.Text = "Tk " + (double.Parse(Tk_txt.Text.Replace("Tk ", "")) - valueAmount).ToString();


                }
            }
            else {
                MessageBox.Show("Row not selected!");
            }
        }

        private void grid_txt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // Handle adding medicine to the cart
        private void addToCart_btn_Click(object sender, EventArgs e) {
            try {
                if (string.IsNullOrEmpty(mId_txt.Text) || !int.TryParse(mId_txt.Text, out int medicineId)) {
                    MessageBox.Show("Invalid Medicine ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(nou_txt.Text, out int enteredQuantity) || enteredQuantity <= 0) {
                    MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                IMedicineDao medicineDao = new MedicineDaoImpl();
                MedicineController medicineController = new MedicineController(medicineDao);
                Medicine selectedMedicine = medicineController.GetMedicineById(medicineId);

                if (selectedMedicine == null) {
                    MessageBox.Show("Medicine not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedMedicine.M_Quantity < enteredQuantity) {
                    MessageBox.Show("Not enough stock available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update stock and add to the grid
                selectedMedicine.M_Quantity -= enteredQuantity;
                medicineController.UpdateMedicine(selectedMedicine);

                n = grid_txt.Rows.Add();
                grid_txt.Rows[n].Cells[0].Value = selectedMedicine.M_ID;
                grid_txt.Rows[n].Cells[1].Value = selectedMedicine.M_Name;
                grid_txt.Rows[n].Cells[2].Value = selectedMedicine.Expiry_Date.ToString("yyyy-MM-dd");
                grid_txt.Rows[n].Cells[3].Value = selectedMedicine.M_PricePerUnit;
                grid_txt.Rows[n].Cells[4].Value = enteredQuantity;
                grid_txt.Rows[n].Cells[5].Value = (selectedMedicine.M_PricePerUnit * enteredQuantity).ToString();

                // Update total amount
                totalAmount += (int)(selectedMedicine.M_PricePerUnit * enteredQuantity);
                Tk_txt.Text = $"Tk {totalAmount}";
            } catch (Exception ex) {
                MessageBox.Show($"Error adding to cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cleartxt();
        }

        private void purchase_btn_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date: {0:yyyy-MM-dd} Time: {1:hh\\:mm\\:ss}", DateTime.Now, DateTime.Now.TimeOfDay + "\nTotal Payable Amount : " + Tk_txt.Text);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Software created by Siam and Aonyendo";
            print.FooterSpacing = 15;
            print.PrintDataGridView(grid_txt);

            totalAmount = 0;
            Tk_txt.Text = "Tk 0";
            grid_txt.Rows.Clear();
        }

        private void nou_txt_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            list_txt.Items.Clear();
        }

        private void grid_txt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                valueAmount = double.Parse(grid_txt.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = int.Parse(grid_txt.Rows[e.RowIndex].Cells[0].Value.ToString());
                noOfUnit = int.Parse(grid_txt.Rows[e.RowIndex].Cells[4].Value.ToString());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }


        private void grid_txt_Click(object sender, EventArgs e)
        {

        }

        private void Cleartxt() {
            mname_txt.ResetText();
            exp_txt.ResetText();
            mId_txt.ResetText();
            nou_txt.ResetText();
            ppu_txt.ResetText();
            tp_txt.ResetText();
        }

        // Recalculate the total price on quantity change
        private void update_button_Click(object sender, EventArgs e) {
            CalculateTotalPrice();  
        }
    }
}
