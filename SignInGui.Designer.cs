namespace PharmacyManagementSystem
{
    partial class SignInGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInGui));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.home_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_C_Info1 = new PharmacyManagementSystem.CustomerSignInUC.UC_C_Info();
            this.uC_C_PhnNum1 = new PharmacyManagementSystem.CustomerSignInUC.UC_C_PhnNum();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_C_Otp1 = new PharmacyManagementSystem.CustomerSignInUC.UC_C_Otp();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.uC_C_Otp1);
            this.panel1.Controls.Add(this.uC_C_Info1);
            this.panel1.Controls.Add(this.uC_C_PhnNum1);
            this.panel1.Location = new System.Drawing.Point(613, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 700);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.BorderRadius = 20;
            this.home_btn.BorderThickness = 1;
            this.home_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.home_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.home_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.home_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.home_btn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.home_btn.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.HoverState.FillColor = System.Drawing.Color.Indigo;
            this.home_btn.HoverState.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.home_btn.Location = new System.Drawing.Point(37, 688);
            this.home_btn.Name = "home_btn";
            this.home_btn.PressedColor = System.Drawing.Color.MidnightBlue;
            this.home_btn.Size = new System.Drawing.Size(152, 45);
            this.home_btn.TabIndex = 21;
            this.home_btn.Text = "Home";
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.uC_C_Otp1;
            // 
            // uC_C_Info1
            // 
            this.uC_C_Info1.BackColor = System.Drawing.Color.Transparent;
            this.uC_C_Info1.Location = new System.Drawing.Point(39, 49);
            this.uC_C_Info1.Name = "uC_C_Info1";
            this.uC_C_Info1.Size = new System.Drawing.Size(685, 605);
            this.uC_C_Info1.TabIndex = 2;
            this.uC_C_Info1.Load += new System.EventHandler(this.uC_C_Info1_Load);
            // 
            // uC_C_PhnNum1
            // 
            this.uC_C_PhnNum1.Location = new System.Drawing.Point(39, 58);
            this.uC_C_PhnNum1.Name = "uC_C_PhnNum1";
            this.uC_C_PhnNum1.Size = new System.Drawing.Size(630, 602);
            this.uC_C_PhnNum1.TabIndex = 0;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.uC_C_Info1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.uC_C_PhnNum1;
            // 
            // uC_C_Otp1
            // 
            this.uC_C_Otp1.Location = new System.Drawing.Point(39, 51);
            this.uC_C_Otp1.Name = "uC_C_Otp1";
            this.uC_C_Otp1.Size = new System.Drawing.Size(676, 586);
            this.uC_C_Otp1.TabIndex = 3;
            // 
            // SignInGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1380, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignInGui";
            this.Load += new System.EventHandler(this.SignInGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private CustomerSignInUC.UC_C_PhnNum uC_C_PhnNum1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private CustomerSignInUC.UC_C_Info uC_C_Info1;
        private Guna.UI2.WinForms.Guna2Button home_btn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private CustomerSignInUC.UC_C_Otp uC_C_Otp1;
    }
}