namespace C968_Project_1
{
    partial class AddNewProductScreen
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
            this.AddProductScreenLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.allCandidatePartsDataGridView = new System.Windows.Forms.DataGridView();
            this.PartIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.PartIDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllcandidateParts = new System.Windows.Forms.Label();
            this.searchPartsTextBox = new System.Windows.Forms.TextBox();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            this.addToProductBtn = new System.Windows.Forms.Button();
            this.deleteFromProductBtn = new System.Windows.Forms.Button();
            this.saveProductBtn = new System.Windows.Forms.Button();
            this.cancelProductBtn = new System.Windows.Forms.Button();
            this.searchCandidatePartsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allCandidatePartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductScreenLabel
            // 
            this.AddProductScreenLabel.AutoSize = true;
            this.AddProductScreenLabel.Location = new System.Drawing.Point(13, 13);
            this.AddProductScreenLabel.Name = "AddProductScreenLabel";
            this.AddProductScreenLabel.Size = new System.Drawing.Size(96, 21);
            this.AddProductScreenLabel.TabIndex = 0;
            this.AddProductScreenLabel.Text = "Add Product";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(31, 146);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 21);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 219);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 21);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(17, 279);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(76, 21);
            this.inventoryLabel.TabIndex = 3;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(17, 347);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 21);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(22, 398);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(39, 21);
            this.maxLabel.TabIndex = 5;
            this.maxLabel.Text = "Max";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(104, 138);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(184, 29);
            this.idTextBox.TabIndex = 6;
            this.idTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(104, 211);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(184, 29);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(104, 276);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(184, 29);
            this.inventoryTextBox.TabIndex = 8;
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.inventoryTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(104, 339);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(184, 29);
            this.priceTextBox.TabIndex = 9;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(104, 398);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(90, 29);
            this.maxTextBox.TabIndex = 10;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(212, 401);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(37, 21);
            this.minLabel.TabIndex = 11;
            this.minLabel.Text = "Min";
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(266, 401);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(103, 29);
            this.minTextBox.TabIndex = 12;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // allCandidatePartsDataGridView
            // 
            this.allCandidatePartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allCandidatePartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allCandidatePartsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartIDColumn,
            this.NameColumn,
            this.InventoryColumn,
            this.PriceColumn,
            this.MinColumn,
            this.MaxColumn});
            this.allCandidatePartsDataGridView.Location = new System.Drawing.Point(400, 50);
            this.allCandidatePartsDataGridView.Name = "allCandidatePartsDataGridView";
            this.allCandidatePartsDataGridView.Size = new System.Drawing.Size(609, 250);
            this.allCandidatePartsDataGridView.TabIndex = 13;
            this.allCandidatePartsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allCandidatePartsDataGridView_CellClick);
            // 
            // PartIDColumn
            // 
            this.PartIDColumn.DataPropertyName = "PartID";
            this.PartIDColumn.HeaderText = "Part ID";
            this.PartIDColumn.Name = "PartIDColumn";
            this.PartIDColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // InventoryColumn
            // 
            this.InventoryColumn.DataPropertyName = "InStock";
            this.InventoryColumn.HeaderText = "Inventory";
            this.InventoryColumn.Name = "InventoryColumn";
            this.InventoryColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "Price";
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // MinColumn
            // 
            this.MinColumn.DataPropertyName = "Min";
            this.MinColumn.HeaderText = "Min";
            this.MinColumn.Name = "MinColumn";
            this.MinColumn.ReadOnly = true;
            // 
            // MaxColumn
            // 
            this.MaxColumn.DataPropertyName = "Max";
            this.MaxColumn.HeaderText = "Max";
            this.MaxColumn.Name = "MaxColumn";
            this.MaxColumn.ReadOnly = true;
            // 
            // associatedPartsDataGridView
            // 
            this.associatedPartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartIDC,
            this.NameC,
            this.PriceC,
            this.InventoryC,
            this.MinC,
            this.MaxC});
            this.associatedPartsDataGridView.Location = new System.Drawing.Point(400, 376);
            this.associatedPartsDataGridView.Name = "associatedPartsDataGridView";
            this.associatedPartsDataGridView.Size = new System.Drawing.Size(609, 250);
            this.associatedPartsDataGridView.TabIndex = 14;
            this.associatedPartsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.associatedPartsDataGridView_CellClick);
            // 
            // PartIDC
            // 
            this.PartIDC.DataPropertyName = "PartID";
            this.PartIDC.HeaderText = "Part ID";
            this.PartIDC.Name = "PartIDC";
            this.PartIDC.ReadOnly = true;
            // 
            // NameC
            // 
            this.NameC.DataPropertyName = "Name";
            this.NameC.HeaderText = "Name";
            this.NameC.Name = "NameC";
            this.NameC.ReadOnly = true;
            // 
            // PriceC
            // 
            this.PriceC.DataPropertyName = "Price";
            this.PriceC.HeaderText = "Price";
            this.PriceC.Name = "PriceC";
            this.PriceC.ReadOnly = true;
            // 
            // InventoryC
            // 
            this.InventoryC.DataPropertyName = "InStock";
            this.InventoryC.HeaderText = "Inventory";
            this.InventoryC.Name = "InventoryC";
            this.InventoryC.ReadOnly = true;
            // 
            // MinC
            // 
            this.MinC.DataPropertyName = "Min";
            this.MinC.HeaderText = "Min";
            this.MinC.Name = "MinC";
            this.MinC.ReadOnly = true;
            // 
            // MaxC
            // 
            this.MaxC.DataPropertyName = "Max";
            this.MaxC.HeaderText = "Max";
            this.MaxC.Name = "MaxC";
            this.MaxC.ReadOnly = true;
            // 
            // AllcandidateParts
            // 
            this.AllcandidateParts.AutoSize = true;
            this.AllcandidateParts.Location = new System.Drawing.Point(396, 13);
            this.AllcandidateParts.Name = "AllcandidateParts";
            this.AllcandidateParts.Size = new System.Drawing.Size(137, 21);
            this.AllcandidateParts.TabIndex = 15;
            this.AllcandidateParts.Text = "All candidate Parts";
            // 
            // searchPartsTextBox
            // 
            this.searchPartsTextBox.Location = new System.Drawing.Point(753, 15);
            this.searchPartsTextBox.Name = "searchPartsTextBox";
            this.searchPartsTextBox.Size = new System.Drawing.Size(256, 29);
            this.searchPartsTextBox.TabIndex = 17;
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.AutoSize = true;
            this.associatedPartsLabel.Location = new System.Drawing.Point(396, 339);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(243, 21);
            this.associatedPartsLabel.TabIndex = 18;
            this.associatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // addToProductBtn
            // 
            this.addToProductBtn.Location = new System.Drawing.Point(943, 316);
            this.addToProductBtn.Name = "addToProductBtn";
            this.addToProductBtn.Size = new System.Drawing.Size(66, 44);
            this.addToProductBtn.TabIndex = 19;
            this.addToProductBtn.Text = "Add";
            this.addToProductBtn.UseVisualStyleBackColor = true;
            this.addToProductBtn.Click += new System.EventHandler(this.addToProductBtn_Click);
            // 
            // deleteFromProductBtn
            // 
            this.deleteFromProductBtn.Location = new System.Drawing.Point(943, 641);
            this.deleteFromProductBtn.Name = "deleteFromProductBtn";
            this.deleteFromProductBtn.Size = new System.Drawing.Size(66, 44);
            this.deleteFromProductBtn.TabIndex = 21;
            this.deleteFromProductBtn.Text = "Delete";
            this.deleteFromProductBtn.UseVisualStyleBackColor = true;
            this.deleteFromProductBtn.Click += new System.EventHandler(this.deleteFromProductBtn_Click);
            // 
            // saveProductBtn
            // 
            this.saveProductBtn.Location = new System.Drawing.Point(839, 704);
            this.saveProductBtn.Name = "saveProductBtn";
            this.saveProductBtn.Size = new System.Drawing.Size(66, 44);
            this.saveProductBtn.TabIndex = 22;
            this.saveProductBtn.Text = "Save";
            this.saveProductBtn.UseVisualStyleBackColor = true;
            this.saveProductBtn.Click += new System.EventHandler(this.saveProductBtn_Click);
            // 
            // cancelProductBtn
            // 
            this.cancelProductBtn.Location = new System.Drawing.Point(943, 704);
            this.cancelProductBtn.Name = "cancelProductBtn";
            this.cancelProductBtn.Size = new System.Drawing.Size(66, 44);
            this.cancelProductBtn.TabIndex = 23;
            this.cancelProductBtn.Text = "Cancel";
            this.cancelProductBtn.UseVisualStyleBackColor = true;
            this.cancelProductBtn.Click += new System.EventHandler(this.cancelProductBtn_Click);
            // 
            // searchCandidatePartsBtn
            // 
            this.searchCandidatePartsBtn.Location = new System.Drawing.Point(663, 13);
            this.searchCandidatePartsBtn.Name = "searchCandidatePartsBtn";
            this.searchCandidatePartsBtn.Size = new System.Drawing.Size(75, 30);
            this.searchCandidatePartsBtn.TabIndex = 24;
            this.searchCandidatePartsBtn.Text = "Search";
            this.searchCandidatePartsBtn.UseVisualStyleBackColor = true;
            this.searchCandidatePartsBtn.Click += new System.EventHandler(this.searchCandidatePartsBtn_Click);
            // 
            // AddNewProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 755);
            this.Controls.Add(this.searchCandidatePartsBtn);
            this.Controls.Add(this.cancelProductBtn);
            this.Controls.Add(this.saveProductBtn);
            this.Controls.Add(this.deleteFromProductBtn);
            this.Controls.Add(this.addToProductBtn);
            this.Controls.Add(this.associatedPartsLabel);
            this.Controls.Add(this.searchPartsTextBox);
            this.Controls.Add(this.AllcandidateParts);
            this.Controls.Add(this.associatedPartsDataGridView);
            this.Controls.Add(this.allCandidatePartsDataGridView);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.AddProductScreenLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddNewProductScreen";
            this.Text = "AddNewProductScreen";
            this.Load += new System.EventHandler(this.AddNewProductScreen_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.allCandidatePartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProductScreenLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.DataGridView allCandidatePartsDataGridView;
        private System.Windows.Forms.DataGridView associatedPartsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartIDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceC;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxC;
        private System.Windows.Forms.Label AllcandidateParts;
        private System.Windows.Forms.TextBox searchPartsTextBox;
        private System.Windows.Forms.Label associatedPartsLabel;
        private System.Windows.Forms.Button addToProductBtn;
        private System.Windows.Forms.Button deleteFromProductBtn;
        private System.Windows.Forms.Button saveProductBtn;
        private System.Windows.Forms.Button cancelProductBtn;
        private System.Windows.Forms.Button searchCandidatePartsBtn;
    }
}