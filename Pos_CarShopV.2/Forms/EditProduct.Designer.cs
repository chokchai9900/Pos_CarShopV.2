namespace Pos_CarShopV._2
{
    partial class EditProduct
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
            this.SelectItemBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditNameBox = new System.Windows.Forms.TextBox();
            this.EditBrandBox = new System.Windows.Forms.TextBox();
            this.EditDiscriptionBox = new System.Windows.Forms.TextBox();
            this.EditcountBox = new System.Windows.Forms.NumericUpDown();
            this.EditPriceBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.EditTypeProductBox = new System.Windows.Forms.ComboBox();
            this.EditProductBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.EditcountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditPriceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectItemBox
            // 
            this.SelectItemBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectItemBox.Font = new System.Drawing.Font("Prompt", 12F);
            this.SelectItemBox.FormattingEnabled = true;
            this.SelectItemBox.Location = new System.Drawing.Point(565, 36);
            this.SelectItemBox.Name = "SelectItemBox";
            this.SelectItemBox.Size = new System.Drawing.Size(181, 32);
            this.SelectItemBox.TabIndex = 0;
            this.SelectItemBox.SelectedIndexChanged += new System.EventHandler(this.SelectItemBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(604, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "เลือกสินค้าเพื่อแก้ไข";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(37, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "ราคาสินค้า";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(38, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "ยี่ห้อ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(35, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "คำอธิบายสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(37, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "จำนวนสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "ชื่อสินค้า";
            // 
            // EditNameBox
            // 
            this.EditNameBox.Font = new System.Drawing.Font("Prompt", 12F);
            this.EditNameBox.Location = new System.Drawing.Point(71, 113);
            this.EditNameBox.Name = "EditNameBox";
            this.EditNameBox.Size = new System.Drawing.Size(181, 32);
            this.EditNameBox.TabIndex = 30;
            // 
            // EditBrandBox
            // 
            this.EditBrandBox.Font = new System.Drawing.Font("Prompt", 12F);
            this.EditBrandBox.Location = new System.Drawing.Point(71, 175);
            this.EditBrandBox.Name = "EditBrandBox";
            this.EditBrandBox.Size = new System.Drawing.Size(181, 32);
            this.EditBrandBox.TabIndex = 31;
            // 
            // EditDiscriptionBox
            // 
            this.EditDiscriptionBox.Font = new System.Drawing.Font("Prompt", 12F);
            this.EditDiscriptionBox.Location = new System.Drawing.Point(71, 373);
            this.EditDiscriptionBox.Name = "EditDiscriptionBox";
            this.EditDiscriptionBox.Size = new System.Drawing.Size(362, 32);
            this.EditDiscriptionBox.TabIndex = 32;
            // 
            // EditcountBox
            // 
            this.EditcountBox.DecimalPlaces = 1;
            this.EditcountBox.Font = new System.Drawing.Font("Prompt", 12F);
            this.EditcountBox.Location = new System.Drawing.Point(71, 246);
            this.EditcountBox.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.EditcountBox.Name = "EditcountBox";
            this.EditcountBox.Size = new System.Drawing.Size(120, 32);
            this.EditcountBox.TabIndex = 33;
            // 
            // EditPriceBox
            // 
            this.EditPriceBox.DecimalPlaces = 1;
            this.EditPriceBox.Font = new System.Drawing.Font("Prompt", 12F);
            this.EditPriceBox.Location = new System.Drawing.Point(71, 311);
            this.EditPriceBox.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.EditPriceBox.Name = "EditPriceBox";
            this.EditPriceBox.Size = new System.Drawing.Size(120, 32);
            this.EditPriceBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "ประเภทสินค้า";
            // 
            // EditTypeProductBox
            // 
            this.EditTypeProductBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.EditTypeProductBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditTypeProductBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EditTypeProductBox.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTypeProductBox.ForeColor = System.Drawing.Color.Black;
            this.EditTypeProductBox.FormattingEnabled = true;
            this.EditTypeProductBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.EditTypeProductBox.Items.AddRange(new object[] {
            "ของแต่ง",
            "ระบบไฟ",
            "เครื่องยนต์",
            "อุปกรณซ่อมบำรุง",
            "ชุดขับเคลื่อน",
            "ช่วงล่าง",
            "ล้อ / ยางรถ"});
            this.EditTypeProductBox.Location = new System.Drawing.Point(71, 47);
            this.EditTypeProductBox.Name = "EditTypeProductBox";
            this.EditTypeProductBox.Size = new System.Drawing.Size(121, 32);
            this.EditTypeProductBox.TabIndex = 35;
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.EditProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProductBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EditProductBtn.Font = new System.Drawing.Font("Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProductBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.EditProductBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EditProductBtn.IconColor = System.Drawing.Color.Black;
            this.EditProductBtn.IconSize = 16;
            this.EditProductBtn.Location = new System.Drawing.Point(627, 373);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Rotation = 0D;
            this.EditProductBtn.Size = new System.Drawing.Size(147, 45);
            this.EditProductBtn.TabIndex = 37;
            this.EditProductBtn.Text = "แก้ไขสินค้า";
            this.EditProductBtn.UseVisualStyleBackColor = false;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditProductBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditTypeProductBox);
            this.Controls.Add(this.EditPriceBox);
            this.Controls.Add(this.EditcountBox);
            this.Controls.Add(this.EditDiscriptionBox);
            this.Controls.Add(this.EditBrandBox);
            this.Controls.Add(this.EditNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SelectItemBox);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditcountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditPriceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectItemBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditNameBox;
        private System.Windows.Forms.TextBox EditBrandBox;
        private System.Windows.Forms.TextBox EditDiscriptionBox;
        private System.Windows.Forms.NumericUpDown EditcountBox;
        private System.Windows.Forms.NumericUpDown EditPriceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EditTypeProductBox;
        private FontAwesome.Sharp.IconButton EditProductBtn;
    }
}