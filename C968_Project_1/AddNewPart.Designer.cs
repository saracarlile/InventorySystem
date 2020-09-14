namespace C968_Project_1
{
    partial class AddNewPart
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
            this.addPartScreenLabel = new System.Windows.Forms.Label();
            this.inHouseRadioBtn = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioBtn = new System.Windows.Forms.RadioButton();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.machineOrCompanyName = new System.Windows.Forms.TextBox();
            this.machineOrCompany = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.savePart = new System.Windows.Forms.Button();
            this.cancelPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPartScreenLabel
            // 
            this.addPartScreenLabel.AutoSize = true;
            this.addPartScreenLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartScreenLabel.Location = new System.Drawing.Point(1, 11);
            this.addPartScreenLabel.Name = "addPartScreenLabel";
            this.addPartScreenLabel.Size = new System.Drawing.Size(76, 21);
            this.addPartScreenLabel.TabIndex = 0;
            this.addPartScreenLabel.Text = "Add Part";
            // 
            // inHouseRadioBtn
            // 
            this.inHouseRadioBtn.AutoSize = true;
            this.inHouseRadioBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inHouseRadioBtn.Location = new System.Drawing.Point(243, 4);
            this.inHouseRadioBtn.Name = "inHouseRadioBtn";
            this.inHouseRadioBtn.Size = new System.Drawing.Size(91, 25);
            this.inHouseRadioBtn.TabIndex = 1;
            this.inHouseRadioBtn.TabStop = true;
            this.inHouseRadioBtn.Text = "In-House";
            this.inHouseRadioBtn.UseVisualStyleBackColor = true;
            this.inHouseRadioBtn.CheckedChanged += new System.EventHandler(this.inHouseRadioBtn_CheckedChanged);
            // 
            // outsourcedRadioBtn
            // 
            this.outsourcedRadioBtn.AutoSize = true;
            this.outsourcedRadioBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsourcedRadioBtn.Location = new System.Drawing.Point(443, 4);
            this.outsourcedRadioBtn.Name = "outsourcedRadioBtn";
            this.outsourcedRadioBtn.Size = new System.Drawing.Size(109, 25);
            this.outsourcedRadioBtn.TabIndex = 2;
            this.outsourcedRadioBtn.TabStop = true;
            this.outsourcedRadioBtn.Text = "Outsourced";
            this.outsourcedRadioBtn.UseVisualStyleBackColor = true;
            this.outsourcedRadioBtn.CheckedChanged += new System.EventHandler(this.outsourcedRadioBtn_CheckedChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(239, 73);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 21);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(239, 125);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 21);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(239, 177);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(76, 21);
            this.inventoryLabel.TabIndex = 6;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(235, 232);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(81, 21);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Price/Cost";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(239, 281);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(39, 21);
            this.maxLabel.TabIndex = 8;
            this.maxLabel.Text = "Max";
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTextBox.Location = new System.Drawing.Point(365, 177);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(207, 29);
            this.inventoryTextBox.TabIndex = 9;
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.inventoryTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(365, 229);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(207, 29);
            this.priceTextBox.TabIndex = 10;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTextBox.Location = new System.Drawing.Point(365, 281);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(80, 29);
            this.maxTextBox.TabIndex = 11;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(365, 125);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(207, 29);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(365, 73);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(207, 29);
            this.idTextBox.TabIndex = 13;
            // 
            // machineOrCompanyName
            // 
            this.machineOrCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineOrCompanyName.Location = new System.Drawing.Point(365, 333);
            this.machineOrCompanyName.Name = "machineOrCompanyName";
            this.machineOrCompanyName.Size = new System.Drawing.Size(207, 29);
            this.machineOrCompanyName.TabIndex = 14;
            this.machineOrCompanyName.TextChanged += new System.EventHandler(this.machineOrCompanyName_TextChanged);
            // 
            // machineOrCompany
            // 
            this.machineOrCompany.AutoSize = true;
            this.machineOrCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineOrCompany.Location = new System.Drawing.Point(239, 333);
            this.machineOrCompany.Name = "machineOrCompany";
            this.machineOrCompany.Size = new System.Drawing.Size(88, 21);
            this.machineOrCompany.TabIndex = 15;
            this.machineOrCompany.Text = "Machine ID";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(503, 284);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(37, 21);
            this.minLabel.TabIndex = 16;
            this.minLabel.Text = "Min";
            // 
            // minTextBox
            // 
            this.minTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTextBox.Location = new System.Drawing.Point(560, 281);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(80, 29);
            this.minTextBox.TabIndex = 17;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // savePart
            // 
            this.savePart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePart.Location = new System.Drawing.Point(365, 384);
            this.savePart.Name = "savePart";
            this.savePart.Size = new System.Drawing.Size(80, 36);
            this.savePart.TabIndex = 18;
            this.savePart.Text = "Save";
            this.savePart.UseVisualStyleBackColor = true;
            this.savePart.Click += new System.EventHandler(this.savePart_Click);
            // 
            // cancelPart
            // 
            this.cancelPart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelPart.Location = new System.Drawing.Point(560, 384);
            this.cancelPart.Name = "cancelPart";
            this.cancelPart.Size = new System.Drawing.Size(80, 36);
            this.cancelPart.TabIndex = 19;
            this.cancelPart.Text = "Cancel";
            this.cancelPart.UseVisualStyleBackColor = true;
            this.cancelPart.Click += new System.EventHandler(this.cancelPart_Click);
            // 
            // AddNewPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.cancelPart);
            this.Controls.Add(this.savePart);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.machineOrCompany);
            this.Controls.Add(this.machineOrCompanyName);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.outsourcedRadioBtn);
            this.Controls.Add(this.inHouseRadioBtn);
            this.Controls.Add(this.addPartScreenLabel);
            this.Name = "AddNewPart";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.AddNewPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartScreenLabel;
        private System.Windows.Forms.RadioButton inHouseRadioBtn;
        private System.Windows.Forms.RadioButton outsourcedRadioBtn;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox machineOrCompanyName;
        private System.Windows.Forms.Label machineOrCompany;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Button savePart;
        private System.Windows.Forms.Button cancelPart;
    }
}