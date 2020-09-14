using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Project_1
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        //constructor
        public Part(int partId, string name,
            decimal price, int inStock, int min, int max)
        {
            PartID = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

    }
}
