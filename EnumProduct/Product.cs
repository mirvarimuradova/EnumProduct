using EnumProduct;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace EnumProduct  
{
    internal class Product
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Categories Category { get; set; }

        public Product(string brand, string model, decimal price, int quantity, Categories category)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Quantity = quantity;
            Category = category;



        }
    }
}
