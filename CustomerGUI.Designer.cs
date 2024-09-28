namespace PharmacyManagementSystem
{
    partial class CustomerGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buyMed_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Cprofile_Button = new Guna.UI2.WinForms.Guna2Button();
            this.admin_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_P_SellMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_SellMedicine();
            this.uC_C_Profile1 = new PharmacyManagementSystem.CustomerUC.UC_C_Profile();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(207)))), ((int)(((byte)(229)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.buyMed_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logout_Button);
            this.panel1.Controls.Add(this.Cprofile_Button);
            this.panel1.Controls.Add(this.admin_pictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 762);
            this.panel1.TabIndex = 1;
            // 
            // buyMed_btn
            // 
            this.buyMed_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(207)))), ((int)(((byte)(229)))));
            this.buyMed_btn.BorderColor = System.Drawing.Color.Transparent;
            this.buyMed_btn.BorderRadius = 10;
            this.buyMed_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buyMed_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.buyMed_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.buyMed_btn.FillColor = System.Drawing.Color.Transparent;
            this.buyMed_btn.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyMed_btn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buyMed_btn.Image = ((System.Drawing.Image)(resources.GetObject("buyMed_btn.Image")));
            this.buyMed_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.buyMed_btn.Location = new System.Drawing.Point(59, 435);
            this.buyMed_btn.Name = "buyMed_btn";
            this.buyMed_btn.Size = new System.Drawing.Size(313, 60);
            this.buyMed_btn.TabIndex = 13;
            this.buyMed_btn.Text = "Buy Medicine";
            this.buyMed_btn.Click += new System.EventHandler(this.buyMed_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(112, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer";
            // 
            // logout_Button
            // 
            this.logout_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(207)))), ((int)(((byte)(229)))));
            this.logout_Button.BorderColor = System.Drawing.Color.Transparent;
            this.logout_Button.BorderRadius = 10;
            this.logout_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.logout_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.logout_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.logout_Button.FillColor = System.Drawing.Color.Transparent;
            this.logout_Button.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_Button.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.logout_Button.Image = ((System.Drawing.Image)(resources.GetObject("logout_Button.Image")));
            this.logout_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.logout_Button.Location = new System.Drawing.Point(83, 519);
            this.logout_Button.Name = "logout_Button";
            this.logout_Button.Size = new System.Drawing.Size(266, 60);
            this.logout_Button.TabIndex = 11;
            this.logout_Button.Text = "Log Out";
            this.logout_Button.Click += new System.EventHandler(this.logout_Button_Click);
            // 
            // Cprofile_Button
            // 
            this.Cprofile_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(207)))), ((int)(((byte)(229)))));
            this.Cprofile_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Cprofile_Button.BorderRadius = 10;
            this.Cprofile_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Cprofile_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.Cprofile_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.Cprofile_Button.FillColor = System.Drawing.Color.Transparent;
            this.Cprofile_Button.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cprofile_Button.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Cprofile_Button.Image = ((System.Drawing.Image)(resources.GetObject("Cprofile_Button.Image")));
            this.Cprofile_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Cprofile_Button.Location = new System.Drawing.Point(83, 354);
            this.Cprofile_Button.Name = "Cprofile_Button";
            this.Cprofile_Button.Size = new System.Drawing.Size(266, 52);
            this.Cprofile_Button.TabIndex = 10;
            this.Cprofile_Button.Text = "Profile";
            this.Cprofile_Button.Click += new System.EventHandler(this.Cprofile_Button_Click);
            // 
            // admin_pictureBox
            // 
            this.admin_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.admin_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("admin_pictureBox.Image")));
            this.admin_pictureBox.Location = new System.Drawing.Point(118, 7);
            this.admin_pictureBox.Name = "admin_pictureBox";
            this.admin_pictureBox.Size = new System.Drawing.Size(156, 146);
            this.admin_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin_pictureBox.TabIndex = 5;
            this.admin_pictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.uC_P_SellMedicine1);
            this.panel2.Controls.Add(this.uC_C_Profile1);
            this.panel2.Location = new System.Drawing.Point(420, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 761);
            this.panel2.TabIndex = 2;
            // 
            // uC_P_SellMedicine1
            // 
            this.uC_P_SellMedicine1.BackColor = System.Drawing.Color.Transparent;
            this.uC_P_SellMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_SellMedicine1.Name = "uC_P_SellMedicine1";
            this.uC_P_SellMedicine1.Size = new System.Drawing.Size(960, 761);
            this.uC_P_SellMedicine1.TabIndex = 2;
            // 
            // uC_C_Profile1
            // 
            this.uC_C_Profile1.BackColor = System.Drawing.Color.Transparent;
            this.uC_C_Profile1.Location = new System.Drawing.Point(0, 0);
            this.uC_C_Profile1.Name = "uC_C_Profile1";
            this.uC_C_Profile1.Size = new System.Drawing.Size(960, 761);
            this.uC_C_Profile1.TabIndex = 0;
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
            // CustomerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerGUI";
            this.Load += new System.EventHandler(this.CustomerGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button logout_Button;
        private Guna.UI2.WinForms.Guna2Button Cprofile_Button;
        private System.Windows.Forms.PictureBox admin_pictureBox;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private CustomerUC.UC_C_Profile uC_C_Profile1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PharmacistUC.UC_P_SellMedicine uC_P_SellMedicine1;
        private Guna.UI2.WinForms.Guna2Button buyMed_btn;
    }
}