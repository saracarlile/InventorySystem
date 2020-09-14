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
    public class Inventory
    {

        private static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Product> Products { get { return products; } set { products = value; } }

        private static BindingList<Part> parts = new BindingList<Part>();
        public static BindingList<Part> AllParts { get { return parts; } set { parts = value; } }


        // properties for identifying current part/product selected in datagridviews

        public static Part CurrentPart { get; set; }
        public static int CurrentPartID { get; set; }
        public static int CurrentPartIndex {get; set; }
        public static Product CurrentProduct { get; set; }
        public static int CurrentProductID { get; set; }
        public static int CurrentProductIndex { get; set; }

        //ID generator for Parts and Products (next ID number assignment)
        public static int PartIDGenerator { get; set; }
        public static int ProductIDGenerator { get; set; }



        //add example data for project
        public static void PopulateExampleData()
        {

            var item1 = new Outsourced(0, "Front Wheel", 12.99m, 12, 1, 25, "Scooters and Parts");
            var item2 = new Outsourced(1, "Light-Up Wheel", 25.99m, 4, 1, 10, "Sporting and Leisure Co.");
            var item3 = new Outsourced(2, "Scooter Kickstand", 7.99m, 15, 1, 25, "Best Scooters");
            var item4 = new Inhouse(3, "300 Watt Motor Controller", 87.99m, 3, 1, 12, 124);
            var item5 = new Inhouse(4, "Ignition Module with Keys", 12.99m, 6, 1, 25, 156);

            Inventory.AddPart(item1);
            Inventory.AddPart(item2);
            Inventory.AddPart(item3);
            Inventory.AddPart(item4);
            Inventory.AddPart(item5);


            var productsAssociatedPartsBuild = new BindingList<Part>();
            productsAssociatedPartsBuild.Add(item1);
            productsAssociatedPartsBuild.Add(item2);
            productsAssociatedPartsBuild.Add(item3);

            var productsAssociatedPartsBuildTwo = new BindingList<Part>();
            productsAssociatedPartsBuildTwo.Add(item1);
            productsAssociatedPartsBuildTwo.Add(item4);
            productsAssociatedPartsBuildTwo.Add(item5);

            var productsAssociatedPartsBuildThree = new BindingList<Part>();
            productsAssociatedPartsBuildThree.Add(item1);

            var productsAssociatedPartsBuildFour = new BindingList<Part>();

            Inventory.AddProduct(new Product(productsAssociatedPartsBuild, 0, "Cityglide Scooter", 79.95m, 2, 1, 12));
            Inventory.AddProduct(new Product(productsAssociatedPartsBuildTwo, 1, "Fusion Electric Scooter", 239.95m, 3, 1, 10));
            Inventory.AddProduct(new Product(productsAssociatedPartsBuildThree, 2, "Envy Scooter", 68.99m, 10, 1, 15));
            Inventory.AddProduct(new Product(productsAssociatedPartsBuildFour, 3, "ADO Electric Scooter", 169.95m, 5, 1, 10));              

        }


        public static void AddProduct(Product item)
        {
            try
            {
               Products.Add(item);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        public static bool RemoveProduct(int productID)
        {
            Product foundProduct = LookupProduct(productID);

            if( foundProduct != null)
            {
                Products.Remove(foundProduct);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Product LookupProduct(int productID)
        {
            Product product = Products.SingleOrDefault(p => p.ProductID == productID);

            if (product != null)
            {
                return product;
            }
            else
            {
                return null;
            }     
        }


        public static void updateProduct(int productID, Product productUpdated)
        {
            int index;

            Product currentProduct = LookupProduct(productID);

            if (currentProduct != null)
            {
                index = Products.IndexOf(currentProduct);

                if (index != -1)
                {
                    Products[index] = productUpdated;
                }
            }
        }



        public static void AddPart(Part item)
        {
            try
            {
                AllParts.Add(item);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        public static bool DeletePart(Part item) 
        {
            try
            {
                AllParts.Remove(item);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            
        }

        public static Part LookupPart(int itemID)
        {
            Part item = AllParts.SingleOrDefault(p => p.PartID == itemID);

            if (item != null)
            {
                return item;
            }
            else
            {
                return null;
            }
            
        }


        public static void UpdatePart(int itemID, Part updatedPart)
        {
            int index;

            Part currentPart = LookupPart(itemID);

            if (currentPart != null)
            {
                index = AllParts.IndexOf(currentPart);

                if (index != -1)
                {
                    AllParts[index] = updatedPart;

                }
            }

        }

    }
}
