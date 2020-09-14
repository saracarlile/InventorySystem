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
    public partial class AddNewPart : Form
    {

        private bool isInhouse;

        public AddNewPart()
        {
            InitializeComponent();
            idTextBox.Text = Inventory.PartIDGenerator.ToString();

        }

        //input validate before Save button can be enabled
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

            if ((!isInhouse && string.IsNullOrWhiteSpace(machineOrCompanyName.Text) || (isInhouse && !Int32.TryParse(machineOrCompanyName.Text, out number))))
            {
                allowSaveTest = false;
            }
            return allowSaveTest;
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
            savePart.Enabled = allowSave();
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
            savePart.Enabled = allowSave();

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
            savePart.Enabled = allowSave();
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
            savePart.Enabled = allowSave();
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
            savePart.Enabled = allowSave();
        }

        private void machineOrCompanyName_TextChanged(object sender, EventArgs e)
        {
            checkIfInputValid();
        }

        private void inHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

            isInhouse = true;
            machineOrCompany.Text = "Machine ID";
            checkIfInputValid();

        }


        private void outsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            isInhouse = false;
            machineOrCompany.Text = "Company Name";
            checkIfInputValid();
        }


        private void checkIfInputValid()
        {
            //checks to validate machineOrCompanyName field is valid -- if checks pass Save button may be enabled
            int number;

            if (string.IsNullOrWhiteSpace(machineOrCompanyName.Text) || (isInhouse && !Int32.TryParse(machineOrCompanyName.Text, out number)))
            {
                machineOrCompanyName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                machineOrCompanyName.BackColor = System.Drawing.Color.White;
            }

            savePart.Enabled = allowSave();
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

        private void AddNewPart_Load(object sender, EventArgs e)
        {

        }

        private void savePart_Click(object sender, EventArgs e)
        {
            if (isInhouse)
            {
                Part newPart = new Inhouse(Convert.ToInt32(idTextBox.Text),
                    nameTextBox.Text, Convert.ToDecimal(priceTextBox.Text), Convert.ToInt32(inventoryTextBox.Text),
                    Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text), Convert.ToInt32(machineOrCompanyName.Text));

                Inventory.AddPart(newPart);
            }
            else
            {
                Part newOutpart = new Outsourced(Convert.ToInt32(idTextBox.Text),
                    nameTextBox.Text, Convert.ToDecimal(priceTextBox.Text), Convert.ToInt32(inventoryTextBox.Text),
                    Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text), machineOrCompanyName.Text);

                Inventory.AddPart(newOutpart);
            }

            //increase ID number by 1
            Inventory.PartIDGenerator++;

            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void cancelPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
