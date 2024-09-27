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
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManagementSystem.Model;
using System.Collections;
using Guna.UI2.WinForms;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_ViewMedicines : UserControl
    {
        public UC_P_ViewMedicines()
        {
            InitializeComponent();
        }

        private void UC_P_ViewMedicines_Load(object sender, EventArgs e)
        {
            /*

            IMedicineDao medicineDao = new MedicineDaoImpl();
            MedicineController medicineController = new MedicineController(medicineDao);

            IEnumerable<Medicine> allMedicines = medicineController.GetAllMedicines();
            viewMedicine_gunaGrid.AutoGenerateColumns = true;
            viewMedicine_gunaGrid.DataSource = allMedicines.ToList();
            */
            guna2Button2.PerformClick();

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            IMedicineDao medicineDao = new MedicineDaoImpl();
            MedicineController medicineController = new MedicineController(medicineDao);

            IEnumerable<Medicine> medname = medicineController.GetMedicineByName(medSearch_txtBox.Text);
            viewMedicine_gunaGrid.AutoGenerateColumns = true;
            viewMedicine_gunaGrid.DataSource = medname.ToList();
            viewMedicine_gunaGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        }

        int medicineId;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            IMedicineDao medicineDao = new MedicineDaoImpl();
            MedicineController medicineController = new MedicineController(medicineDao);

            bool isDeleted = medicineController.DeleteMedicine(medicineId);

            if (isDeleted)
            {
                MessageBox.Show("Deleted");
            }
            else {
                MessageBox.Show("Not Deleted " + medicineId);
            }


        }

        private void viewMedicine_gunaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineId = Int32.Parse(viewMedicine_gunaGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            }catch(Exception ex){ 
                Console.WriteLine(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewMedicine_gunaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
