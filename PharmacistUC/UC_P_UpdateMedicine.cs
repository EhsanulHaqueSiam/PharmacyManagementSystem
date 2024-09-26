using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.DataAccess;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.Model;
using System;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUC {
    public partial class UC_P_UpdateMedicine : UserControl {
        private readonly IMedicineDao _medicineDao;
        private readonly MedicineController _medicineController;

        public UC_P_UpdateMedicine() {
            InitializeComponent();
            _medicineDao = new MedicineDaoImpl();
            _medicineController = new MedicineController(_medicineDao);
        }

        private void clearAll() {
            medId_txtBox.ResetText();
            addQ_txtBox.Clear();
            chemName_txtBox.Clear();
            avlQ_txtBox.Clear();
            expireDate_txt.ResetText();
            manufactDate_txtbox.ResetText();
            medName_txtBox.ResetText();
            ppU_txtBox.ResetText();
        }

        private void reset_btn_Click(object sender, EventArgs e) {
            clearAll();
        }

        private void update_btn_Click(object sender, EventArgs e) {
            try {
                // Validate inputs
                if (string.IsNullOrEmpty(medId_txtBox.Text) || !int.TryParse(medId_txtBox.Text, out int id)) {
                    MessageBox.Show("Please enter a valid Medicine ID.");
                    return;
                }

                if (string.IsNullOrEmpty(chemName_txtBox.Text) || string.IsNullOrEmpty(medName_txtBox.Text)) {
                    MessageBox.Show("Please provide valid chemical and medicine names.");
                    return;
                }

                if (string.IsNullOrEmpty(expireDate_txt.Text) || !DateTime.TryParse(expireDate_txt.Text, out DateTime expiryDate)) {
                    MessageBox.Show("Please enter a valid expiry date.");
                    return;
                }

                if (string.IsNullOrEmpty(manufactDate_txtbox.Text) || !DateTime.TryParse(manufactDate_txtbox.Text, out DateTime manufactureDate)) {
                    MessageBox.Show("Please enter a valid manufacturing date.");
                    return;
                }

                if (string.IsNullOrEmpty(ppU_txtBox.Text) || !decimal.TryParse(ppU_txtBox.Text, out decimal pricePerUnit)) {
                    MessageBox.Show("Please enter a valid price per unit.");
                    return;
                }

                if (string.IsNullOrEmpty(addQ_txtBox.Text) || !int.TryParse(addQ_txtBox.Text, out int addedQuantity)) {
                    MessageBox.Show("Please enter a valid quantity to add.");
                    return;
                }

                // Get the medicine by ID
                Medicine medicine = _medicineController.GetMedicineById(id);
                if (medicine == null) {
                    MessageBox.Show("Medicine not found.");
                    return;
                }

                // Update medicine details
                medicine.M_ID = id;
                medicine.M_ChemicalName = chemName_txtBox.Text;
                medicine.M_Name = medName_txtBox.Text;
                medicine.Expiry_Date = expiryDate;
                medicine.M_Date = manufactureDate;
                medicine.M_PricePerUnit = pricePerUnit;

                // Update quantity if provided
                if (addedQuantity > 0) {
                    medicine.M_Quantity += addedQuantity;
                }

                // Update the medicine in the database
                bool updateSuccess = _medicineController.UpdateMedicine(medicine);

                if (updateSuccess) {
                    MessageBox.Show("Medicine updated successfully.");
                    clearAll();
                } else {
                    MessageBox.Show("Failed to update the medicine.");
                }
            } catch (FormatException ex) {
                MessageBox.Show($"Input format error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            search_btn.PerformClick();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (medId_txtBox.Text != "")
            {
                int id = Int32.Parse(medId_txtBox.Text);

                IMedicineDao medicineDao = new MedicineDaoImpl();
                MedicineController medicineController = new MedicineController(medicineDao);

                Medicine med = medicineController.GetMedicineById(id);

                if (med != null)
                {

                    chemName_txtBox.Text = med.M_ChemicalName;
                    medName_txtBox.Text = med.M_Name;
                    expireDate_txt.Text = med.Expiry_Date.ToString();
                    manufactDate_txtbox.Text = med.M_Date.ToString();
                    ppU_txtBox.Text = med.M_PricePerUnit.ToString();
                    avlQ_txtBox.Text = med.M_Quantity.ToString();
                    ppU_txtBox.Text = med.M_PricePerUnit.ToString();
                    addQ_txtBox.Text = "0";

                }
                else {
                    MessageBox.Show("Mediine Not Found");
                }
            }
            else {
                MessageBox.Show("Please enter the medicine id!");
            }
        }

        private void UC_P_UpdateMedicine_Load(object sender, EventArgs e)
        {

        }

        private void UC_P_UpdateMedicine_Load(object sender, EventArgs e) {
        }
    }
}
