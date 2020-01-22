namespace Pos_CarShopV._2
{
    partial class Trade
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectTypeBox = new System.Windows.Forms.ComboBox();
            this.DataViewGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectProductBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "ประเภทสินค้า";
            // 
            // SelectTypeBox
            // 
            this.SelectTypeBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SelectTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SelectTypeBox.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTypeBox.ForeColor = System.Drawing.Color.Black;
            this.SelectTypeBox.FormattingEnabled = true;
            this.SelectTypeBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SelectTypeBox.Items.AddRange(new object[] {
            "ของแต่ง",
            "ระบบไฟ",
            "เครื่องยนต์",
            "อุปกรณซ่อมบำรุง",
            "ชุดขับเคลื่อน",
            "ช่วงล่าง",
            "ล้อ / ยางรถ"});
            this.SelectTypeBox.Location = new System.Drawing.Point(42, 36);
            this.SelectTypeBox.Name = "SelectTypeBox";
            this.SelectTypeBox.Size = new System.Drawing.Size(173, 32);
            this.SelectTypeBox.TabIndex = 37;
            this.SelectTypeBox.SelectedIndexChanged += new System.EventHandler(this.SelectTypeBox_SelectedIndexChanged);
            // 
            // DataViewGrid
            // 
            this.DataViewGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataViewGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataViewGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DataViewGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Prompt", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.productType,
            this._productName,
            this.brand,
            this.countProduct,
            this.price,
            this.discription});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Prompt", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataViewGrid.Location = new System.Drawing.Point(12, 74);
            this.DataViewGrid.Name = "DataViewGrid";
            this.DataViewGrid.Size = new System.Drawing.Size(776, 364);
            this.DataViewGrid.TabIndex = 39;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID สินค้า";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // productType
            // 
            this.productType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.productType.DataPropertyName = "productType";
            this.productType.HeaderText = "ประเภทสินค้า";
            this.productType.Name = "productType";
            this.productType.ReadOnly = true;
            this.productType.Width = 121;
            // 
            // _productName
            // 
            this._productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this._productName.DataPropertyName = "productName";
            this._productName.HeaderText = "ชื่อสินค้า";
            this._productName.Name = "_productName";
            this._productName.ReadOnly = true;
            this._productName.Width = 91;
            // 
            // brand
            // 
            this.brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "ยี่ห้อ";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Width = 65;
            // 
            // countProduct
            // 
            this.countProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.countProduct.DataPropertyName = "countProduct";
            this.countProduct.HeaderText = "จำนวนสินค้าที่มี";
            this.countProduct.Name = "countProduct";
            this.countProduct.ReadOnly = true;
            this.countProduct.Width = 137;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "ราคาสินค้า";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 104;
            // 
            // discription
            // 
            this.discription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.discription.DataPropertyName = "discription";
            this.discription.HeaderText = "รายละเอียดสินค้า";
            this.discription.Name = "discription";
            this.discription.ReadOnly = true;
            this.discription.Width = 148;
            // 
            // SelectProductBtn
            // 
            this.SelectProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectProductBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.SelectProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectProductBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SelectProductBtn.Font = new System.Drawing.Font("Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectProductBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.SelectProductBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SelectProductBtn.IconColor = System.Drawing.Color.Black;
            this.SelectProductBtn.IconSize = 16;
            this.SelectProductBtn.Location = new System.Drawing.Point(619, 23);
            this.SelectProductBtn.Name = "SelectProductBtn";
            this.SelectProductBtn.Rotation = 0D;
            this.SelectProductBtn.Size = new System.Drawing.Size(147, 45);
            this.SelectProductBtn.TabIndex = 40;
            this.SelectProductBtn.Text = "เลือกสินค้า";
            this.SelectProductBtn.UseVisualStyleBackColor = false;
            this.SelectProductBtn.Click += new System.EventHandler(this.SelectProductBtn_Click);
            // 
            // Trade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectProductBtn);
            this.Controls.Add(this.DataViewGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectTypeBox);
            this.Name = "Trade";
            this.Text = "Trade";
            ((System.ComponentModel.ISupportInitialize)(this.DataViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectTypeBox;
        private System.Windows.Forms.DataGridView DataViewGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn countProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn discription;
        private FontAwesome.Sharp.IconButton SelectProductBtn;
    }
}