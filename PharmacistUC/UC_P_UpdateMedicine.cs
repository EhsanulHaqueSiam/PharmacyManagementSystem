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
    public partial class UC_P_UpdateMedicine : UserControl
    {
        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void clearAll()
        {
            medId_txtBox.ResetText();
            addQ_txtBox.Clear();
            chemName_txtBox.Clear();
            avlQ_txtBox.Clear();
            expireDate_txt.ResetText();
            manufactDate_txtbox.ResetText();
            medName_txtBox.ResetText();
            if (ppU_txtBox.Text != "0")
            {
                ppU_txtBox.ResetText();
            }
            else
            {
                ppU_txtBox.ResetText();
            }

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(medId_txtBox.Text);

            IMedicineDao medicineDao = new MedicineDaoImpl();
            MedicineController medicineController = new MedicineController(medicineDao);

            Medicine med = medicineController.GetMedicineById(id);
            med.M_ID = id;
            med.M_ChemicalName = chemName_txtBox.Text;
            med.M_Name = medName_txtBox.Text;
            med.Expiry_Date = DateTime.Parse(expireDate_txt.Text);
            med.M_Date = DateTime.Parse(manufactDate_txtbox.Text);
            med.M_PricePerUnit = Decimal.Parse(ppU_txtBox.Text);
            if (ppU_txtBox.Text != "0")
            {
                med.M_Quantity += Int32.Parse(addQ_txtBox.Text);
            }
            else
            {
                ppU_txtBox.ResetText();
            }

            bool confirmMed = medicineController.UpdateMedicine(med);

            if (confirmMed)
            {
                MessageBox.Show("Succesfull");
            }
            else
            {
                MessageBox.Show("Faild");
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
                else
                {
                    MessageBox.Show("Mediine Not Found");
                }
            }
            else
            {
                MessageBox.Show("Please enter the medicine id!");
            }
        }

        private void UC_P_UpdateMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
