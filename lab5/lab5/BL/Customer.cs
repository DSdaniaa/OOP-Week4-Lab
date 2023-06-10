using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.BL
{
    class Customer
    {
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerContact;
        List<product> products = new List<product>();
        
        public Customer(string n, string a, string c)
        {
            CustomerName = n;
            CustomerAddress = a;
            CustomerContact = c;
        }
        public List<product> getAllProducts()
        {
            return products;
        }
        public void AddProduct(product p)
        {
            products.Add(p);
        }

    }
}
