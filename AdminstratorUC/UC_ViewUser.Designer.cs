namespace PharmacyManagementSystem.AdminstratorUC
{
    partial class UC_ViewUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ViewUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.srch_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminsGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.deleteCust_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pharmacistsGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Pharmacists = new System.Windows.Forms.Label();
            this.customersGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Customers = new System.Windows.Forms.Label();
            this.deleteAdmin_btn = new Guna.UI2.WinForms.Guna2Button();
            this.deletePha_btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacistsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F);
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "View User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // srch_box
            // 
            this.srch_box.BorderColor = System.Drawing.Color.Gray;
            this.srch_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.srch_box.DefaultText = "";
            this.srch_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.srch_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.srch_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.srch_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.srch_box.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.srch_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.srch_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.srch_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.srch_box.Location = new System.Drawing.Point(427, 83);
            this.srch_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.srch_box.Name = "srch_box";
            this.srch_box.PasswordChar = '\0';
            this.srch_box.PlaceholderText = "Search-----------------------------------";
            this.srch_box.SelectedText = "";
            this.srch_box.Size = new System.Drawing.Size(270, 48);
            this.srch_box.TabIndex = 3;
            // 
            // adminsGrid
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.adminsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.adminsGrid.BackgroundColor = System.Drawing.Color.Azure;
            this.adminsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.adminsGrid.ColumnHeadersHeight = 4;
            this.adminsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adminsGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.adminsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.adminsGrid.Location = new System.Drawing.Point(1, 172);
            this.adminsGrid.Name = "adminsGrid";
            this.adminsGrid.RowHeadersVisible = false;
            this.adminsGrid.RowHeadersWidth = 51;
            this.adminsGrid.RowTemplate.Height = 24;
            this.adminsGrid.Size = new System.Drawing.Size(954, 128);
            this.adminsGrid.TabIndex = 4;
            this.adminsGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.adminsGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.adminsGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.adminsGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.adminsGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.adminsGrid.ThemeStyle.BackColor = System.Drawing.Color.Azure;
            this.adminsGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.adminsGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.adminsGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.adminsGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminsGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.adminsGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.adminsGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.adminsGrid.ThemeStyle.ReadOnly = false;
            this.adminsGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.adminsGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.adminsGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminsGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.adminsGrid.ThemeStyle.RowsStyle.Height = 24;
            this.adminsGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.adminsGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.adminsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminsGrid_CellClick);
            this.adminsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button2.Location = new System.Drawing.Point(239, 21);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.White;
            this.guna2Button2.Size = new System.Drawing.Size(34, 35);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(222, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // deleteCust_btn
            // 
            this.deleteCust_btn.BorderRadius = 20;
            this.deleteCust_btn.BorderThickness = 1;
            this.deleteCust_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteCust_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteCust_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteCust_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteCust_btn.FillColor = System.Drawing.Color.Indigo;
            this.deleteCust_btn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCust_btn.ForeColor = System.Drawing.Color.White;
            this.deleteCust_btn.HoverState.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCust_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deleteCust_btn.Image = ((System.Drawing.Image)(resources.GetObject("deleteCust_btn.Image")));
            this.deleteCust_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.deleteCust_btn.Location = new System.Drawing.Point(749, 679);
            this.deleteCust_btn.Name = "deleteCust_btn";
            this.deleteCust_btn.PressedColor = System.Drawing.Color.Lavender;
            this.deleteCust_btn.Size = new System.Drawing.Size(208, 45);
            this.deleteCust_btn.TabIndex = 9;
            this.deleteCust_btn.Text = "Delete Customer";
            this.deleteCust_btn.Click += new System.EventHandler(this.deleteCust_btn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderRadius = 1;
            this.exitBtn.FillColor = System.Drawing.Color.PaleTurquoise;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.exitBtn.Location = new System.Drawing.Point(916, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(41, 39);
            this.exitBtn.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Admins";
            // 
            // pharmacistsGrid
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.pharmacistsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.pharmacistsGrid.BackgroundColor = System.Drawing.Color.Azure;
            this.pharmacistsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pharmacistsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.pharmacistsGrid.ColumnHeadersHeight = 4;
            this.pharmacistsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pharmacistsGrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.pharmacistsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.pharmacistsGrid.Location = new System.Drawing.Point(1, 363);
            this.pharmacistsGrid.Name = "pharmacistsGrid";
            this.pharmacistsGrid.RowHeadersVisible = false;
            this.pharmacistsGrid.RowHeadersWidth = 51;
            this.pharmacistsGrid.RowTemplate.Height = 24;
            this.pharmacistsGrid.Size = new System.Drawing.Size(954, 128);
            this.pharmacistsGrid.TabIndex = 23;
            this.pharmacistsGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.pharmacistsGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.pharmacistsGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.pharmacistsGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.pharmacistsGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.pharmacistsGrid.ThemeStyle.BackColor = System.Drawing.Color.Azure;
            this.pharmacistsGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.pharmacistsGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pharmacistsGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.pharmacistsGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmacistsGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.pharmacistsGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.pharmacistsGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.pharmacistsGrid.ThemeStyle.ReadOnly = false;
            this.pharmacistsGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.pharmacistsGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.pharmacistsGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmacistsGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.pharmacistsGrid.ThemeStyle.RowsStyle.Height = 24;
            this.pharmacistsGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.pharmacistsGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.pharmacistsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pharmacistsGrid_CellClick);
            // 
            // Pharmacists
            // 
            this.Pharmacists.AutoSize = true;
            this.Pharmacists.Font = new System.Drawing.Font("Script MT Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pharmacists.Location = new System.Drawing.Point(3, 338);
            this.Pharmacists.Name = "Pharmacists";
            this.Pharmacists.Size = new System.Drawing.Size(99, 22);
            this.Pharmacists.TabIndex = 24;
            this.Pharmacists.Text = "Pharmacists";
            // 
            // customersGrid
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.customersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.customersGrid.BackgroundColor = System.Drawing.Color.Azure;
            this.customersGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.customersGrid.ColumnHeadersHeight = 4;
            this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersGrid.DefaultCellStyle = dataGridViewCellStyle15;
            this.customersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customersGrid.Location = new System.Drawing.Point(1, 545);
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.RowHeadersVisible = false;
            this.customersGrid.RowHeadersWidth = 51;
            this.customersGrid.RowTemplate.Height = 24;
            this.customersGrid.Size = new System.Drawing.Size(954, 128);
            this.customersGrid.TabIndex = 25;
            this.customersGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.customersGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.customersGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.customersGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.customersGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.customersGrid.ThemeStyle.BackColor = System.Drawing.Color.Azure;
            this.customersGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customersGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.customersGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customersGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.customersGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.customersGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.customersGrid.ThemeStyle.ReadOnly = false;
            this.customersGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.customersGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customersGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.customersGrid.ThemeStyle.RowsStyle.Height = 24;
            this.customersGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customersGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.customersGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersGrid_CellClick);
            // 
            // Customers
            // 
            this.Customers.AutoSize = true;
            this.Customers.Font = new System.Drawing.Font("Script MT Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.Location = new System.Drawing.Point(3, 520);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(83, 22);
            this.Customers.TabIndex = 26;
            this.Customers.Text = "Customers";
            // 
            // deleteAdmin_btn
            // 
            this.deleteAdmin_btn.BorderRadius = 20;
            this.deleteAdmin_btn.BorderThickness = 1;
            this.deleteAdmin_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteAdmin_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteAdmin_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteAdmin_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteAdmin_btn.FillColor = System.Drawing.Color.Indigo;
            this.deleteAdmin_btn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAdmin_btn.ForeColor = System.Drawing.Color.White;
            this.deleteAdmin_btn.HoverState.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAdmin_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deleteAdmin_btn.Image = ((System.Drawing.Image)(resources.GetObject("deleteAdmin_btn.Image")));
            this.deleteAdmin_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.deleteAdmin_btn.Location = new System.Drawing.Point(749, 306);
            this.deleteAdmin_btn.Name = "deleteAdmin_btn";
            this.deleteAdmin_btn.PressedColor = System.Drawing.Color.Lavender;
            this.deleteAdmin_btn.Size = new System.Drawing.Size(206, 45);
            this.deleteAdmin_btn.TabIndex = 27;
            this.deleteAdmin_btn.Text = "Delete Admin";
            this.deleteAdmin_btn.Click += new System.EventHandler(this.deleteAdmin_btn_Click);
            // 
            // deletePha_btn
            // 
            this.deletePha_btn.BorderRadius = 20;
            this.deletePha_btn.BorderThickness = 1;
            this.deletePha_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deletePha_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deletePha_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deletePha_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deletePha_btn.FillColor = System.Drawing.Color.Indigo;
            this.deletePha_btn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePha_btn.ForeColor = System.Drawing.Color.White;
            this.deletePha_btn.HoverState.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePha_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deletePha_btn.Image = ((System.Drawing.Image)(resources.GetObject("deletePha_btn.Image")));
            this.deletePha_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.deletePha_btn.Location = new System.Drawing.Point(749, 494);
            this.deletePha_btn.Name = "deletePha_btn";
            this.deletePha_btn.PressedColor = System.Drawing.Color.Lavender;
            this.deletePha_btn.Size = new System.Drawing.Size(206, 45);
            this.deletePha_btn.TabIndex = 28;
            this.deletePha_btn.Text = "Delete Phamacist";
            this.deletePha_btn.Click += new System.EventHandler(this.deletePha_btn_Click);
            // 
            // UC_ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deletePha_btn);
            this.Controls.Add(this.deleteAdmin_btn);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.customersGrid);
            this.Controls.Add(this.Pharmacists);
            this.Controls.Add(this.pharmacistsGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteCust_btn);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.adminsGrid);
            this.Controls.Add(this.srch_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_ViewUser";
            this.Size = new System.Drawing.Size(960, 761);
            this.Load += new System.EventHandler(this.UC_ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacistsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox srch_box;
        private Guna.UI2.WinForms.Guna2DataGridView adminsGrid;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button deleteCust_btn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private System.Windows.Forms.Label Pharmacists;
        private Guna.UI2.WinForms.Guna2DataGridView pharmacistsGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Customers;
        private Guna.UI2.WinForms.Guna2DataGridView customersGrid;
        private Guna.UI2.WinForms.Guna2Button deletePha_btn;
        private Guna.UI2.WinForms.Guna2Button deleteAdmin_btn;
    }
}
