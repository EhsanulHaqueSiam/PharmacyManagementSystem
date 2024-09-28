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
    public partial class UC_P_Dashboard : UserControl
    {
        public UC_P_Dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_P_Dashboard_Load(object sender, EventArgs e)
        {
            loadChart();
        }

        public void loadChart() {
            IMedicineDao medicineDao = new MedicineDaoImpl();
            MedicineController medicineController = new MedicineController(medicineDao);

            this.chart1.Series["Valid Medicines"].Points.AddXY("Medicine Validity Chart", medicineController.CountValidMedicine());
            this.chart1.Series["Expired Medicines"].Points.AddXY("Medicine Validity Chart", medicineController.CountExpiredMedicine());
        }
    }
}
