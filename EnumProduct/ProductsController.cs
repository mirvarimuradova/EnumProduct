using EnumProduct;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumProduct
{
    internal class ProductsController
    {
        public ArrayList Products { get; set; }
        public ProductsController()
        {


            Products = new ArrayList();

        }

        public void ShowAllProduct()
        {
            int id = 1;
            foreach (Product product in Products)
            {

                Console.WriteLine($"" +
                    $"ID: {id}\n" +
                    $"Brand: {product.Brand}\n" +
                    $"Model: {product.Model}\n" +
                    $"Price: {product.Price}\n" +
                    $"Quantity: {product.Quantity}\n" +
                    $"Category: {product.Category} ");

                id++;
            }
        }

        public void ShowProductByCategory( Categories category)
        {
            int id = 1;
            foreach (Product product in Products)
            {
               
                if (product.Category == category)
                {
                    Console.WriteLine($"" +
                   $"ID: {id}\n" +
                   $"Brand: {product.Brand}\n" +
                   $"Model: {product.Model}\n" +
                   $"Price: {product.Price}\n" +
                   $"Quantity: {product.Quantity}\n" +
                   $"Category: {product.Category} ");

                    id++;
                }
            }
        }
        public void AddProduct(Product product)
        {

            Products.Add(product);


        }


        public void DeleteProduct(Product product)
        {

            Products.Remove(product);
        }

        public void DeleteProductByID(int id)
        {

            Products.RemoveAt(id - 1);
        }

        public void Updateproduct(Product product, int id)
        {

            Products[id - 1] = product;
            Console.WriteLine(" The product succesfully updated!");
        }


        public void UpdateproductByProperty(int id, int propertyid, string newvalue)
        {
            Product currentdata = (Product)Products[id - 1];

            if (propertyid == 1)
            {
                currentdata.Brand = newvalue;
            }
            else if (propertyid == 2)
            {
                currentdata.Model = newvalue;

            }
            else if (propertyid == 3)
            {
                currentdata.Price = Convert.ToDecimal(newvalue);
            }
            else if (propertyid == 4)
            {
                currentdata.Quantity = Convert.ToInt32((newvalue));
            }


        }

        public void SellProduct(int id, int sellamount)
        {
            Product product = (Product)Products[id - 1];

            product.Quantity -= sellamount;

        }

        public decimal TotalAmount()
        {
            decimal totalamount = 0m;
            foreach (Product product in Products)
            {
                totalamount += product.Price;

            }
            return totalamount;
        }

       


        public decimal TotalAmountByCategory(Categories category)
        {

            decimal totalamount = 0m;

             foreach(Product product in Products)
            {
                if (product.Category.Equals(Categories.pc)){

                    totalamount += product.Price;
                }
            }
             return totalamount;
        }


        public int TotalQuantity() { 
        
           int totalquantity = 0;

            foreach (Product product in Products) { 
            
                totalquantity += product.Quantity;
            }
            return totalquantity;
        }
    }

}

