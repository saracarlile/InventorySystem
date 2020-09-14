using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Project_1
{
    public partial class AddNewProductScreen : Form
    {

        private static int indexSelectedAssociatedPart;
        private static int indexSelectedAllParts;
        private BindingList<Part> associatedPartsList = new BindingList<Part>();

        public AddNewProductScreen()
        {
            InitializeComponent();
            idTextBox.Text = Inventory.ProductIDGenerator.ToString();

            indexSelectedAllParts = -1;
            indexSelectedAssociatedPart = -1;
            formatDataGridView(associatedPartsDataGridView);
            formatDataGridView(allCandidatePartsDataGridView);

            associatedPartsDataGridView.DataSource = associatedPartsList;
            allCandidatePartsDataGridView.DataSource = Inventory.AllParts;

        }

        private void formatDataGridView(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = d.DefaultCellStyle.BackColor;
            d.DefaultCellStyle.SelectionForeColor = d.DefaultCellStyle.ForeColor;
            d.RowHeadersVisible = false;
            d.AutoGenerateColumns = false;
        }



        private void addToProductBtn_Click(object sender, EventArgs e)
        {
            int selectedPartID;
            Part selectedPart;

            if (indexSelectedAllParts >= 0)
            {
                selectedPartID = (int)allCandidatePartsDataGridView.Rows[indexSelectedAllParts].Cells[0].Value;
                selectedPart = Inventory.LookupPart(selectedPartID);

                associatedPartsList.Add(selectedPart);

                allCandidatePartsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
                allCandidatePartsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

                indexSelectedAllParts = -1;
            }
            else
            {
                MessageBox.Show("Please select a part to add to the product.");
            }
        }



        private void deleteFromProductBtn_Click(object sender, EventArgs e)
        {
            int selectedAssociatedPartID;
            Part selectedAssociatdPart;

            if (indexSelectedAssociatedPart >= 0)
            {
                selectedAssociatedPartID = (int)associatedPartsDataGridView.Rows[indexSelectedAssociatedPart].Cells[0].Value;
                selectedAssociatdPart = Inventory.LookupPart(selectedAssociatedPartID);

                associatedPartsList.Remove(selectedAssociatdPart);

                associatedPartsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
                associatedPartsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

                indexSelectedAssociatedPart = -1;
            }
            else
            {
                MessageBox.Show("Please select a part to remove from the product.");
            }
        }

        private void saveProductBtn_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product(associatedPartsList, Convert.ToInt32(idTextBox.Text),
                  nameTextBox.Text, Convert.ToDecimal(priceTextBox.Text), Convert.ToInt32(inventoryTextBox.Text),
                    Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text));

            Inventory.AddProduct(newProduct);

            Inventory.ProductIDGenerator++;

            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void cancelProductBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                nameTextBox.BackColor = System.Drawing.Color.White;
            }
            saveProductBtn.Enabled = allowSave();
        }

        private void inventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            int numbertest;

            if (string.IsNullOrWhiteSpace(inventoryTextBox.Text) || !Int32.TryParse(inventoryTextBox.Text, out numbertest))
            {
                inventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                checkInventoryMaxMinFields();
            }
            saveProductBtn.Enabled = allowSave();
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal d;

            if (string.IsNullOrWhiteSpace(priceTextBox.Text) || !decimal.TryParse(priceTextBox.Text, out d))
            {
                priceTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                priceTextBox.BackColor = System.Drawing.Color.White;
            }
            saveProductBtn.Enabled = allowSave();
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            int testnumber;

            //if the box is empty or the value is not an integar, color of textbox is salmon
            if (string.IsNullOrWhiteSpace(maxTextBox.Text) || !Int32.TryParse(maxTextBox.Text, out testnumber))
            {
                maxTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                checkInventoryMaxMinFields();
            }
            saveProductBtn.Enabled = allowSave();
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            int numbertest;

            if (string.IsNullOrWhiteSpace(minTextBox.Text) || !Int32.TryParse(minTextBox.Text, out numbertest))
            {
                minTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {

                checkInventoryMaxMinFields();
            }
            saveProductBtn.Enabled = allowSave();
        }



     
        private void AddNewProductScreen_Load_1(object sender, EventArgs e) {
            saveProductBtn.Enabled = allowSave();
        }

 
        private void allCandidatePartsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSelectedAllParts = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                allCandidatePartsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
                allCandidatePartsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            }
        }

        private void associatedPartsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSelectedAssociatedPart = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                associatedPartsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
                associatedPartsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            }
        }

        private bool allowSave()
        {
            bool allowSaveTest = true;
            decimal d;
            int number;
            int inStockValue;
            int minValue;
            int maxValue;

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                allowSaveTest = false;
            }
            if (!decimal.TryParse(priceTextBox.Text, out d))
            {
                allowSaveTest = false;
            }
            if (!Int32.TryParse(inventoryTextBox.Text, out number))
            {
                allowSaveTest = false;
            }

            //checking to ensure inventory, min, and max are integers and also that inventory <= maxValue and inventory >= minValue
            if (Int32.TryParse(inventoryTextBox.Text, out number))
            {
                inStockValue = Convert.ToInt32(inventoryTextBox.Text);

                if (!Int32.TryParse(minTextBox.Text, out number))
                {
                    allowSaveTest = false;
                }
                else
                {
                    minValue = Convert.ToInt32(minTextBox.Text);
                    if (!Int32.TryParse(inventoryTextBox.Text, out number))
                    {
                        allowSaveTest = false;
                    }
                    else
                    {
                        if (Int32.TryParse(maxTextBox.Text, out number)) // if max value is an int
                        {
                            maxValue = Convert.ToInt32(maxTextBox.Text);

                            if (inStockValue > maxValue || inStockValue < minValue) //check to see if inStock > max or inStock < min
                            {
                                allowSaveTest = false;
                            }
                        }
                        else
                        {
                            allowSaveTest = false;
                        }
                    }
                }
            }
            return allowSaveTest;
        }

        private void checkInventoryMaxMinFields()
        {

            int numbertest;
            int inventory = 0;
            int maxValue = 0;
            int minValue = 0;

            if (Int32.TryParse(maxTextBox.Text, out numbertest) && Int32.TryParse(minTextBox.Text, out numbertest) && Int32.TryParse(inventoryTextBox.Text, out numbertest))
            {
                maxValue = Convert.ToInt32(maxTextBox.Text);
                minValue = Convert.ToInt32(minTextBox.Text);
                inventory = Convert.ToInt32(inventoryTextBox.Text);


                //check if min > max
                if (minValue > maxValue)
                {
                    minTextBox.BackColor = System.Drawing.Color.Salmon;
                }
                else
                {
                    minTextBox.BackColor = System.Drawing.Color.White;
                }

                //check if max < minv
                if (maxValue < minValue)
                {
                    maxTextBox.BackColor = System.Drawing.Color.Salmon;
                }
                else
                {
                    maxTextBox.BackColor = System.Drawing.Color.White;
                }

                //validate inventory field
                if ((inventory < minValue) || (inventory > maxValue))
                {
                    inventoryTextBox.BackColor = System.Drawing.Color.Salmon;
                }
                else
                {
                    inventoryTextBox.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void searchCandidatePartsBtn_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempPartsList = new BindingList<Part>();
            bool found = false;
            if (searchPartsTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(searchPartsTextBox.Text.ToUpper()))
                    {
                        TempPartsList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                {
                    allCandidatePartsDataGridView.DataSource = TempPartsList;
                }
            }
            if (!found)
            {
                MessageBox.Show("No parts found.");
                allCandidatePartsDataGridView.DataSource = Inventory.AllParts;
            }
        }
    }
}
