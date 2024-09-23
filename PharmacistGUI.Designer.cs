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
            this.sell_Button = new Guna.UI2.WinForms.Guna2Button();
            this.validityCheck_button = new Guna.UI2.WinForms.Guna2Button();
            this.logout_Button = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.modify_Button = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewMedicine_Button = new Guna.UI2.WinForms.Guna2Button();
            this.dashboard_Button = new Guna.UI2.WinForms.Guna2Button();
            this.addMedicine_Button = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_P_MedicineValidityCheck1 = new PharmacyManagementSystem.PharmacistUC.UC_P_MedicineValidityCheck();
            this.uC_P_UpdateMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_UpdateMedicine();
            this.uC_P_ViewMedicines1 = new PharmacyManagementSystem.PharmacistUC.UC_P_ViewMedicines();
            this.uC_P_AddMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_AddMedicine();
            this.uC_P_Dashboard1 = new PharmacyManagementSystem.PharmacistUC.UC_P_Dashboard();
            this.uC_P_SellMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_SellMedicine();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.sell_Button);
            this.panel1.Controls.Add(this.validityCheck_button);
            this.panel1.Controls.Add(this.logout_Button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.modify_Button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.viewMedicine_Button);
            this.panel1.Controls.Add(this.dashboard_Button);
            this.panel1.Controls.Add(this.addMedicine_Button);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 762);
            this.panel1.TabIndex = 0;
            // 
            // sell_Button
            // 
            this.sell_Button.BackColor = System.Drawing.Color.Transparent;
            this.sell_Button.BorderColor = System.Drawing.Color.Transparent;
            this.sell_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.sell_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(233)))));
            this.sell_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.sell_Button.FillColor = System.Drawing.Color.Transparent;
            this.sell_Button.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_Button.ForeColor = System.Drawing.Color.MediumPurple;
            this.sell_Button.Image = ((System.Drawing.Image)(resources.GetObject("sell_Button.Image")));
            this.sell_Button.ImageSize = new System.Drawing.Size(40, 40);
            this.sell_Button.Location = new System.Drawing.Point(71, 568);
            this.sell_Button.Name = "sell_Button";
            this.sell_Button.PressedColor = System.Drawing.Color.Silver;
            this.sell_Button.Size = new System.Drawing.Size(257, 45);
            this.sell_Button.TabIndex = 18;
            this.sell_Button.Text = "Sell Medicine";
            this.sell_Button.Click += new System.EventHandler(this.sell_Button_Click);
            // 
            // validityCheck_button
            // 
            this.validityCheck_button.BackColor = System.Drawing.Color.Transparent;
            this.validityCheck_button.BorderColor = System.Drawing.Color.Transparent;
            this.validityCheck_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.validityCheck_button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(233)))));
            this.validityCheck_button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.validityCheck_button.FillColor = System.Drawing.Color.Transparent;
            this.validityCheck_button.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validityCheck_button.ForeColor = System.Drawing.Color.MediumPurple;
            this.validityCheck_button.Image = ((System.Drawing.Image)(resources.GetObject("validityCheck_button.Image")));
            this.validityCheck_button.ImageSize = new System.Drawing.Size(35, 35);
            this.validityCheck_button.Location = new System.Drawing.Point(22, 504);
            this.validityCheck_button.Name = "validityCheck_button";
            this.validityCheck_button.PressedColor = System.Drawing.Color.Silver;
            this.validityCheck_button.Size = new System.Drawing.Size(377, 45);
            this.validityCheck_button.TabIndex = 17;
            this.validityCheck_button.Text = "Madicine Validity Check";
            this.validityCheck_button.Click += new System.EventHandler(this.validityCheck_button_Click);
            // 
            // logout_Button
            // 
            this.logout_Button.BackColor = System.Drawing.Color.Transparent;
            this.logout_Button.BorderColor = System.Drawing.Color.Transparent;
            this.logout_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.logout_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(233)))));
            this.logout_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.logout_Button.FillColor = System.Drawing.Color.Transparent;
            this.logout_Button.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_Button.ForeColor = System.Drawing.Color.MediumPurple;
            this.logout_Button.Image = ((System.Drawing.Image)(resources.GetObject("logout_Button.Image")));
            this.logout_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.logout_Button.Location = new System.Drawing.Point(97, 637);
            this.logout_Button.Name = "logout_Button";
            this.logout_Button.PressedColor = System.Drawing.Color.Silver;
            this.logout_Button.Size = new System.Drawing.Size(187, 45);
            this.logout_Button.TabIndex = 16;
            this.logout_Button.Text = "Log Out";
            this.logout_Button.Click += new System.EventHandler(this.logout_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(79, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pharmacist";
            // 
            // modify_Button
            // 
            this.modify_Button.BackColor = System.Drawing.Color.Transparent;
            this.modify_Button.BorderColor = System.Drawing.Color.Transparent;
            this.modify_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.modify_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(233)))));
            this.modify_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.modify_Button.FillColor = System.Drawing.Color.Transparent;
            this.modify_Button.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_Button.ForeColor = System.Drawing.Color.MediumPurple;
            this.modify_Button.Image = ((System.Drawing.Image)(resources.GetObject("modify_Button.Image")));
            this.modify_Button.ImageSize = new System.Drawing.Size(40, 40);
            this.modify_Button.Location = new System.Drawing.Point(56, 436);
            this.modify_Button.Name = "modify_Button";
            this.modify_Button.PressedColor = System.Drawing.Color.Silver;
            this.modify_Button.Size = new System.Drawing.Size(272, 45);
            this.modify_Button.TabIndex = 15;
            this.modify_Button.Text = "Modify Medicine";
            this.modify_Button.Click += new System.EventHandler(this.modify_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // viewMedicine_Button
            // 
            this.viewMedicine_Button.BackColor = System.Drawing.Color.Transparent;
            this.viewMedicine_Button.BorderColor = System.Drawing.Color.Transparent;
            this.viewMedicine_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.viewMedicine_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(233)))));
            this.viewMedicine_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.viewMedicine_Button.FillColor = System.Drawing.Color.Transparent;
            this.viewMedicine_Button.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMedicine_Button.ForeColor = System.Drawing.Color.MediumPurple;
            this.viewMedicine_Button.Image = ((System.Drawing.Image)(resources.GetObject("viewMedicine_Button.Image")));
            this.viewMedicine_Button.ImageSize = new System.Drawing.Size(40, 40);
            this.viewMedicine_Button.Location = new System.Drawing.Point(71, 370);
            this.viewMedicine_Button.Name = "viewMedicine_Button";
            this.viewMedicine_Button.PressedColor = System.Drawing.Color.Silver;
            this.viewMedicine_Button.Size = new System.Drawing.Size(257, 45);
            this.viewMedicine_Button.TabIndex = 14;
            this.viewMedicine_Button.Text = "View Medicine";
            this.viewMedicine_Button.Click += new System.EventHandler(this.viewUser_Button_Click);
            // 
            // dashboard_Button
            // 
            this.dashboard_Button.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_Button.BorderColor = System.Drawing.Color.Transparent;
            this.dashboard_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.dashboard_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(233)))));
            this.dashboard_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.dashboard_Button.FillColor = System.Drawing.Color.Transparent;
            this.dashboard_Button.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_Button.ForeColor = System.Drawing.Color.MediumPurple;
            this.dashboard_Button.Image = ((System.Drawing.Image)(resources.GetObject("dashboard_Button.Image")));
            this.dashboard_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.dashboard_Button.Location = new System.Drawing.Point(71, 232);
            this.dashboard_Button.Name = "dashboard_Button";
            this.dashboard_Button.PressedColor = System.Drawing.Color.Silver;
            this.dashboard_Button.Size = new System.Drawing.Size(257, 45);
            this.dashboard_Button.TabIndex = 12;
            this.dashboard_Button.Text = "Dashboard";
            this.dashboard_Button.Click += new System.EventHandler(this.dashboard_Button_Click);
            // 
            // addMedicine_Button
            // 
            this.addMedicine_Button.BackColor = System.Drawing.Color.Transparent;
            this.addMedicine_Button.BorderColor = System.Drawing.Color.Transparent;
            this.addMedicine_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.addMedicine_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(233)))));
            this.addMedicine_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.addMedicine_Button.FillColor = System.Drawing.Color.Transparent;
            this.addMedicine_Button.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedicine_Button.ForeColor = System.Drawing.Color.MediumPurple;
            this.addMedicine_Button.Image = ((System.Drawing.Image)(resources.GetObject("addMedicine_Button.Image")));
            this.addMedicine_Button.ImageSize = new System.Drawing.Size(35, 35);
            this.addMedicine_Button.Location = new System.Drawing.Point(71, 299);
            this.addMedicine_Button.Name = "addMedicine_Button";
            this.addMedicine_Button.PressedColor = System.Drawing.Color.Silver;
            this.addMedicine_Button.Size = new System.Drawing.Size(257, 45);
            this.addMedicine_Button.TabIndex = 13;
            this.addMedicine_Button.Text = "Add Medicine";
            this.addMedicine_Button.Click += new System.EventHandler(this.addUser_Button_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.uC_P_SellMedicine1);
            this.panel2.Controls.Add(this.uC_P_MedicineValidityCheck1);
            this.panel2.Controls.Add(this.uC_P_UpdateMedicine1);
            this.panel2.Controls.Add(this.uC_P_ViewMedicines1);
            this.panel2.Controls.Add(this.uC_P_AddMedicine1);
            this.panel2.Controls.Add(this.uC_P_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(420, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 761);
            this.panel2.TabIndex = 1;
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
            // uC_P_MedicineValidityCheck1
            // 
            this.uC_P_MedicineValidityCheck1.BackColor = System.Drawing.Color.Transparent;
            this.uC_P_MedicineValidityCheck1.Location = new System.Drawing.Point(1, 1);
            this.uC_P_MedicineValidityCheck1.Name = "uC_P_MedicineValidityCheck1";
            this.uC_P_MedicineValidityCheck1.Size = new System.Drawing.Size(960, 761);
            this.uC_P_MedicineValidityCheck1.TabIndex = 4;
            // 
            // uC_P_UpdateMedicine1
            // 
            this.uC_P_UpdateMedicine1.BackColor = System.Drawing.Color.Transparent;
            this.uC_P_UpdateMedicine1.Location = new System.Drawing.Point(1, 1);
            this.uC_P_UpdateMedicine1.Name = "uC_P_UpdateMedicine1";
            this.uC_P_UpdateMedicine1.Size = new System.Drawing.Size(960, 761);
            this.uC_P_UpdateMedicine1.TabIndex = 3;
            // 
            // uC_P_ViewMedicines1
            // 
            this.uC_P_ViewMedicines1.BackColor = System.Drawing.Color.Transparent;
            this.uC_P_ViewMedicines1.Location = new System.Drawing.Point(1, 1);
            this.uC_P_ViewMedicines1.Name = "uC_P_ViewMedicines1";
            this.uC_P_ViewMedicines1.Size = new System.Drawing.Size(960, 761);
            this.uC_P_ViewMedicines1.TabIndex = 2;
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.BackColor = System.Drawing.Color.Transparent;
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(1, 1);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(960, 761);
            this.uC_P_AddMedicine1.TabIndex = 1;
            // 
            // uC_P_Dashboard1
            // 
            this.uC_P_Dashboard1.BackColor = System.Drawing.Color.Transparent;
            this.uC_P_Dashboard1.Location = new System.Drawing.Point(1, 1);
            this.uC_P_Dashboard1.Name = "uC_P_Dashboard1";
            this.uC_P_Dashboard1.Size = new System.Drawing.Size(960, 761);
            this.uC_P_Dashboard1.TabIndex = 0;
            // 
            // uC_P_SellMedicine1
            // 
            this.uC_P_SellMedicine1.BackColor = System.Drawing.Color.Transparent;
            this.uC_P_SellMedicine1.Location = new System.Drawing.Point(1, 1);
            this.uC_P_SellMedicine1.Name = "uC_P_SellMedicine1";
            this.uC_P_SellMedicine1.Size = new System.Drawing.Size(960, 761);
            this.uC_P_SellMedicine1.TabIndex = 5;
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
        private Guna.UI2.WinForms.Guna2Button sell_Button;
        private Guna.UI2.WinForms.Guna2Button validityCheck_button;
        private Guna.UI2.WinForms.Guna2Button logout_Button;
        private Guna.UI2.WinForms.Guna2Button modify_Button;
        private Guna.UI2.WinForms.Guna2Button viewMedicine_Button;
        private Guna.UI2.WinForms.Guna2Button dashboard_Button;
        private Guna.UI2.WinForms.Guna2Button addMedicine_Button;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PharmacistUC.UC_P_Dashboard uC_P_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PharmacistUC.UC_P_AddMedicine uC_P_AddMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PharmacistUC.UC_P_ViewMedicines uC_P_ViewMedicines1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PharmacistUC.UC_P_UpdateMedicine uC_P_UpdateMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PharmacistUC.UC_P_MedicineValidityCheck uC_P_MedicineValidityCheck1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private PharmacistUC.UC_P_SellMedicine uC_P_SellMedicine1;
    }
}