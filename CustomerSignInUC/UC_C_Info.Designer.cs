namespace PharmacyManagementSystem.CustomerSignInUC
{
    partial class UC_C_Info
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_C_Info));
            this.dob_txt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.name_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CInfoBack_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pass_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.mail_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userName_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.otp_btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dob_txt
            // 
            this.dob_txt.Checked = true;
            this.dob_txt.FillColor = System.Drawing.Color.LightSteelBlue;
            this.dob_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dob_txt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dob_txt.Location = new System.Drawing.Point(17, 374);
            this.dob_txt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dob_txt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dob_txt.Name = "dob_txt";
            this.dob_txt.Size = new System.Drawing.Size(325, 36);
            this.dob_txt.TabIndex = 24;
            this.dob_txt.Value = new System.DateTime(2024, 9, 21, 23, 30, 56, 66);
            // 
            // name_txt
            // 
            this.name_txt.BackColor = System.Drawing.Color.Silver;
            this.name_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_txt.DefaultText = "";
            this.name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txt.FillColor = System.Drawing.Color.Silver;
            this.name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.name_txt.ForeColor = System.Drawing.Color.Black;
            this.name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.Location = new System.Drawing.Point(17, 36);
            this.name_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_txt.Name = "name_txt";
            this.name_txt.PasswordChar = '\0';
            this.name_txt.PlaceholderText = "";
            this.name_txt.SelectedText = "";
            this.name_txt.Size = new System.Drawing.Size(325, 36);
            this.name_txt.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Forte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "DOB (Date of Birth)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Name";
            // 
            // CInfoBack_btn
            // 
            this.CInfoBack_btn.BorderRadius = 19;
            this.CInfoBack_btn.BorderThickness = 1;
            this.CInfoBack_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CInfoBack_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CInfoBack_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CInfoBack_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CInfoBack_btn.FillColor = System.Drawing.Color.SlateBlue;
            this.CInfoBack_btn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.CInfoBack_btn.ForeColor = System.Drawing.Color.White;
            this.CInfoBack_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.CInfoBack_btn.HoverState.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CInfoBack_btn.Image = ((System.Drawing.Image)(resources.GetObject("CInfoBack_btn.Image")));
            this.CInfoBack_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.CInfoBack_btn.Location = new System.Drawing.Point(130, 475);
            this.CInfoBack_btn.Name = "CInfoBack_btn";
            this.CInfoBack_btn.Size = new System.Drawing.Size(160, 45);
            this.CInfoBack_btn.TabIndex = 31;
            this.CInfoBack_btn.Text = "Back";
            this.CInfoBack_btn.Click += new System.EventHandler(this.CInfoBack_btn_Click);
            // 
            // pass_txt
            // 
            this.pass_txt.BackColor = System.Drawing.Color.Silver;
            this.pass_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass_txt.DefaultText = "";
            this.pass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass_txt.FillColor = System.Drawing.Color.Silver;
            this.pass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pass_txt.ForeColor = System.Drawing.Color.Black;
            this.pass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass_txt.Location = new System.Drawing.Point(17, 279);
            this.pass_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '\0';
            this.pass_txt.PlaceholderText = "";
            this.pass_txt.SelectedText = "";
            this.pass_txt.Size = new System.Drawing.Size(325, 36);
            this.pass_txt.TabIndex = 30;
            // 
            // mail_txt
            // 
            this.mail_txt.BackColor = System.Drawing.Color.Silver;
            this.mail_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mail_txt.DefaultText = "";
            this.mail_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mail_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mail_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mail_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mail_txt.FillColor = System.Drawing.Color.Silver;
            this.mail_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mail_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mail_txt.ForeColor = System.Drawing.Color.Black;
            this.mail_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mail_txt.Location = new System.Drawing.Point(17, 201);
            this.mail_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.PasswordChar = '\0';
            this.mail_txt.PlaceholderText = "";
            this.mail_txt.SelectedText = "";
            this.mail_txt.Size = new System.Drawing.Size(325, 36);
            this.mail_txt.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Forte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Forte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "User Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Forte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email Address";
            // 
            // userName_txt
            // 
            this.userName_txt.BackColor = System.Drawing.Color.Silver;
            this.userName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName_txt.DefaultText = "";
            this.userName_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userName_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userName_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userName_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userName_txt.FillColor = System.Drawing.Color.Silver;
            this.userName_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userName_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userName_txt.ForeColor = System.Drawing.Color.Black;
            this.userName_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userName_txt.Location = new System.Drawing.Point(17, 113);
            this.userName_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.PasswordChar = '\0';
            this.userName_txt.PlaceholderText = "";
            this.userName_txt.SelectedText = "";
            this.userName_txt.Size = new System.Drawing.Size(325, 36);
            this.userName_txt.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(185, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "After Completing the form click Otp";
            // 
            // otp_btn
            // 
            this.otp_btn.BorderRadius = 19;
            this.otp_btn.BorderThickness = 1;
            this.otp_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.otp_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.otp_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.otp_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.otp_btn.FillColor = System.Drawing.Color.SlateBlue;
            this.otp_btn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.otp_btn.ForeColor = System.Drawing.Color.White;
            this.otp_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.otp_btn.HoverState.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.otp_btn.Image = ((System.Drawing.Image)(resources.GetObject("otp_btn.Image")));
            this.otp_btn.ImageSize = new System.Drawing.Size(50, 50);
            this.otp_btn.Location = new System.Drawing.Point(348, 475);
            this.otp_btn.Name = "otp_btn";
            this.otp_btn.Size = new System.Drawing.Size(160, 45);
            this.otp_btn.TabIndex = 36;
            this.otp_btn.Text = "OTP";
            this.otp_btn.Click += new System.EventHandler(this.otp_btn_Click);
            // 
            // UC_C_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.otp_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userName_txt);
            this.Controls.Add(this.CInfoBack_btn);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dob_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "UC_C_Info";
            this.Size = new System.Drawing.Size(700, 600);
            this.Load += new System.EventHandler(this.UC_C_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dob_txt;
        private Guna.UI2.WinForms.Guna2TextBox name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button CInfoBack_btn;
        private Guna.UI2.WinForms.Guna2TextBox pass_txt;
        private Guna.UI2.WinForms.Guna2TextBox mail_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox userName_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button otp_btn;
    }
}
