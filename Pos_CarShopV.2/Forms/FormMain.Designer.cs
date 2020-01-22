namespace Pos_CarShopV._2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.SaleSumButton = new FontAwesome.Sharp.IconButton();
            this.EditProductButton = new FontAwesome.Sharp.IconButton();
            this.CheckStockButton = new FontAwesome.Sharp.IconButton();
            this.AddProductButton = new FontAwesome.Sharp.IconButton();
            this.TradeButton = new FontAwesome.Sharp.IconButton();
            this.MainButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Banner = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.LbTltieChildForm = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.time = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Closeicon = new FontAwesome.Sharp.IconPictureBox();
            this.WindowMaximizeIcon = new FontAwesome.Sharp.IconPictureBox();
            this.WindowMinimizeIcon = new FontAwesome.Sharp.IconPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closeicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowMaximizeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowMinimizeIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.SaleSumButton);
            this.panelMenu.Controls.Add(this.EditProductButton);
            this.panelMenu.Controls.Add(this.CheckStockButton);
            this.panelMenu.Controls.Add(this.AddProductButton);
            this.panelMenu.Controls.Add(this.TradeButton);
            this.panelMenu.Controls.Add(this.MainButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Black;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 648);
            this.panelMenu.TabIndex = 0;
            // 
            // SaleSumButton
            // 
            this.SaleSumButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaleSumButton.FlatAppearance.BorderSize = 0;
            this.SaleSumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaleSumButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SaleSumButton.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleSumButton.ForeColor = System.Drawing.Color.LightGray;
            this.SaleSumButton.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.SaleSumButton.IconColor = System.Drawing.Color.Gainsboro;
            this.SaleSumButton.IconSize = 36;
            this.SaleSumButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaleSumButton.Location = new System.Drawing.Point(0, 440);
            this.SaleSumButton.Name = "SaleSumButton";
            this.SaleSumButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SaleSumButton.Rotation = 0D;
            this.SaleSumButton.Size = new System.Drawing.Size(220, 60);
            this.SaleSumButton.TabIndex = 6;
            this.SaleSumButton.Text = "สรุปการขาย";
            this.SaleSumButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaleSumButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaleSumButton.UseVisualStyleBackColor = true;
            this.SaleSumButton.Click += new System.EventHandler(this.SaleSumButton_Click);
            // 
            // EditProductButton
            // 
            this.EditProductButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditProductButton.FlatAppearance.BorderSize = 0;
            this.EditProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProductButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EditProductButton.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProductButton.ForeColor = System.Drawing.Color.LightGray;
            this.EditProductButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditProductButton.IconColor = System.Drawing.Color.Gainsboro;
            this.EditProductButton.IconSize = 36;
            this.EditProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditProductButton.Location = new System.Drawing.Point(0, 380);
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EditProductButton.Rotation = 0D;
            this.EditProductButton.Size = new System.Drawing.Size(220, 60);
            this.EditProductButton.TabIndex = 5;
            this.EditProductButton.Text = "แก้ไขสินค้า";
            this.EditProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditProductButton.UseVisualStyleBackColor = true;
            this.EditProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // CheckStockButton
            // 
            this.CheckStockButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckStockButton.FlatAppearance.BorderSize = 0;
            this.CheckStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckStockButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CheckStockButton.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckStockButton.ForeColor = System.Drawing.Color.LightGray;
            this.CheckStockButton.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.CheckStockButton.IconColor = System.Drawing.Color.Gainsboro;
            this.CheckStockButton.IconSize = 36;
            this.CheckStockButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckStockButton.Location = new System.Drawing.Point(0, 320);
            this.CheckStockButton.Name = "CheckStockButton";
            this.CheckStockButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CheckStockButton.Rotation = 0D;
            this.CheckStockButton.Size = new System.Drawing.Size(220, 60);
            this.CheckStockButton.TabIndex = 4;
            this.CheckStockButton.Text = "เช็ค Stock";
            this.CheckStockButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckStockButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CheckStockButton.UseVisualStyleBackColor = true;
            this.CheckStockButton.Click += new System.EventHandler(this.CheckStockButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddProductButton.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.ForeColor = System.Drawing.Color.LightGray;
            this.AddProductButton.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.AddProductButton.IconColor = System.Drawing.Color.Gainsboro;
            this.AddProductButton.IconSize = 36;
            this.AddProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddProductButton.Location = new System.Drawing.Point(0, 260);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AddProductButton.Rotation = 0D;
            this.AddProductButton.Size = new System.Drawing.Size(220, 60);
            this.AddProductButton.TabIndex = 3;
            this.AddProductButton.Text = "เพิ่มสินค้า";
            this.AddProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // TradeButton
            // 
            this.TradeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TradeButton.FlatAppearance.BorderSize = 0;
            this.TradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TradeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TradeButton.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradeButton.ForeColor = System.Drawing.Color.LightGray;
            this.TradeButton.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.TradeButton.IconColor = System.Drawing.Color.Gainsboro;
            this.TradeButton.IconSize = 36;
            this.TradeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TradeButton.Location = new System.Drawing.Point(0, 200);
            this.TradeButton.Name = "TradeButton";
            this.TradeButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.TradeButton.Rotation = 0D;
            this.TradeButton.Size = new System.Drawing.Size(220, 60);
            this.TradeButton.TabIndex = 2;
            this.TradeButton.Text = "ซื้อขาย";
            this.TradeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TradeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TradeButton.UseVisualStyleBackColor = true;
            this.TradeButton.Click += new System.EventHandler(this.TradeButton_Click);
            // 
            // MainButton
            // 
            this.MainButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainButton.FlatAppearance.BorderSize = 0;
            this.MainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MainButton.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButton.ForeColor = System.Drawing.Color.LightGray;
            this.MainButton.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.MainButton.IconColor = System.Drawing.Color.Gainsboro;
            this.MainButton.IconSize = 36;
            this.MainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButton.Location = new System.Drawing.Point(0, 140);
            this.MainButton.Name = "MainButton";
            this.MainButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.MainButton.Rotation = 0D;
            this.MainButton.Size = new System.Drawing.Size(220, 60);
            this.MainButton.TabIndex = 1;
            this.MainButton.Text = "หน้าหลัก";
            this.MainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Banner
            // 
            this.Banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.Banner.Image = ((System.Drawing.Image)(resources.GetObject("Banner.Image")));
            this.Banner.Location = new System.Drawing.Point(220, 0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(1271, 92);
            this.Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Banner.TabIndex = 1;
            this.Banner.TabStop = false;
            this.Banner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Banner_MouseDown);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.LbTltieChildForm);
            this.panelTitleBar.Controls.Add(this.date);
            this.panelTitleBar.Controls.Add(this.IconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.time);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 92);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1271, 48);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // LbTltieChildForm
            // 
            this.LbTltieChildForm.AutoSize = true;
            this.LbTltieChildForm.Font = new System.Drawing.Font("Prompt", 14.25F);
            this.LbTltieChildForm.Location = new System.Drawing.Point(60, 9);
            this.LbTltieChildForm.Name = "LbTltieChildForm";
            this.LbTltieChildForm.Size = new System.Drawing.Size(81, 29);
            this.LbTltieChildForm.TabIndex = 1;
            this.LbTltieChildForm.Text = "หน้าหลัก";
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Prompt", 14.25F);
            this.date.Location = new System.Drawing.Point(746, 15);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(55, 29);
            this.date.TabIndex = 2;
            this.date.Text = "Date";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.IconCurrentChildForm.IconSize = 36;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(22, 6);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.IconCurrentChildForm.TabIndex = 0;
            this.IconCurrentChildForm.TabStop = false;
            this.IconCurrentChildForm.Click += new System.EventHandler(this.IconCurrentChildForm_Click);
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Prompt", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(1073, 1);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(95, 49);
            this.time.TabIndex = 1;
            this.time.Text = "Time";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDesktop.Location = new System.Drawing.Point(220, 140);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(944, 508);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(222, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Closeicon
            // 
            this.Closeicon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closeicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Closeicon.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.Closeicon.IconColor = System.Drawing.Color.White;
            this.Closeicon.IconSize = 36;
            this.Closeicon.Location = new System.Drawing.Point(1453, 5);
            this.Closeicon.Name = "Closeicon";
            this.Closeicon.Size = new System.Drawing.Size(32, 32);
            this.Closeicon.TabIndex = 4;
            this.Closeicon.TabStop = false;
            this.Closeicon.Click += new System.EventHandler(this.Closeicon_Click);
            // 
            // WindowMaximizeIcon
            // 
            this.WindowMaximizeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowMaximizeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.WindowMaximizeIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.WindowMaximizeIcon.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.WindowMaximizeIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.WindowMaximizeIcon.IconSize = 36;
            this.WindowMaximizeIcon.Location = new System.Drawing.Point(1415, 5);
            this.WindowMaximizeIcon.Name = "WindowMaximizeIcon";
            this.WindowMaximizeIcon.Size = new System.Drawing.Size(32, 32);
            this.WindowMaximizeIcon.TabIndex = 5;
            this.WindowMaximizeIcon.TabStop = false;
            this.WindowMaximizeIcon.Click += new System.EventHandler(this.WindowMaximizeIcon_Click);
            // 
            // WindowMinimizeIcon
            // 
            this.WindowMinimizeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowMinimizeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.WindowMinimizeIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.WindowMinimizeIcon.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.WindowMinimizeIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.WindowMinimizeIcon.IconSize = 36;
            this.WindowMinimizeIcon.Location = new System.Drawing.Point(1377, 5);
            this.WindowMinimizeIcon.Name = "WindowMinimizeIcon";
            this.WindowMinimizeIcon.Size = new System.Drawing.Size(32, 32);
            this.WindowMinimizeIcon.TabIndex = 6;
            this.WindowMinimizeIcon.TabStop = false;
            this.WindowMinimizeIcon.Click += new System.EventHandler(this.WindowMinimizeIcon_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.cartGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1162, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 508);
            this.panel1.TabIndex = 7;
            // 
            // cartGridView
            // 
            this.cartGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.cartGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.cartGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this.productType,
            this.productName,
            this.brand,
            this.price,
            this.discription});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Prompt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.cartGridView.Location = new System.Drawing.Point(12, 35);
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.Size = new System.Drawing.Size(305, 280);
            this.cartGridView.TabIndex = 6;
            // 
            // _id
            // 
            this._id.DataPropertyName = "Id";
            this._id.HeaderText = "ID สินค้า";
            this._id.Name = "_id";
            this._id.Visible = false;
            // 
            // productType
            // 
            this.productType.DataPropertyName = "productType";
            this.productType.HeaderText = "ประเภทสินค้า";
            this.productType.Name = "productType";
            this.productType.Visible = false;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "ชื่อสินค้า";
            this.productName.Name = "productName";
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "ยี่ห้อ";
            this.brand.Name = "brand";
            this.brand.Visible = false;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "ราคาสินค้า";
            this.price.Name = "price";
            // 
            // discription
            // 
            this.discription.DataPropertyName = "discription";
            this.discription.HeaderText = "รายละเอียดสินค้า";
            this.discription.Name = "discription";
            this.discription.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt", 14.25F);
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "รายการสินค้า";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WindowMinimizeIcon);
            this.Controls.Add(this.WindowMaximizeIcon);
            this.Controls.Add(this.Closeicon);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closeicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowMaximizeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowMinimizeIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton MainButton;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton SaleSumButton;
        private FontAwesome.Sharp.IconButton EditProductButton;
        private FontAwesome.Sharp.IconButton CheckStockButton;
        private FontAwesome.Sharp.IconButton AddProductButton;
        private FontAwesome.Sharp.IconButton TradeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private System.Windows.Forms.Label LbTltieChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox Closeicon;
        private FontAwesome.Sharp.IconPictureBox WindowMaximizeIcon;
        private FontAwesome.Sharp.IconPictureBox WindowMinimizeIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView cartGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productType;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn discription;
    }
}

