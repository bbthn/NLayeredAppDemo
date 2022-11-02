namespace Northwind.WebFormsUI
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategry = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.cbxCategoryID = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxUnitStockAdd = new System.Windows.Forms.TextBox();
            this.lnlUnitsinStock = new System.Windows.Forms.Label();
            this.tbxQuantitpUAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxNameAdd = new System.Windows.Forms.TextBox();
            this.lblQuantitperUnit = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.cbxCategoryIdUdp = new System.Windows.Forms.ComboBox();
            this.btnUdp = new System.Windows.Forms.Button();
            this.tbxUnitinStockUdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxQuantityPUnitUdp = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUdp = new System.Windows.Forms.TextBox();
            this.tbxNameUdp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxAddProduct.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 12);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(888, 234);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategry);
            this.gbxCategory.Location = new System.Drawing.Point(12, 252);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(324, 121);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye gore ara:";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(98, 45);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(203, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategry
            // 
            this.lblCategry.AutoSize = true;
            this.lblCategry.Location = new System.Drawing.Point(16, 45);
            this.lblCategry.Name = "lblCategry";
            this.lblCategry.Size = new System.Drawing.Size(76, 16);
            this.lblCategry.TabIndex = 0;
            this.lblCategry.Text = "Categories:";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxName);
            this.gbxProductName.Controls.Add(this.lblName);
            this.gbxProductName.Location = new System.Drawing.Point(444, 252);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(315, 125);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Urun ismine gore ara:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(59, 45);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(203, 22);
            this.tbxName.TabIndex = 2;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.cbxCategoryID);
            this.gbxAddProduct.Controls.Add(this.btnAdd);
            this.gbxAddProduct.Controls.Add(this.tbxUnitStockAdd);
            this.gbxAddProduct.Controls.Add(this.lnlUnitsinStock);
            this.gbxAddProduct.Controls.Add(this.tbxQuantitpUAdd);
            this.gbxAddProduct.Controls.Add(this.tbxUnitPriceAdd);
            this.gbxAddProduct.Controls.Add(this.tbxNameAdd);
            this.gbxAddProduct.Controls.Add(this.lblQuantitperUnit);
            this.gbxAddProduct.Controls.Add(this.lblUnitPrice);
            this.gbxAddProduct.Controls.Add(this.lblCategoryID);
            this.gbxAddProduct.Controls.Add(this.lblProductName);
            this.gbxAddProduct.Location = new System.Drawing.Point(12, 393);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(422, 195);
            this.gbxAddProduct.TabIndex = 3;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Urun Ekle";
            // 
            // cbxCategoryID
            // 
            this.cbxCategoryID.FormattingEnabled = true;
            this.cbxCategoryID.Location = new System.Drawing.Point(122, 82);
            this.cbxCategoryID.Name = "cbxCategoryID";
            this.cbxCategoryID.Size = new System.Drawing.Size(96, 24);
            this.cbxCategoryID.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(313, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxUnitStockAdd
            // 
            this.tbxUnitStockAdd.Location = new System.Drawing.Point(313, 34);
            this.tbxUnitStockAdd.Name = "tbxUnitStockAdd";
            this.tbxUnitStockAdd.Size = new System.Drawing.Size(94, 22);
            this.tbxUnitStockAdd.TabIndex = 9;
            // 
            // lnlUnitsinStock
            // 
            this.lnlUnitsinStock.AutoSize = true;
            this.lnlUnitsinStock.Location = new System.Drawing.Point(242, 37);
            this.lnlUnitsinStock.Name = "lnlUnitsinStock";
            this.lnlUnitsinStock.Size = new System.Drawing.Size(67, 16);
            this.lnlUnitsinStock.TabIndex = 8;
            this.lnlUnitsinStock.Text = "Unit Stock";
            // 
            // tbxQuantitpUAdd
            // 
            this.tbxQuantitpUAdd.Location = new System.Drawing.Point(122, 164);
            this.tbxQuantitpUAdd.Name = "tbxQuantitpUAdd";
            this.tbxQuantitpUAdd.Size = new System.Drawing.Size(96, 22);
            this.tbxQuantitpUAdd.TabIndex = 7;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(122, 124);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(96, 22);
            this.tbxUnitPriceAdd.TabIndex = 6;
            // 
            // tbxNameAdd
            // 
            this.tbxNameAdd.Location = new System.Drawing.Point(122, 31);
            this.tbxNameAdd.Name = "tbxNameAdd";
            this.tbxNameAdd.Size = new System.Drawing.Size(96, 22);
            this.tbxNameAdd.TabIndex = 4;
            // 
            // lblQuantitperUnit
            // 
            this.lblQuantitperUnit.AutoSize = true;
            this.lblQuantitperUnit.Location = new System.Drawing.Point(16, 164);
            this.lblQuantitperUnit.Name = "lblQuantitperUnit";
            this.lblQuantitperUnit.Size = new System.Drawing.Size(104, 16);
            this.lblQuantitperUnit.TabIndex = 3;
            this.lblQuantitperUnit.Text = "Quantity per Unit";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(16, 124);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(64, 16);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(16, 80);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(73, 16);
            this.lblCategoryID.TabIndex = 1;
            this.lblCategoryID.Text = "Kategori ID";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(16, 37);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(62, 16);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Urun ismi";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.cbxCategoryIdUdp);
            this.gbxUpdate.Controls.Add(this.btnUdp);
            this.gbxUpdate.Controls.Add(this.tbxUnitinStockUdp);
            this.gbxUpdate.Controls.Add(this.label1);
            this.gbxUpdate.Controls.Add(this.tbxQuantityPUnitUdp);
            this.gbxUpdate.Controls.Add(this.tbxUnitPriceUdp);
            this.gbxUpdate.Controls.Add(this.tbxNameUdp);
            this.gbxUpdate.Controls.Add(this.label2);
            this.gbxUpdate.Controls.Add(this.label3);
            this.gbxUpdate.Controls.Add(this.label4);
            this.gbxUpdate.Controls.Add(this.label5);
            this.gbxUpdate.Location = new System.Drawing.Point(463, 393);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(422, 195);
            this.gbxUpdate.TabIndex = 4;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Urun Guncelle";
            // 
            // cbxCategoryIdUdp
            // 
            this.cbxCategoryIdUdp.FormattingEnabled = true;
            this.cbxCategoryIdUdp.Location = new System.Drawing.Point(122, 82);
            this.cbxCategoryIdUdp.Name = "cbxCategoryIdUdp";
            this.cbxCategoryIdUdp.Size = new System.Drawing.Size(96, 24);
            this.cbxCategoryIdUdp.TabIndex = 11;
            // 
            // btnUdp
            // 
            this.btnUdp.Location = new System.Drawing.Point(313, 80);
            this.btnUdp.Name = "btnUdp";
            this.btnUdp.Size = new System.Drawing.Size(94, 37);
            this.btnUdp.TabIndex = 10;
            this.btnUdp.Text = "UPDATE";
            this.btnUdp.UseVisualStyleBackColor = true;
            this.btnUdp.Click += new System.EventHandler(this.btnUdp_Click);
            // 
            // tbxUnitinStockUdp
            // 
            this.tbxUnitinStockUdp.Location = new System.Drawing.Point(313, 34);
            this.tbxUnitinStockUdp.Name = "tbxUnitinStockUdp";
            this.tbxUnitinStockUdp.Size = new System.Drawing.Size(94, 22);
            this.tbxUnitinStockUdp.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Unit Stock";
            // 
            // tbxQuantityPUnitUdp
            // 
            this.tbxQuantityPUnitUdp.Location = new System.Drawing.Point(122, 164);
            this.tbxQuantityPUnitUdp.Name = "tbxQuantityPUnitUdp";
            this.tbxQuantityPUnitUdp.Size = new System.Drawing.Size(96, 22);
            this.tbxQuantityPUnitUdp.TabIndex = 7;
            // 
            // tbxUnitPriceUdp
            // 
            this.tbxUnitPriceUdp.Location = new System.Drawing.Point(122, 124);
            this.tbxUnitPriceUdp.Name = "tbxUnitPriceUdp";
            this.tbxUnitPriceUdp.Size = new System.Drawing.Size(96, 22);
            this.tbxUnitPriceUdp.TabIndex = 6;
            // 
            // tbxNameUdp
            // 
            this.tbxNameUdp.Location = new System.Drawing.Point(122, 31);
            this.tbxNameUdp.Name = "tbxNameUdp";
            this.tbxNameUdp.Size = new System.Drawing.Size(96, 22);
            this.tbxNameUdp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity per Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Urun ismi";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(776, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 37);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 624);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategry;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private System.Windows.Forms.TextBox tbxQuantitpUAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.TextBox tbxNameAdd;
        private System.Windows.Forms.Label lblQuantitperUnit;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbxUnitStockAdd;
        private System.Windows.Forms.Label lnlUnitsinStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxCategoryID;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryIdUdp;
        private System.Windows.Forms.Button btnUdp;
        private System.Windows.Forms.TextBox tbxUnitinStockUdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxQuantityPUnitUdp;
        private System.Windows.Forms.TextBox tbxUnitPriceUdp;
        private System.Windows.Forms.TextBox tbxNameUdp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
    }
}

