using System.Drawing;

namespace C968_Project_1
{
    partial class MainForm
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
            this.AppName = new System.Windows.Forms.Label();
            this.partsDataViewGrid = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchAllParts = new System.Windows.Forms.Button();
            this.searchPartsTextBox = new System.Windows.Forms.TextBox();
            this.allPartsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.searchProducts = new System.Windows.Forms.Button();
            this.searchProductsTextBox = new System.Windows.Forms.TextBox();
            this.addPart = new System.Windows.Forms.Button();
            this.modifyPart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.exitProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.Location = new System.Drawing.Point(15, 18);
            this.AppName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(291, 25);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "Inventory Management System";
            // 
            // partsDataViewGrid
            // 
            this.partsDataViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsDataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.Description,
            this.InStock,
            this.Price,
            this.PartMin,
            this.PartMax});
            this.partsDataViewGrid.Location = new System.Drawing.Point(12, 130);
            this.partsDataViewGrid.Name = "partsDataViewGrid";
            this.partsDataViewGrid.Size = new System.Drawing.Size(587, 311);
            this.partsDataViewGrid.TabIndex = 1;
            this.partsDataViewGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsDataViewGrid_CellClick);
            this.partsDataViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsDataViewGrid_CellContentClick);
            // 
            // PartID
            // 
            this.PartID.DataPropertyName = "PartID";
            this.PartID.HeaderText = "Part ID";
            this.PartID.Name = "PartID";
            this.PartID.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Name";
            this.Description.HeaderText = "Name";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // InStock
            // 
            this.InStock.DataPropertyName = "InStock";
            this.InStock.HeaderText = "Inventory";
            this.InStock.Name = "InStock";
            this.InStock.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // PartMin
            // 
            this.PartMin.DataPropertyName = "Min";
            this.PartMin.HeaderText = "Min";
            this.PartMin.Name = "PartMin";
            this.PartMin.ReadOnly = true;
            // 
            // PartMax
            // 
            this.PartMax.DataPropertyName = "Max";
            this.PartMax.HeaderText = "Max";
            this.PartMax.Name = "PartMax";
            this.PartMax.ReadOnly = true;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductDescription,
            this.productInStock,
            this.productPrice,
            this.propertyMin,
            this.productMax});
            this.productsDataGridView.Location = new System.Drawing.Point(626, 130);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(591, 311);
            this.productsDataGridView.TabIndex = 2;
            this.productsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellClick);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductDescription
            // 
            this.ProductDescription.DataPropertyName = "Name";
            this.ProductDescription.HeaderText = "Name";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            // 
            // productInStock
            // 
            this.productInStock.DataPropertyName = "InStock";
            this.productInStock.HeaderText = "Inventory";
            this.productInStock.Name = "productInStock";
            this.productInStock.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.DataPropertyName = "Price";
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // propertyMin
            // 
            this.propertyMin.DataPropertyName = "Min";
            this.propertyMin.HeaderText = "Min";
            this.propertyMin.Name = "propertyMin";
            this.propertyMin.ReadOnly = true;
            // 
            // productMax
            // 
            this.productMax.DataPropertyName = "Max";
            this.productMax.HeaderText = "Max";
            this.productMax.Name = "productMax";
            this.productMax.ReadOnly = true;
            // 
            // searchAllParts
            // 
            this.searchAllParts.Location = new System.Drawing.Point(296, 91);
            this.searchAllParts.Name = "searchAllParts";
            this.searchAllParts.Size = new System.Drawing.Size(90, 33);
            this.searchAllParts.TabIndex = 3;
            this.searchAllParts.Text = "Search";
            this.searchAllParts.UseVisualStyleBackColor = true;
            this.searchAllParts.Click += new System.EventHandler(this.searchAllParts_Click);
            // 
            // searchPartsTextBox
            // 
            this.searchPartsTextBox.Location = new System.Drawing.Point(401, 92);
            this.searchPartsTextBox.Name = "searchPartsTextBox";
            this.searchPartsTextBox.Size = new System.Drawing.Size(200, 33);
            this.searchPartsTextBox.TabIndex = 4;
            // 
            // allPartsLabel
            // 
            this.allPartsLabel.AutoSize = true;
            this.allPartsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPartsLabel.Location = new System.Drawing.Point(15, 91);
            this.allPartsLabel.Name = "allPartsLabel";
            this.allPartsLabel.Size = new System.Drawing.Size(58, 25);
            this.allPartsLabel.TabIndex = 5;
            this.allPartsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(621, 91);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(92, 25);
            this.productsLabel.TabIndex = 7;
            this.productsLabel.Text = "Produtcs";
            // 
            // searchProducts
            // 
            this.searchProducts.Location = new System.Drawing.Point(900, 90);
            this.searchProducts.Name = "searchProducts";
            this.searchProducts.Size = new System.Drawing.Size(90, 33);
            this.searchProducts.TabIndex = 8;
            this.searchProducts.Text = "Search";
            this.searchProducts.UseVisualStyleBackColor = true;
            this.searchProducts.Click += new System.EventHandler(this.searchProducts_Click);
            // 
            // searchProductsTextBox
            // 
            this.searchProductsTextBox.Location = new System.Drawing.Point(1007, 91);
            this.searchProductsTextBox.Name = "searchProductsTextBox";
            this.searchProductsTextBox.Size = new System.Drawing.Size(210, 33);
            this.searchProductsTextBox.TabIndex = 9;
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(335, 457);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(81, 44);
            this.addPart.TabIndex = 10;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // modifyPart
            // 
            this.modifyPart.Location = new System.Drawing.Point(422, 457);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(81, 44);
            this.modifyPart.TabIndex = 11;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            this.modifyPart.Click += new System.EventHandler(this.modifyPart_Click);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(518, 457);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(81, 44);
            this.deletePart.TabIndex = 12;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(952, 457);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(88, 44);
            this.addProduct.TabIndex = 13;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(1046, 457);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(81, 44);
            this.modifyProduct.TabIndex = 14;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(1136, 457);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(81, 44);
            this.deleteProduct.TabIndex = 15;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // exitProgram
            // 
            this.exitProgram.Location = new System.Drawing.Point(1136, 522);
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(81, 44);
            this.exitProgram.TabIndex = 16;
            this.exitProgram.Text = "Exit";
            this.exitProgram.UseVisualStyleBackColor = true;
            this.exitProgram.Click += new System.EventHandler(this.exitProgram_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 579);
            this.Controls.Add(this.exitProgram);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.modifyProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.modifyPart);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.searchProductsTextBox);
            this.Controls.Add(this.searchProducts);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.allPartsLabel);
            this.Controls.Add(this.searchPartsTextBox);
            this.Controls.Add(this.searchAllParts);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.partsDataViewGrid);
            this.Controls.Add(this.AppName);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.partsDataViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.DataGridView partsDataViewGrid;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Button searchAllParts;
        private System.Windows.Forms.TextBox searchPartsTextBox;
        private System.Windows.Forms.Label allPartsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn productInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMax;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button searchProducts;
        private System.Windows.Forms.TextBox searchProductsTextBox;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button modifyPart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button exitProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartMax;
    }
}

