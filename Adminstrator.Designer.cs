namespace PharmacyManagementSystem
{
    partial class Adminstrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminstrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_Button = new Guna.UI2.WinForms.Guna2Button();
            this.profile_Button = new Guna.UI2.WinForms.Guna2Button();
            this.viewUser_Button = new Guna.UI2.WinForms.Guna2Button();
            this.addUser_Button = new Guna.UI2.WinForms.Guna2Button();
            this.dashboard_Button = new Guna.UI2.WinForms.Guna2Button();
            this.admin_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_ViewUser1 = new PharmacyManagementSystem.AdminstratorUC.UC_ViewUser();
            this.uC_Profile1 = new PharmacyManagementSystem.AdminstratorUC.UC_Profile();
            this.uC_AddUser1 = new PharmacyManagementSystem.AdminstratorUC.UC_AddUser();
            this.uC_Dashboard1 = new PharmacyManagementSystem.AdminstratorUC.UC_Dashboard();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(207)))), ((int)(((byte)(229)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logout_Button);
            this.panel1.Controls.Add(this.profile_Button);
            this.panel1.Controls.Add(this.viewUser_Button);
            this.panel1.Controls.Add(this.addUser_Button);
            this.panel1.Controls.Add(this.dashboard_Button);
            this.panel1.Controls.Add(this.admin_pictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 762);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Administrator";
            // 
            // logout_Button
            // 
            this.logout_Button.BackColor = System.Drawing.Color.Transparent;
            this.logout_Button.BorderColor = System.Drawing.Color.Transparent;
            this.logout_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.logout_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.logout_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.logout_Button.FillColor = System.Drawing.Color.Transparent;
            this.logout_Button.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_Button.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.logout_Button.Image = ((System.Drawing.Image)(resources.GetObject("logout_Button.Image")));
            this.logout_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.logout_Button.Location = new System.Drawing.Point(77, 614);
            this.logout_Button.Name = "logout_Button";
            this.logout_Button.Size = new System.Drawing.Size(257, 45);
            this.logout_Button.TabIndex = 11;
            this.logout_Button.Text = "Log Out";
            this.logout_Button.Click += new System.EventHandler(this.logout_Button_Click);
            // 
            // profile_Button
            // 
            this.profile_Button.BackColor = System.Drawing.Color.Transparent;
            this.profile_Button.BorderColor = System.Drawing.Color.Transparent;
            this.profile_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.profile_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.profile_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.profile_Button.FillColor = System.Drawing.Color.Transparent;
            this.profile_Button.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_Button.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.profile_Button.Image = ((System.Drawing.Image)(resources.GetObject("profile_Button.Image")));
            this.profile_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.profile_Button.Location = new System.Drawing.Point(77, 538);
            this.profile_Button.Name = "profile_Button";
            this.profile_Button.Size = new System.Drawing.Size(257, 45);
            this.profile_Button.TabIndex = 10;
            this.profile_Button.Text = "Profile";
            this.profile_Button.Click += new System.EventHandler(this.profile_Button_Click);
            // 
            // viewUser_Button
            // 
            this.viewUser_Button.BackColor = System.Drawing.Color.Transparent;
            this.viewUser_Button.BorderColor = System.Drawing.Color.Transparent;
            this.viewUser_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.viewUser_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.viewUser_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.viewUser_Button.FillColor = System.Drawing.Color.Transparent;
            this.viewUser_Button.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUser_Button.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.viewUser_Button.Image = ((System.Drawing.Image)(resources.GetObject("viewUser_Button.Image")));
            this.viewUser_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.viewUser_Button.Location = new System.Drawing.Point(77, 465);
            this.viewUser_Button.Name = "viewUser_Button";
            this.viewUser_Button.Size = new System.Drawing.Size(257, 45);
            this.viewUser_Button.TabIndex = 9;
            this.viewUser_Button.Text = "View User";
            this.viewUser_Button.Click += new System.EventHandler(this.viewUser_Button_Click);
            // 
            // addUser_Button
            // 
            this.addUser_Button.BackColor = System.Drawing.Color.Transparent;
            this.addUser_Button.BorderColor = System.Drawing.Color.Transparent;
            this.addUser_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.addUser_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.addUser_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.addUser_Button.FillColor = System.Drawing.Color.Transparent;
            this.addUser_Button.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser_Button.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.addUser_Button.Image = ((System.Drawing.Image)(resources.GetObject("addUser_Button.Image")));
            this.addUser_Button.ImageSize = new System.Drawing.Size(35, 35);
            this.addUser_Button.Location = new System.Drawing.Point(77, 386);
            this.addUser_Button.Name = "addUser_Button";
            this.addUser_Button.Size = new System.Drawing.Size(257, 45);
            this.addUser_Button.TabIndex = 8;
            this.addUser_Button.Text = "Add User";
            this.addUser_Button.Click += new System.EventHandler(this.addUser_Button_Click);
            // 
            // dashboard_Button
            // 
            this.dashboard_Button.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_Button.BorderColor = System.Drawing.Color.Transparent;
            this.dashboard_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.dashboard_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(201)))));
            this.dashboard_Button.CheckedState.ForeColor = System.Drawing.Color.White;
            this.dashboard_Button.FillColor = System.Drawing.Color.Transparent;
            this.dashboard_Button.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_Button.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dashboard_Button.Image = ((System.Drawing.Image)(resources.GetObject("dashboard_Button.Image")));
            this.dashboard_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.dashboard_Button.Location = new System.Drawing.Point(77, 313);
            this.dashboard_Button.Name = "dashboard_Button";
            this.dashboard_Button.Size = new System.Drawing.Size(257, 45);
            this.dashboard_Button.TabIndex = 7;
            this.dashboard_Button.Text = "Dashboard";
            this.dashboard_Button.Click += new System.EventHandler(this.dashboard_Button_Click);
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
            this.admin_pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.uC_ViewUser1);
            this.panel2.Controls.Add(this.uC_Profile1);
            this.panel2.Controls.Add(this.uC_AddUser1);
            this.panel2.Controls.Add(this.uC_Dashboard1);
            this.panel2.ForeColor = System.Drawing.Color.SlateBlue;
            this.panel2.Location = new System.Drawing.Point(420, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 761);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uC_ViewUser1
            // 
            this.uC_ViewUser1.BackColor = System.Drawing.Color.Transparent;
            this.uC_ViewUser1.Location = new System.Drawing.Point(1, 1);
            this.uC_ViewUser1.Name = "uC_ViewUser1";
            this.uC_ViewUser1.Size = new System.Drawing.Size(960, 761);
            this.uC_ViewUser1.TabIndex = 8;
            // 
            // uC_Profile1
            // 
            this.uC_Profile1.BackColor = System.Drawing.Color.Transparent;
            this.uC_Profile1.Location = new System.Drawing.Point(1, 1);
            this.uC_Profile1.Name = "uC_Profile1";
            this.uC_Profile1.Size = new System.Drawing.Size(960, 761);
            this.uC_Profile1.TabIndex = 7;
            this.uC_Profile1.Load += new System.EventHandler(this.uC_Profile1_Load);
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.Transparent;
            this.uC_AddUser1.Location = new System.Drawing.Point(1, 1);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(960, 761);
            this.uC_AddUser1.TabIndex = 6;
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.BackColor = System.Drawing.Color.Transparent;
            this.uC_Dashboard1.Location = new System.Drawing.Point(1, 1);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(960, 761);
            this.uC_Dashboard1.TabIndex = 5;
            this.uC_Dashboard1.Load += new System.EventHandler(this.uC_Dashboard1_Load);
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
            // Adminstrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminstrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminstrator";
            this.Load += new System.EventHandler(this.Adminstrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox admin_pictureBox;
        private Guna.UI2.WinForms.Guna2Button logout_Button;
        private Guna.UI2.WinForms.Guna2Button profile_Button;
        private Guna.UI2.WinForms.Guna2Button viewUser_Button;
        private Guna.UI2.WinForms.Guna2Button addUser_Button;
        private Guna.UI2.WinForms.Guna2Button dashboard_Button;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AdminstratorUC.UC_Dashboard uC_Dashboard1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AdminstratorUC.UC_AddUser uC_AddUser1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AdminstratorUC.UC_Profile uC_Profile1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AdminstratorUC.UC_ViewUser uC_ViewUser1;
    }
}