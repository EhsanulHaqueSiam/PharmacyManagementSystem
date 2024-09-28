namespace PharmacyManagementSystem.AdminstratorUC
{
    partial class UC_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Profile));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name_txtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.mbl_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.mail_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.pass_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userName_lbl = new System.Windows.Forms.Label();
            this.dob_txt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.reset_btn = new Guna.UI2.WinForms.Guna2Button();
            this.update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.id_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.role_txtBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.srch_btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F);
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 10.2F);
            this.label3.Location = new System.Drawing.Point(536, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Forte", 10.2F);
            this.label4.Location = new System.Drawing.Point(536, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "DOB (Date of Birth)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Forte", 10.2F);
            this.label5.Location = new System.Drawing.Point(536, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mobile No";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Forte", 10.2F);
            this.label6.Location = new System.Drawing.Point(536, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Forte", 10.2F);
            this.label7.Location = new System.Drawing.Point(536, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password";
            // 
            // name_txtBox
            // 
            this.name_txtBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_txtBox.DefaultText = "";
            this.name_txtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name_txtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name_txtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txtBox.FillColor = System.Drawing.Color.LightSlateGray;
            this.name_txtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txtBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txtBox.ForeColor = System.Drawing.Color.White;
            this.name_txtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txtBox.Location = new System.Drawing.Point(555, 120);
            this.name_txtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_txtBox.Name = "name_txtBox";
            this.name_txtBox.PasswordChar = '\0';
            this.name_txtBox.PlaceholderText = "";
            this.name_txtBox.SelectedText = "";
            this.name_txtBox.Size = new System.Drawing.Size(387, 42);
            this.name_txtBox.TabIndex = 11;
            // 
            // mbl_txt
            // 
            this.mbl_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mbl_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mbl_txt.DefaultText = "";
            this.mbl_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mbl_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mbl_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mbl_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mbl_txt.FillColor = System.Drawing.Color.LightSlateGray;
            this.mbl_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mbl_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbl_txt.ForeColor = System.Drawing.Color.White;
            this.mbl_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mbl_txt.Location = new System.Drawing.Point(555, 286);
            this.mbl_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mbl_txt.Name = "mbl_txt";
            this.mbl_txt.PasswordChar = '\0';
            this.mbl_txt.PlaceholderText = "";
            this.mbl_txt.SelectedText = "";
            this.mbl_txt.Size = new System.Drawing.Size(387, 42);
            this.mbl_txt.TabIndex = 13;
            // 
            // mail_txt
            // 
            this.mail_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mail_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mail_txt.DefaultText = "";
            this.mail_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mail_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mail_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mail_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mail_txt.FillColor = System.Drawing.Color.LightSlateGray;
            this.mail_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mail_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_txt.ForeColor = System.Drawing.Color.White;
            this.mail_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mail_txt.Location = new System.Drawing.Point(555, 369);
            this.mail_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.PasswordChar = '\0';
            this.mail_txt.PlaceholderText = "";
            this.mail_txt.SelectedText = "";
            this.mail_txt.Size = new System.Drawing.Size(387, 42);
            this.mail_txt.TabIndex = 14;
            // 
            // pass_txt
            // 
            this.pass_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pass_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass_txt.DefaultText = "";
            this.pass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass_txt.FillColor = System.Drawing.Color.LightSlateGray;
            this.pass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.ForeColor = System.Drawing.Color.White;
            this.pass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass_txt.Location = new System.Drawing.Point(555, 454);
            this.pass_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '\0';
            this.pass_txt.PlaceholderText = "";
            this.pass_txt.SelectedText = "";
            this.pass_txt.Size = new System.Drawing.Size(387, 42);
            this.pass_txt.TabIndex = 15;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // userName_lbl
            // 
            this.userName_lbl.Font = new System.Drawing.Font("Cooper Black", 19.8F);
            this.userName_lbl.Location = new System.Drawing.Point(84, 475);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(297, 38);
            this.userName_lbl.TabIndex = 21;
            this.userName_lbl.Text = "username";
            this.userName_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dob_txt
            // 
            this.dob_txt.Checked = true;
            this.dob_txt.FillColor = System.Drawing.Color.LightSlateGray;
            this.dob_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dob_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dob_txt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dob_txt.Location = new System.Drawing.Point(555, 202);
            this.dob_txt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dob_txt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dob_txt.Name = "dob_txt";
            this.dob_txt.Size = new System.Drawing.Size(387, 42);
            this.dob_txt.TabIndex = 22;
            this.dob_txt.Value = new System.DateTime(2024, 9, 25, 3, 40, 19, 487);
            // 
            // reset_btn
            // 
            this.reset_btn.BorderRadius = 20;
            this.reset_btn.BorderThickness = 2;
            this.reset_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reset_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reset_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reset_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reset_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.White;
            this.reset_btn.Image = ((System.Drawing.Image)(resources.GetObject("reset_btn.Image")));
            this.reset_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.reset_btn.Location = new System.Drawing.Point(762, 536);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(180, 45);
            this.reset_btn.TabIndex = 23;
            this.reset_btn.Text = "Current User";
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BorderRadius = 20;
            this.update_btn.BorderThickness = 2;
            this.update_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Image = ((System.Drawing.Image)(resources.GetObject("update_btn.Image")));
            this.update_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.update_btn.Location = new System.Drawing.Point(555, 536);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(180, 45);
            this.update_btn.TabIndex = 24;
            this.update_btn.Text = "Update";
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // id_txt
            // 
            this.id_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_txt.DefaultText = "";
            this.id_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.id_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.id_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id_txt.FillColor = System.Drawing.Color.LightSlateGray;
            this.id_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.ForeColor = System.Drawing.Color.White;
            this.id_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_txt.Location = new System.Drawing.Point(555, 32);
            this.id_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id_txt.Name = "id_txt";
            this.id_txt.PasswordChar = '\0';
            this.id_txt.PlaceholderText = "";
            this.id_txt.SelectedText = "";
            this.id_txt.Size = new System.Drawing.Size(387, 42);
            this.id_txt.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 10.2F);
            this.label2.Location = new System.Drawing.Point(536, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Forte", 10.2F);
            this.label8.Location = new System.Drawing.Point(225, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "User Role";
            // 
            // role_txtBox
            // 
            this.role_txtBox.BackColor = System.Drawing.Color.Transparent;
            this.role_txtBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.role_txtBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_txtBox.FillColor = System.Drawing.Color.LightSlateGray;
            this.role_txtBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.role_txtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.role_txtBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.role_txtBox.ForeColor = System.Drawing.Color.White;
            this.role_txtBox.ItemHeight = 30;
            this.role_txtBox.Items.AddRange(new object[] {
            "Admin",
            "Pharmacist",
            "Customer"});
            this.role_txtBox.Location = new System.Drawing.Point(229, 30);
            this.role_txtBox.Name = "role_txtBox";
            this.role_txtBox.Size = new System.Drawing.Size(290, 36);
            this.role_txtBox.TabIndex = 28;
            // 
            // srch_btn
            // 
            this.srch_btn.BorderRadius = 20;
            this.srch_btn.BorderThickness = 2;
            this.srch_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.srch_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.srch_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.srch_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.srch_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srch_btn.ForeColor = System.Drawing.Color.White;
            this.srch_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.srch_btn.Location = new System.Drawing.Point(829, 79);
            this.srch_btn.Name = "srch_btn";
            this.srch_btn.Size = new System.Drawing.Size(113, 33);
            this.srch_btn.TabIndex = 29;
            this.srch_btn.Text = "Search";
            this.srch_btn.Click += new System.EventHandler(this.srch_btn_Click);
            // 
            // UC_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.srch_btn);
            this.Controls.Add(this.role_txtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.dob_txt);
            this.Controls.Add(this.userName_lbl);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.mbl_txt);
            this.Controls.Add(this.name_txtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Profile";
            this.Size = new System.Drawing.Size(960, 761);
            this.Load += new System.EventHandler(this.UC_Profile_Load);
            this.Enter += new System.EventHandler(this.UC_Profile_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox name_txtBox;
        private Guna.UI2.WinForms.Guna2TextBox mbl_txt;
        private Guna.UI2.WinForms.Guna2TextBox mail_txt;
        private Guna.UI2.WinForms.Guna2TextBox pass_txt;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label userName_lbl;
        private Guna.UI2.WinForms.Guna2DateTimePicker dob_txt;
        private Guna.UI2.WinForms.Guna2Button reset_btn;
        private Guna.UI2.WinForms.Guna2Button update_btn;
        private Guna.UI2.WinForms.Guna2ComboBox role_txtBox;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox id_txt;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button srch_btn;
    }
}
