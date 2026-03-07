using System;
using System.Collections.Generic;
using System.Text;

namespace EComProdCatalog
{
    internal class EcomProductCatalog
    {
        class Product
        {
            private int id;
            private string name;
            private double price;
            private int stock;

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
            public double Price { get => price; set => price = value; }
            public int Stock { get => stock; set => stock = value; }

            public virtual void Display()
            {
                Console.WriteLine($"ID:{Id}  Name:{Name}  Price:{Price}  Stock:{Stock}");
            }
        }
        class Electronics : Product
        {
            public string Brand { get; set; }
        }

        class Clothing : Product
        {
            public string Size { get; set; }
        }

        class Books : Product
        {
            public string Author { get; set; }
        }

        // Cart class
        class Cart
        {
            public List<Product> Products = new List<Product>();

            public void AddProduct(Product p)
            {
                Products.Add(p);
                Console.WriteLine("Product added to cart");
            }
        }

        // Customer class
        class Customer
        {
            public string Name { get; set; }
            public Cart Cart = new Cart();
        }

        class Program
        {
            static void Main()
            {
                Electronics e1 = new Electronics
                {
                    Id = 1,
                    Name = "Mobile",
                    Price = 15000,
                    Stock = 10,
                    Brand = "Samsung"
                };

                Books b1 = new Books
                {
                    Id = 2,
                    Name = "C# Book",
                    Price = 500,
                    Stock = 20,
                    Author = "XYZ"
                };

                e1.Display();
                b1.Display();

                Customer c = new Customer { Name = "Priti" };
                c.Cart.AddProduct(e1);

                Console.ReadLine();
            }
        }
    }
}