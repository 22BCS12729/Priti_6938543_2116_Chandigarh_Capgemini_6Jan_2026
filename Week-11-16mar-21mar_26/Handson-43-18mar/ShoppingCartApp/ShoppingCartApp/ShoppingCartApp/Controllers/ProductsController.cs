using Microsoft.AspNetCore.Mvc;
using ShoppingCartApp.Models;
using System.Collections.Generic;

public class ProductsController : Controller
{
    public static List<Product> products = new List<Product>()
    {
        new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 80000,
            ImageUrl = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?w=500"
        },
        new Product
        {
            Id = 2,
            Name = "Phone",
            Price = 50000,
            ImageUrl = "https://images.unsplash.com/photo-1511707171634-5f897ff02aa9?w=500"
        },
           
    
        new Product
        {
            Id = 4,
            Name = "Smart Watch",
            Price = 7000,
            ImageUrl = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?w=500"
        },
        new Product
        {
            Id = 5,
            Name = "Camera",
            Price = 45000,
            ImageUrl = "https://images.unsplash.com/photo-1516035069371-29a1b244cc32?w=500"
        },

        // ✅ NEW ITEM 1
        new Product
        {
            Id = 6,
            Name = "Bluetooth Speaker",
            Price = 2500,
            ImageUrl = "https://images.unsplash.com/photo-1585386959984-a4155224a1ad?w=500"
        },

        // ✅ NEW ITEM 2
        new Product
        {
            Id = 7,
            Name = "Gaming Mouse",
            Price = 1500,
            ImageUrl = "https://images.unsplash.com/photo-1587202372775-e229f172b9d7?w=500"
        },
        new Product
        {
            Id = 8,
            Name = "Keyboard",
            Price = 2000,
            ImageUrl = "https://images.pexels.com/photos/1772123/pexels-photo-1772123.jpeg"
        }
    };

    public IActionResult Index()
    {
        return View(products);
    }
}