namespace PharmacyManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passTextField = new Guna.UI2.WinForms.Guna2TextBox();
            this.userNameTxtField = new Guna.UI2.WinForms.Guna2TextBox();
            this.resetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.medicinePicture_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.medicinePicture_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 578);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jokerman", 13.8F);
            this.label3.Location = new System.Drawing.Point(92, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.passTextField);
            this.panel1.Controls.Add(this.userNameTxtField);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(102, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 475);
            this.panel1.TabIndex = 3;
            // 
            // passTextField
            // 
            this.passTextField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTextField.DefaultText = "";
            this.passTextField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTextField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTextField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTextField.DisabledState.Parent = this.passTextField;
            this.passTextField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTextField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextField.FocusedState.Parent = this.passTextField;
            this.passTextField.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextField.HoverState.Parent = this.passTextField;
            this.passTextField.Location = new System.Drawing.Point(122, 285);
            this.passTextField.Margin = new System.Windows.Forms.Padding(8, 16, 8, 16);
            this.passTextField.Name = "passTextField";
            this.passTextField.PasswordChar = '*';
            this.passTextField.PlaceholderText = "";
            this.passTextField.SelectedText = "";
            this.passTextField.ShadowDecoration.Parent = this.passTextField;
            this.passTextField.Size = new System.Drawing.Size(318, 43);
            this.passTextField.TabIndex = 6;
            this.passTextField.TextChanged += new System.EventHandler(this.passTextField_TextChanged);
            // 
            // userNameTxtField
            // 
            this.userNameTxtField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxtField.DefaultText = "";
            this.userNameTxtField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTxtField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTxtField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTxtField.DisabledState.Parent = this.userNameTxtField;
            this.userNameTxtField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTxtField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTxtField.FocusedState.Parent = this.userNameTxtField;
            this.userNameTxtField.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxtField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTxtField.HoverState.Parent = this.userNameTxtField;
            this.userNameTxtField.Location = new System.Drawing.Point(122, 150);
            this.userNameTxtField.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userNameTxtField.Name = "userNameTxtField";
            this.userNameTxtField.PasswordChar = '\0';
            this.userNameTxtField.PlaceholderText = "";
            this.userNameTxtField.SelectedText = "";
            this.userNameTxtField.ShadowDecoration.Parent = this.userNameTxtField;
            this.userNameTxtField.Size = new System.Drawing.Size(318, 43);
            this.userNameTxtField.TabIndex = 5;
            // 
            // resetBtn
            // 
            this.resetBtn.BorderRadius = 19;
            this.resetBtn.BorderThickness = 1;
            this.resetBtn.CheckedState.Parent = this.resetBtn;
            this.resetBtn.CustomImages.Parent = this.resetBtn;
            this.resetBtn.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.HoverState.BorderColor = System.Drawing.Color.Black;
            this.resetBtn.HoverState.FillColor = System.Drawing.Color.White;
            this.resetBtn.HoverState.ForeColor = System.Drawing.Color.Aqua;
            this.resetBtn.HoverState.Parent = this.resetBtn;
            this.resetBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetBtn.Image")));
            this.resetBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.resetBtn.Location = new System.Drawing.Point(314, 371);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.ShadowDecoration.Parent = this.resetBtn;
            this.resetBtn.Size = new System.Drawing.Size(180, 45);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BorderRadius = 19;
            this.loginBtn.BorderThickness = 1;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.BorderColor = System.Drawing.Color.Black;
            this.loginBtn.HoverState.FillColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.ForeColor = System.Drawing.Color.Aqua;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Image = ((System.Drawing.Image)(resources.GetObject("loginBtn.Image")));
            this.loginBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.loginBtn.Location = new System.Drawing.Point(98, 371);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(180, 45);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BorderRadius = 1;
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.PaleTurquoise;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoverState.Parent = this.exitBtn;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.exitBtn.Location = new System.Drawing.Point(1338, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(42, 40);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // medicinePicture_panel
            // 
            this.medicinePicture_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("medicinePicture_panel.BackgroundImage")));
            this.medicinePicture_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.medicinePicture_panel.Controls.Add(this.panel1);
            this.medicinePicture_panel.Location = new System.Drawing.Point(690, 0);
            this.medicinePicture_panel.Name = "medicinePicture_panel";
            this.medicinePicture_panel.Size = new System.Drawing.Size(690, 761);
            this.medicinePicture_panel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 761);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.medicinePicture_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.medicinePicture_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2TextBox passTextField;
        private Guna.UI2.WinForms.Guna2TextBox userNameTxtField;
        private Guna.UI2.WinForms.Guna2Button resetBtn;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private System.Windows.Forms.Panel medicinePicture_panel;
    }
}