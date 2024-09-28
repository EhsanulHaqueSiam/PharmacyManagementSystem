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

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_MedicineValidityCheck : UserControl
    {
        public UC_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void UC_P_MedicineValidityCheck_Load(object sender, EventArgs e) {
            
            valid_comboBox.SelectedIndex = 2;
        }

        private void valid_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valid_comboBox.SelectedIndex == 0)
            {
                // View all valid medicine
                IMedicineDao medicineDao = new MedicineDaoImpl();
                MedicineController medicineController = new MedicineController(medicineDao);

                IEnumerable<Medicine> medname = medicineController.GetValidMedicines();
                valid_grid.AutoGenerateColumns = true;
                valid_grid.DataSource = medname.ToList();
                valid_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            }
            else if (valid_comboBox.SelectedIndex == 1)
            {
                // View all expired medicine
                IMedicineDao medicineDao = new MedicineDaoImpl();
                MedicineController medicineController = new MedicineController(medicineDao);

                IEnumerable<Medicine> medname = medicineController.GetExpiredMedicines();
                valid_grid.AutoGenerateColumns = true;
                valid_grid.DataSource = medname.ToList();
                valid_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            }
            else if (valid_comboBox.SelectedIndex == 2)
            {
                //view all medicine
                IMedicineDao medicineDao = new MedicineDaoImpl();
                MedicineController medicineController = new MedicineController(medicineDao);

                IEnumerable<Medicine> medname = medicineController.GetAllMedicines();
                valid_grid.AutoGenerateColumns = true;
                valid_grid.DataSource = medname.ToList();
                valid_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            else {
                MessageBox.Show("Select item to show");
            }
        }
    }
}
