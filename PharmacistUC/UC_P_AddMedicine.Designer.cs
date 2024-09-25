namespace PharmacyManagementSystem.PharmacistUC
{
    partial class UC_P_AddMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_P_AddMedicine));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.medManufact_dateBox = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.medAdd_btn = new Guna.UI2.WinForms.Guna2Button();
            this.medReset_btn = new Guna.UI2.WinForms.Guna2Button();
            this.medExpire_dateBox = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.medName_txtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.medChem_txtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.medQuantity_txtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.medPrice_txtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Medicine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medicine Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Medicine Chemical Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manufacturing Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Expire Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(569, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(569, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Price per unit";
            // 
            // medManufact_dateBox
            // 
            this.medManufact_dateBox.Checked = true;
            this.medManufact_dateBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.medManufact_dateBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.medManufact_dateBox.ForeColor = System.Drawing.Color.White;
            this.medManufact_dateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.medManufact_dateBox.Location = new System.Drawing.Point(69, 362);
            this.medManufact_dateBox.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.medManufact_dateBox.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.medManufact_dateBox.Name = "medManufact_dateBox";
            this.medManufact_dateBox.Size = new System.Drawing.Size(346, 36);
            this.medManufact_dateBox.TabIndex = 15;
            this.medManufact_dateBox.Value = new System.DateTime(2024, 9, 23, 20, 46, 46, 573);
            // 
            // medAdd_btn
            // 
            this.medAdd_btn.BorderRadius = 20;
            this.medAdd_btn.BorderThickness = 1;
            this.medAdd_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.medAdd_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.medAdd_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.medAdd_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.medAdd_btn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.medAdd_btn.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medAdd_btn.ForeColor = System.Drawing.Color.White;
            this.medAdd_btn.HoverState.FillColor = System.Drawing.Color.Indigo;
            this.medAdd_btn.HoverState.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medAdd_btn.Image = ((System.Drawing.Image)(resources.GetObject("medAdd_btn.Image")));
            this.medAdd_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.medAdd_btn.Location = new System.Drawing.Point(582, 476);
            this.medAdd_btn.Name = "medAdd_btn";
            this.medAdd_btn.PressedColor = System.Drawing.Color.MidnightBlue;
            this.medAdd_btn.Size = new System.Drawing.Size(152, 45);
            this.medAdd_btn.TabIndex = 18;
            this.medAdd_btn.Text = "Add";
            this.medAdd_btn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // medReset_btn
            // 
            this.medReset_btn.BorderRadius = 20;
            this.medReset_btn.BorderThickness = 1;
            this.medReset_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.medReset_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.medReset_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.medReset_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.medReset_btn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.medReset_btn.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medReset_btn.ForeColor = System.Drawing.Color.White;
            this.medReset_btn.HoverState.FillColor = System.Drawing.Color.Indigo;
            this.medReset_btn.HoverState.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medReset_btn.Image = ((System.Drawing.Image)(resources.GetObject("medReset_btn.Image")));
            this.medReset_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.medReset_btn.Location = new System.Drawing.Point(787, 476);
            this.medReset_btn.Name = "medReset_btn";
            this.medReset_btn.PressedColor = System.Drawing.Color.MidnightBlue;
            this.medReset_btn.Size = new System.Drawing.Size(152, 45);
            this.medReset_btn.TabIndex = 19;
            this.medReset_btn.Text = "Reset";
            // 
            // medExpire_dateBox
            // 
            this.medExpire_dateBox.Checked = true;
            this.medExpire_dateBox.FillColor = System.Drawing.Color.MediumPurple;
            this.medExpire_dateBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.medExpire_dateBox.ForeColor = System.Drawing.Color.White;
            this.medExpire_dateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.medExpire_dateBox.Location = new System.Drawing.Point(593, 115);
            this.medExpire_dateBox.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.medExpire_dateBox.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.medExpire_dateBox.Name = "medExpire_dateBox";
            this.medExpire_dateBox.Size = new System.Drawing.Size(346, 36);
            this.medExpire_dateBox.TabIndex = 20;
            this.medExpire_dateBox.Value = new System.DateTime(2024, 9, 23, 20, 46, 46, 573);
            // 
            // medName_txtBox
            // 
            this.medName_txtBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.medName_txtBox.BorderColor = System.Drawing.Color.Black;
            this.medName_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medName_txtBox.DefaultText = "";
            this.medName_txtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.medName_txtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.medName_txtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medName_txtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medName_txtBox.FillColor = System.Drawing.Color.LightSlateGray;
            this.medName_txtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medName_txtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medName_txtBox.ForeColor = System.Drawing.Color.White;
            this.medName_txtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medName_txtBox.Location = new System.Drawing.Point(69, 115);
            this.medName_txtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.medName_txtBox.Name = "medName_txtBox";
            this.medName_txtBox.PasswordChar = '\0';
            this.medName_txtBox.PlaceholderText = "";
            this.medName_txtBox.SelectedText = "";
            this.medName_txtBox.Size = new System.Drawing.Size(346, 38);
            this.medName_txtBox.TabIndex = 21;
            this.medName_txtBox.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // medChem_txtBox
            // 
            this.medChem_txtBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.medChem_txtBox.BorderColor = System.Drawing.Color.Black;
            this.medChem_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medChem_txtBox.DefaultText = "";
            this.medChem_txtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.medChem_txtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.medChem_txtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medChem_txtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medChem_txtBox.FillColor = System.Drawing.Color.LightSlateGray;
            this.medChem_txtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medChem_txtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medChem_txtBox.ForeColor = System.Drawing.Color.White;
            this.medChem_txtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medChem_txtBox.Location = new System.Drawing.Point(69, 235);
            this.medChem_txtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.medChem_txtBox.Name = "medChem_txtBox";
            this.medChem_txtBox.PasswordChar = '\0';
            this.medChem_txtBox.PlaceholderText = "";
            this.medChem_txtBox.SelectedText = "";
            this.medChem_txtBox.Size = new System.Drawing.Size(346, 38);
            this.medChem_txtBox.TabIndex = 22;
            // 
            // medQuantity_txtBox
            // 
            this.medQuantity_txtBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.medQuantity_txtBox.BorderColor = System.Drawing.Color.Black;
            this.medQuantity_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medQuantity_txtBox.DefaultText = "";
            this.medQuantity_txtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.medQuantity_txtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.medQuantity_txtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medQuantity_txtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medQuantity_txtBox.FillColor = System.Drawing.Color.LightSlateGray;
            this.medQuantity_txtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medQuantity_txtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medQuantity_txtBox.ForeColor = System.Drawing.Color.White;
            this.medQuantity_txtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medQuantity_txtBox.Location = new System.Drawing.Point(593, 236);
            this.medQuantity_txtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.medQuantity_txtBox.Name = "medQuantity_txtBox";
            this.medQuantity_txtBox.PasswordChar = '\0';
            this.medQuantity_txtBox.PlaceholderText = "";
            this.medQuantity_txtBox.SelectedText = "";
            this.medQuantity_txtBox.Size = new System.Drawing.Size(346, 38);
            this.medQuantity_txtBox.TabIndex = 23;
            // 
            // medPrice_txtBox
            // 
            this.medPrice_txtBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.medPrice_txtBox.BorderColor = System.Drawing.Color.Black;
            this.medPrice_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medPrice_txtBox.DefaultText = "";
            this.medPrice_txtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.medPrice_txtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.medPrice_txtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medPrice_txtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medPrice_txtBox.FillColor = System.Drawing.Color.LightSlateGray;
            this.medPrice_txtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medPrice_txtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medPrice_txtBox.ForeColor = System.Drawing.Color.White;
            this.medPrice_txtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medPrice_txtBox.Location = new System.Drawing.Point(593, 356);
            this.medPrice_txtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.medPrice_txtBox.Name = "medPrice_txtBox";
            this.medPrice_txtBox.PasswordChar = '\0';
            this.medPrice_txtBox.PlaceholderText = "";
            this.medPrice_txtBox.SelectedText = "";
            this.medPrice_txtBox.Size = new System.Drawing.Size(346, 38);
            this.medPrice_txtBox.TabIndex = 24;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_P_AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.medPrice_txtBox);
            this.Controls.Add(this.medQuantity_txtBox);
            this.Controls.Add(this.medChem_txtBox);
            this.Controls.Add(this.medName_txtBox);
            this.Controls.Add(this.medExpire_dateBox);
            this.Controls.Add(this.medReset_btn);
            this.Controls.Add(this.medAdd_btn);
            this.Controls.Add(this.medManufact_dateBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UC_P_AddMedicine";
            this.Size = new System.Drawing.Size(960, 761);
            this.Load += new System.EventHandler(this.UC_P_AddMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker medManufact_dateBox;
        private Guna.UI2.WinForms.Guna2Button medAdd_btn;
        private Guna.UI2.WinForms.Guna2Button medReset_btn;
        private Guna.UI2.WinForms.Guna2DateTimePicker medExpire_dateBox;
        private Guna.UI2.WinForms.Guna2TextBox medPrice_txtBox;
        private Guna.UI2.WinForms.Guna2TextBox medQuantity_txtBox;
        private Guna.UI2.WinForms.Guna2TextBox medChem_txtBox;
        private Guna.UI2.WinForms.Guna2TextBox medName_txtBox;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
