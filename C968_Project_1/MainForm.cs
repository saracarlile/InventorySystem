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
    public partial class MainForm : Form

    {
        private static int indexSelectedParts;
        private static int indexSelectProducts;


        private void formatDataGridView(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = d.DefaultCellStyle.BackColor;
            d.DefaultCellStyle.SelectionForeColor = d.DefaultCellStyle.ForeColor;
            d.RowHeadersVisible = false;
            d.AutoGenerateColumns = false;
        }



        public MainForm()
        {
            InitializeComponent();
            indexSelectedParts = -1;
            indexSelectProducts = -1;
            formatDataGridView(partsDataViewGrid);
            formatDataGridView(productsDataGridView);
            partsDataViewGrid.DataSource = Inventory.AllParts;
            productsDataGridView.DataSource = Inventory.Products;

        }


        private void partsDataViewGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSelectedParts = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                Inventory.CurrentPartID = (int)partsDataViewGrid.Rows[indexSelectedParts].Cells[0].Value;
                Inventory.CurrentPart = Inventory.LookupPart(Inventory.CurrentPartID);

                partsDataViewGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
                partsDataViewGrid.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            }
        }

        private void addPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewPart addPartScreen = new AddNewPart();
            addPartScreen.Show();
        }

        private void modifyPart_Click(object sender, EventArgs e)
        {
            if (indexSelectedParts >= 0)
            {
                this.Hide();
                ModifyPartScreen modifyPartScreen = new ModifyPartScreen();
                modifyPartScreen.Show();
            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }

        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            if (indexSelectedParts >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this part?",
                                     "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    Inventory.DeletePart(Inventory.CurrentPart);
                }
                else
                {
                    MessageBox.Show("Part deletion cancelled.");
                }

            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }

            indexSelectedParts = -1;
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewProductScreen addNewProductScreen = new AddNewProductScreen();
            addNewProductScreen.Show();
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {

            if (indexSelectProducts >= 0)
            {
                this.Hide();
                ModifyProductsScreen modifyProductsScreen = new ModifyProductsScreen();
                modifyProductsScreen.Show();
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }

        }

        private void MainForm_Load_1(object sender, EventArgs e) { }

        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            indexSelectProducts = e.RowIndex;
            if(e.RowIndex >= 0)
            {
                Inventory.CurrentProductID = (int)productsDataGridView.Rows[indexSelectProducts].Cells[0].Value;
                Inventory.CurrentProduct = Inventory.LookupProduct(Inventory.CurrentProductID);

                productsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
                productsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            }
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {

            BindingList<Part> bindingListTest;

            if (indexSelectProducts >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this part?",
                                     "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {

                    bindingListTest = Inventory.CurrentProduct.GetAssociatedParts();

                    if (bindingListTest.Count < 1)
                    {
                        Inventory.RemoveProduct(Inventory.CurrentProductID);
                    }
                    else
                    {
                        MessageBox.Show("You cannot delete a product with parts associated with it.  Delete the associated parts first, then delete product.");
                    }


                }
                else
                {
                    MessageBox.Show("Part deletion cancelled.");
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }

            formatDataGridView(productsDataGridView);
            indexSelectProducts = -1;
        }

        private void partsDataViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchAllParts_Click(object sender, EventArgs e)
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
                    partsDataViewGrid.DataSource = TempPartsList;
                }
            }
            if (!found)
            {
                MessageBox.Show("No parts found.");
                partsDataViewGrid.DataSource = Inventory.AllParts;
                formatDataGridView(partsDataViewGrid);
            }
        }

        private void searchProducts_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempProductsList = new BindingList<Product>();
            bool found = false;
            if (searchProductsTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(searchProductsTextBox.Text.ToUpper()))
                    {
                        TempProductsList.Add(Inventory.Products[i]);
                        found = true;
                    }
                }

                if (found)
                {
                    productsDataGridView.DataSource = TempProductsList;
                }
            }
            if (!found)
            {
                MessageBox.Show("No products found.");
                productsDataGridView.DataSource = Inventory.Products;
                formatDataGridView(productsDataGridView);
            }
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
