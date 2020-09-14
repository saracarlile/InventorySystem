using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Project_1
{
    public class Outsourced : Part
    {

        public string CompanyName { get; set; }

        //constructor
        public Outsourced(int partId, string name,
            decimal price, int inStock, int min, int max, string companyName)
             : base(partId, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }

    }
}
