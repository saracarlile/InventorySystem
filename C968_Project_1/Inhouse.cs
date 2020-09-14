using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Project_1
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }
      
        //constructor
        public Inhouse(int partId, string name, 
            decimal price, int inStock, int min, int max, int machine)
            : base(partId, name,
            price, inStock, min, max)

        {
            MachineID = machine;
        }

    }
}
