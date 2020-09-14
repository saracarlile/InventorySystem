namespace C968_Project_1
{
    partial class ModifyPartScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.CancelModifyParts = new System.Windows.Forms.Button();
            this.inhouseRadioBtn = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioBtn = new System.Windows.Forms.RadioButton();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.machineOrCompanyName = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.machineOrCompanyTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Part";
            // 
            // CancelModifyParts
            // 
            this.CancelModifyParts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelModifyParts.Location = new System.Drawing.Point(560, 384);
            this.CancelModifyParts.Name = "CancelModifyParts";
            this.CancelModifyParts.Size = new System.Drawing.Size(75, 38);
            this.CancelModifyParts.TabIndex = 1;
            this.CancelModifyParts.Text = "Cancel";
            this.CancelModifyParts.UseVisualStyleBackColor = true;
            this.CancelModifyParts.Click += new System.EventHandler(this.CancelModifyParts_Click);
            // 
            // inhouseRadioBtn
            // 
            this.inhouseRadioBtn.AutoSize = true;
            this.inhouseRadioBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inhouseRadioBtn.Location = new System.Drawing.Point(243, 4);
            this.inhouseRadioBtn.Name = "inhouseRadioBtn";
            this.inhouseRadioBtn.Size = new System.Drawing.Size(91, 25);
            this.inhouseRadioBtn.TabIndex = 2;
            this.inhouseRadioBtn.TabStop = true;
            this.inhouseRadioBtn.Text = "In-House";
            this.inhouseRadioBtn.UseVisualStyleBackColor = true;
            this.inhouseRadioBtn.CheckedChanged += new System.EventHandler(this.inhouseRadioBtn_CheckedChanged);
            // 
            // outsourcedRadioBtn
            // 
            this.outsourcedRadioBtn.AutoSize = true;
            this.outsourcedRadioBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsourcedRadioBtn.Location = new System.Drawing.Point(443, 4);
            this.outsourcedRadioBtn.Name = "outsourcedRadioBtn";
            this.outsourcedRadioBtn.Size = new System.Drawing.Size(109, 25);
            this.outsourcedRadioBtn.TabIndex = 3;
            this.outsourcedRadioBtn.TabStop = true;
            this.outsourcedRadioBtn.Text = "Outsourced";
            this.outsourcedRadioBtn.UseVisualStyleBackColor = true;
            this.outsourcedRadioBtn.CheckedChanged += new System.EventHandler(this.outsourcedRadioBtn_CheckedChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(237, 81);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 21);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(237, 131);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 21);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(237, 181);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(89, 21);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price / Cost";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(239, 281);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(39, 21);
            this.maxLabel.TabIndex = 7;
            this.maxLabel.Text = "Max";
            // 
            // machineOrCompanyName
            // 
            this.machineOrCompanyName.AutoSize = true;
            this.machineOrCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineOrCompanyName.Location = new System.Drawing.Point(238, 331);
            this.machineOrCompanyName.Name = "machineOrCompanyName";
            this.machineOrCompanyName.Size = new System.Drawing.Size(88, 21);
            this.machineOrCompanyName.TabIndex = 8;
            this.machineOrCompanyName.Text = "Machine ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(365, 73);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(207, 29);
            this.idTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(365, 125);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(207, 29);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(365, 177);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(207, 29);
            this.priceTextBox.TabIndex = 11;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(239, 231);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(76, 21);
            this.inventoryLabel.TabIndex = 13;
            this.inventoryLabel.Text = "Inventory";
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTextBox.Location = new System.Drawing.Point(365, 229);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(207, 29);
            this.inventoryTextBox.TabIndex = 14;
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.inventoryTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTextBox.Location = new System.Drawing.Point(365, 281);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(93, 29);
            this.maxTextBox.TabIndex = 15;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // machineOrCompanyTextBox
            // 
            this.machineOrCompanyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineOrCompanyTextBox.Location = new System.Drawing.Point(365, 333);
            this.machineOrCompanyTextBox.Name = "machineOrCompanyTextBox";
            this.machineOrCompanyTextBox.Size = new System.Drawing.Size(207, 29);
            this.machineOrCompanyTextBox.TabIndex = 16;
            this.machineOrCompanyTextBox.TextChanged += new System.EventHandler(this.machineOrCompanyTextBox_TextChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(494, 281);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(37, 21);
            this.minLabel.TabIndex = 17;
            this.minLabel.Text = "Min";
            // 
            // minTextBox
            // 
            this.minTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTextBox.Location = new System.Drawing.Point(560, 281);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(93, 29);
            this.minTextBox.TabIndex = 18;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(403, 384);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 38);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ModifyPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.machineOrCompanyTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.machineOrCompanyName);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.outsourcedRadioBtn);
            this.Controls.Add(this.inhouseRadioBtn);
            this.Controls.Add(this.CancelModifyParts);
            this.Controls.Add(this.label1);
            this.Name = "ModifyPartScreen";
            this.Text = "Modify Part";
            this.Load += new System.EventHandler(this.ModifyPartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelModifyParts;
        private System.Windows.Forms.RadioButton inhouseRadioBtn;
        private System.Windows.Forms.RadioButton outsourcedRadioBtn;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label machineOrCompanyName;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox machineOrCompanyTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}