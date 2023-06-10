using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.BL
{
    class product
    {
        public product(string Name, string Cat, int Pri)
        {
            name = Name;
            category = Cat;
            price = Pri;
        }
        public string name;
        public string category;
        public int price;
        
       
        public float CalculateTax()
        {
            float tax=0;
            tax = (10 / 100) * price;
            return tax;
        }
    }
}
