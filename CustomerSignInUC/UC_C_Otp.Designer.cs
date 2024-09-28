namespace PharmacyManagementSystem.CustomerSignInUC
{
    partial class UC_C_Otp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_C_Otp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.otpConfirm_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.resendCode_btn = new Guna.UI2.WinForms.Guna2Button();
            this.otpBack_btn = new Guna.UI2.WinForms.Guna2Button();
            this.otp_txt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // otpConfirm_btn
            // 
            this.otpConfirm_btn.BorderRadius = 20;
            this.otpConfirm_btn.BorderThickness = 1;
            this.otpConfirm_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.otpConfirm_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.otpConfirm_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.otpConfirm_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.otpConfirm_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.otpConfirm_btn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpConfirm_btn.ForeColor = System.Drawing.Color.White;
            this.otpConfirm_btn.HoverState.BorderColor = System.Drawing.Color.White;
            this.otpConfirm_btn.HoverState.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpConfirm_btn.Location = new System.Drawing.Point(335, 480);
            this.otpConfirm_btn.Name = "otpConfirm_btn";
            this.otpConfirm_btn.Size = new System.Drawing.Size(180, 45);
            this.otpConfirm_btn.TabIndex = 2;
            this.otpConfirm_btn.Text = "Confirm";
            this.otpConfirm_btn.Click += new System.EventHandler(this.otpConfirm_btn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // resendCode_btn
            // 
            this.resendCode_btn.BackColor = System.Drawing.Color.Transparent;
            this.resendCode_btn.BorderRadius = 25;
            this.resendCode_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resendCode_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resendCode_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resendCode_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resendCode_btn.FillColor = System.Drawing.Color.Transparent;
            this.resendCode_btn.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Bold);
            this.resendCode_btn.ForeColor = System.Drawing.Color.DarkBlue;
            this.resendCode_btn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.resendCode_btn.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.resendCode_btn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.resendCode_btn.HoverState.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resendCode_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.resendCode_btn.Location = new System.Drawing.Point(204, 531);
            this.resendCode_btn.Name = "resendCode_btn";
            this.resendCode_btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.resendCode_btn.PressedDepth = 20;
            this.resendCode_btn.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.resendCode_btn.Size = new System.Drawing.Size(229, 39);
            this.resendCode_btn.TabIndex = 8;
            this.resendCode_btn.Text = "Resend Code";
            this.resendCode_btn.Click += new System.EventHandler(this.resendCode_btn_Click);
            // 
            // otpBack_btn
            // 
            this.otpBack_btn.BorderRadius = 20;
            this.otpBack_btn.BorderThickness = 1;
            this.otpBack_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.otpBack_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.otpBack_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.otpBack_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.otpBack_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.otpBack_btn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpBack_btn.ForeColor = System.Drawing.Color.White;
            this.otpBack_btn.HoverState.BorderColor = System.Drawing.Color.White;
            this.otpBack_btn.HoverState.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpBack_btn.Location = new System.Drawing.Point(134, 480);
            this.otpBack_btn.Name = "otpBack_btn";
            this.otpBack_btn.Size = new System.Drawing.Size(180, 45);
            this.otpBack_btn.TabIndex = 9;
            this.otpBack_btn.Text = "Back";
            this.otpBack_btn.Click += new System.EventHandler(this.otpBack_btn_Click);
            // 
            // otp_txt
            // 
            this.otp_txt.BorderColor = System.Drawing.Color.Gray;
            this.otp_txt.BorderRadius = 10;
            this.otp_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.otp_txt.DefaultText = "";
            this.otp_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.otp_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.otp_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.otp_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.otp_txt.FillColor = System.Drawing.Color.Gray;
            this.otp_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.otp_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.otp_txt.ForeColor = System.Drawing.Color.Black;
            this.otp_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.otp_txt.Location = new System.Drawing.Point(204, 425);
            this.otp_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.otp_txt.Name = "otp_txt";
            this.otp_txt.PasswordChar = '\0';
            this.otp_txt.PlaceholderForeColor = System.Drawing.Color.White;
            this.otp_txt.PlaceholderText = "Type Your OTP\r\n";
            this.otp_txt.SelectedText = "";
            this.otp_txt.Size = new System.Drawing.Size(229, 48);
            this.otp_txt.TabIndex = 0;
            // 
            // UC_C_Otp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.otpBack_btn);
            this.Controls.Add(this.resendCode_btn);
            this.Controls.Add(this.otpConfirm_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.otp_txt);
            this.Name = "UC_C_Otp";
            this.Size = new System.Drawing.Size(676, 586);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button otpConfirm_btn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button resendCode_btn;
        private Guna.UI2.WinForms.Guna2Button otpBack_btn;
        private Guna.UI2.WinForms.Guna2TextBox otp_txt;
    }
}
