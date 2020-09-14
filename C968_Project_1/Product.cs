using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace C968_Project_1
{
    public class Product
    {

        private BindingList<Part> associatedParts = new BindingList<Part>();
        public BindingList<Part> AssociatedParts { get { return associatedParts; } set { associatedParts = value; } }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        //constructor

        public Product(BindingList<Part> associatedPart, int productID,
            string name, decimal price, int inStock, int min, int max)
        {
            AssociatedParts = associatedPart;
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part item)
        {
            try
            {
                AssociatedParts.Add(item);
            }
            catch (Exception E)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        public bool RemoveAssociatedPart(int itemID)
        {
            Part findItem = LookupAssociatedPart(itemID);

            if (findItem != null)
            {
                AssociatedParts.Remove(findItem);
                return true;
            }
            else
            {
                return false;
            }
        }


        public Part LookupAssociatedPart(int itemID)
        {
            Part item = AssociatedParts.SingleOrDefault(p => p.PartID == itemID);
            if (item != null)
            {
                return item;
            }
            return null;
        }


        public BindingList<Part> GetAssociatedParts()
        {
                return associatedParts;   
        }

    }
}
