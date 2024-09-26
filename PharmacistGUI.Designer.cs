namespace PharmacyManagementSystem
{
    partial class PharmacistGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacistGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sellMedicine_btn = new Guna.UI2.WinForms.Guna2Button();
            this.mValidityChk_btn = new Guna.UI2.WinForms.Guna2Button();
            this.plogout_Button = new Guna.UI2.WinForms.Guna2Button();
            this.pModifyMedicine_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pViewMedicine_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pAddMedicine_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pDashboard_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_P_ViewMedicines1 = new PharmacyManagementSystem.PharmacistUC.UC_P_ViewMedicines();
            this.uC_P_SellMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_SellMedicine();
            this.uC_P_MedicineValidityCheck1 = new PharmacyManagementSystem.PharmacistUC.UC_P_MedicineValidityCheck();
            this.uC_P_UpdateMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_UpdateMedicine();
            this.uC_P_AddMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_AddMedicine();
            this.uC_P_Dashboard1 = new PharmacyManagementSystem.PharmacistUC.UC_P_Dashboard();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.sellMedicine_btn);
            this.panel1.Controls.Add(this.mValidityChk_btn);
            this.panel1.Controls.Add(this.plogout_Button);
            this.panel1.Controls.Add(this.pModifyMedicine_btn);
            this.panel1.Controls.Add(this.pViewMedicine_btn);
            this.panel1.Controls.Add(this.pAddMedicine_btn);
            this.panel1.Controls.Add(this.pDashboard_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 762);
            this.panel1.TabIndex = 0;
            // 
            // sellMedicine_btn
            // 
            this.sellMedicine_btn.BackColor = System.Drawing.Color.Transparent;
            this.sellMedicine_btn.BorderColor = System.Drawing.Color.Transparent;
            this.sellMedicine_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.sellMedicine_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.sellMedicine_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.sellMedicine_btn.FillColor = System.Drawing.Color.Transparent;
            this.sellMedicine_btn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellMedicine_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.sellMedicine_btn.Image = ((System.Drawing.Image)(resources.GetObject("sellMedicine_btn.Image")));
            this.sellMedicine_btn.ImageSize = new System.Drawing.Size(50, 50);
            this.sellMedicine_btn.Location = new System.Drawing.Point(77, 596);
            this.sellMedicine_btn.Name = "sellMedicine_btn";
            this.sellMedicine_btn.Size = new System.Drawing.Size(257, 45);
            this.sellMedicine_btn.TabIndex = 18;
            this.sellMedicine_btn.Text = "Sell Medicine";
            this.sellMedicine_btn.Click += new System.EventHandler(this.sellMedicine_btn_Click);
            // 
            // mValidityChk_btn
            // 
            this.mValidityChk_btn.BackColor = System.Drawing.Color.Transparent;
            this.mValidityChk_btn.BorderColor = System.Drawing.Color.Transparent;
            this.mValidityChk_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.mValidityChk_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.mValidityChk_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.mValidityChk_btn.FillColor = System.Drawing.Color.Transparent;
            this.mValidityChk_btn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValidityChk_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.mValidityChk_btn.Image = ((System.Drawing.Image)(resources.GetObject("mValidityChk_btn.Image")));
            this.mValidityChk_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.mValidityChk_btn.Location = new System.Drawing.Point(43, 534);
            this.mValidityChk_btn.Name = "mValidityChk_btn";
            this.mValidityChk_btn.Size = new System.Drawing.Size(329, 45);
            this.mValidityChk_btn.TabIndex = 17;
            this.mValidityChk_btn.Text = "Medicine Validity Check";
            this.mValidityChk_btn.Click += new System.EventHandler(this.mValidityChk_btn_Click);
            // 
            // plogout_Button
            // 
            this.plogout_Button.BackColor = System.Drawing.Color.Transparent;
            this.plogout_Button.BorderColor = System.Drawing.Color.Transparent;
            this.plogout_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.plogout_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.plogout_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.plogout_Button.FillColor = System.Drawing.Color.Transparent;
            this.plogout_Button.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plogout_Button.ForeColor = System.Drawing.Color.MediumPurple;
            this.plogout_Button.Image = ((System.Drawing.Image)(resources.GetObject("plogout_Button.Image")));
            this.plogout_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.plogout_Button.Location = new System.Drawing.Point(77, 659);
            this.plogout_Button.Name = "plogout_Button";
            this.plogout_Button.Size = new System.Drawing.Size(257, 45);
            this.plogout_Button.TabIndex = 16;
            this.plogout_Button.Text = "Log Out";
            this.plogout_Button.Click += new System.EventHandler(this.plogout_Button_Click);
            // 
            // pModifyMedicine_btn
            // 
            this.pModifyMedicine_btn.BackColor = System.Drawing.Color.Transparent;
            this.pModifyMedicine_btn.BorderColor = System.Drawing.Color.Transparent;
            this.pModifyMedicine_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.pModifyMedicine_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.pModifyMedicine_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.pModifyMedicine_btn.FillColor = System.Drawing.Color.Transparent;
            this.pModifyMedicine_btn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pModifyMedicine_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.pModifyMedicine_btn.Image = ((System.Drawing.Image)(resources.GetObject("pModifyMedicine_btn.Image")));
            this.pModifyMedicine_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.pModifyMedicine_btn.Location = new System.Drawing.Point(77, 466);
            this.pModifyMedicine_btn.Name = "pModifyMedicine_btn";
            this.pModifyMedicine_btn.Size = new System.Drawing.Size(257, 45);
            this.pModifyMedicine_btn.TabIndex = 15;
            this.pModifyMedicine_btn.Text = "Modify Medicine";
            this.pModifyMedicine_btn.Click += new System.EventHandler(this.pModifyMedicine_btn_Click);
            // 
            // pViewMedicine_btn
            // 
            this.pViewMedicine_btn.BackColor = System.Drawing.Color.Transparent;
            this.pViewMedicine_btn.BorderColor = System.Drawing.Color.Transparent;
            this.pViewMedicine_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.pViewMedicine_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.pViewMedicine_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.pViewMedicine_btn.FillColor = System.Drawing.Color.Transparent;
            this.pViewMedicine_btn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pViewMedicine_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.pViewMedicine_btn.Image = ((System.Drawing.Image)(resources.GetObject("pViewMedicine_btn.Image")));
            this.pViewMedicine_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.pViewMedicine_btn.Location = new System.Drawing.Point(77, 397);
            this.pViewMedicine_btn.Name = "pViewMedicine_btn";
            this.pViewMedicine_btn.Size = new System.Drawing.Size(257, 45);
            this.pViewMedicine_btn.TabIndex = 14;
            this.pViewMedicine_btn.Text = "View Medicine";
            this.pViewMedicine_btn.Click += new System.EventHandler(this.pViewMedicine_btn_Click);
            // 
            // pAddMedicine_btn
            // 
            this.pAddMedicine_btn.BackColor = System.Drawing.Color.Transparent;
            this.pAddMedicine_btn.BorderColor = System.Drawing.Color.Transparent;
            this.pAddMedicine_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.pAddMedicine_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.pAddMedicine_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.pAddMedicine_btn.FillColor = System.Drawing.Color.Transparent;
            this.pAddMedicine_btn.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAddMedicine_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.pAddMedicine_btn.Image = ((System.Drawing.Image)(resources.GetObject("pAddMedicine_btn.Image")));
            this.pAddMedicine_btn.ImageSize = new System.Drawing.Size(35, 35);
            this.pAddMedicine_btn.Location = new System.Drawing.Point(77, 327);
            this.pAddMedicine_btn.Name = "pAddMedicine_btn";
            this.pAddMedicine_btn.Size = new System.Drawing.Size(257, 45);
            this.pAddMedicine_btn.TabIndex = 13;
            this.pAddMedicine_btn.Text = "Add Medicine";
            this.pAddMedicine_btn.Click += new System.EventHandler(this.pAddMedicine_btn_Click);
            // 
            // pDashboard_btn
            // 
            this.pDashboard_btn.BackColor = System.Drawing.Color.Transparent;
            this.pDashboard_btn.BorderColor = System.Drawing.Color.Transparent;
            this.pDashboard_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.pDashboard_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.pDashboard_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.pDashboard_btn.FillColor = System.Drawing.Color.Transparent;
            this.pDashboard_btn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDashboard_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.pDashboard_btn.Image = ((System.Drawing.Image)(resources.GetObject("pDashboard_btn.Image")));
            this.pDashboard_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.pDashboard_btn.Location = new System.Drawing.Point(77, 258);
            this.pDashboard_btn.Name = "pDashboard_btn";
            this.pDashboard_btn.Size = new System.Drawing.Size(257, 45);
            this.pDashboard_btn.TabIndex = 12;
            this.pDashboard_btn.Text = "Dashboard";
            this.pDashboard_btn.Click += new System.EventHandler(this.pDashboard_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(85, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.uC_P_ViewMedicines1);
            this.panel2.Controls.Add(this.uC_P_SellMedicine1);
            this.panel2.Controls.Add(this.uC_P_MedicineValidityCheck1);
            this.panel2.Controls.Add(this.uC_P_UpdateMedicine1);
            this.panel2.Controls.Add(this.uC_P_AddMedicine1);
            this.panel2.Controls.Add(this.uC_P_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(420, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 761);
            this.panel2.TabIndex = 1;
            // 
            // uC_P_ViewMedicines1
            // 
            this.uC_P_ViewMedicines1.BackColor = System.Drawing.Color.Transparent;
            this.uC_P_ViewMedicines1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_ViewMedicines1.Name = "uC_P_ViewMedicines1";
            this.uC_P_ViewMedicines1.Size = new System.Drawing.Size(960, 761);
            this.uC_P_ViewMedicines1.TabIndex = 5;
            // 
            // uC_P_SellMedicine1
            // 
            this.uC_P_SellMedicine1.BackColor = System.Drawing.Color.Transparent;
            this.uC_P_SellMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_SellMedicine1.Name = "uC_P_SellMedicine1";
            this.uC_P_SellMedicine1.Size = new System.Drawing.Size(960, 761);
            this.uC_P_SellMedicine1.TabIndex = 4;
            // 
            // uC_P_MedicineValidityCheck1
            // 
            this.uC_P_MedicineValidityCheck1.BackColor = System.Drawing.Color.Transparent;
            this.uC_P_MedicineValidityCheck1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_MedicineValidityCheck1.Name = "uC_P_MedicineValidityCheck1";
            this.uC_P_MedicineValidityCheck1.Size = new System.Drawing.Size(960, 761);
            this.uC_P_MedicineValidityCheck1.TabIndex = 3;
            // 
            // uC_P_UpdateMedicine1
            // 
            this.uC_P_UpdateMedicine1.BackColor = System.Drawing.Color.Transparent;
            this.uC_P_UpdateMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_UpdateMedicine1.Name = "uC_P_UpdateMedicine1";
            this.uC_P_UpdateMedicine1.Size = new System.Drawing.Size(960, 761);
            this.uC_P_UpdateMedicine1.TabIndex = 2;
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.BackColor = System.Drawing.Color.Transparent;
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(960, 761);
            this.uC_P_AddMedicine1.TabIndex = 1;
            // 
            // uC_P_Dashboard1
            // 
            this.uC_P_Dashboard1.BackColor = System.Drawing.Color.Transparent;
            this.uC_P_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_Dashboard1.Name = "uC_P_Dashboard1";
            this.uC_P_Dashboard1.Size = new System.Drawing.Size(960, 761);
            this.uC_P_Dashboard1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // PharmacistGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PharmacistGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button plogout_Button;
        private Guna.UI2.WinForms.Guna2Button pModifyMedicine_btn;
        private Guna.UI2.WinForms.Guna2Button pViewMedicine_btn;
        private Guna.UI2.WinForms.Guna2Button pAddMedicine_btn;
        private Guna.UI2.WinForms.Guna2Button pDashboard_btn;
        private Guna.UI2.WinForms.Guna2Button mValidityChk_btn;
        private Guna.UI2.WinForms.Guna2Button sellMedicine_btn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PharmacistUC.UC_P_Dashboard uC_P_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PharmacistUC.UC_P_AddMedicine uC_P_AddMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PharmacistUC.UC_P_UpdateMedicine uC_P_UpdateMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PharmacistUC.UC_P_MedicineValidityCheck uC_P_MedicineValidityCheck1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PharmacistUC.UC_P_SellMedicine uC_P_SellMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private PharmacistUC.UC_P_ViewMedicines uC_P_ViewMedicines1;
    }
}