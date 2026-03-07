using System;
using System.Collections.Generic;
using System.Linq;

public interface IProduct
{
    string Name { get; set; }
    string Category { get; set; }
    int Stock { get; set; }
    int Price { get; set; }
}

public interface IInventory
{
    void AddProduct(IProduct product);
    void RemoveProduct(string name);
    int CalculateTotalValue();
    List<IProduct> GetProductsByCategory(string category);
    List<IProduct> SearchProductsByName(string name);
    Dictionary<string, List<IProduct>> GetAllProductsByCategory();
    Dictionary<string, int> GetProductsByCategoryWithCount();
}

public class Product : IProduct
{
    public string Name { get; set; }
    public string Category { get; set; }
    public int Stock { get; set; }
    public int Price { get; set; }

    public Product(string name, string category, int stock, int price)
    {
        Name = name;
        Category = category;
        Stock = stock;
        Price = price;
    }
}

public class Inventory : IInventory
{
    private List<IProduct> products = new List<IProduct>();

    public void AddProduct(IProduct product)
    {
        products.Add(product);
    }

    public void RemoveProduct(string name)
    {
        var product = products.FirstOrDefault(p => p.Name == name);
        if (product != null)
            products.Remove(product);
    }

    public int CalculateTotalValue()
    {
        int total = 0;
        foreach (var p in products)
        {
            total += p.Stock * p.Price;
        }
        return total;
    }

    public List<IProduct> GetProductsByCategory(string category)
    {
        return products.Where(p => p.Category == category).ToList();
    }

    public List<IProduct> SearchProductsByName(string name)
    {
        return products.Where(p => p.Name.Contains(name)).ToList();
    }

    public Dictionary<string, List<IProduct>> GetAllProductsByCategory()
    {
        return products.GroupBy(p => p.Category)
                       .ToDictionary(g => g.Key, g => g.ToList());
    }

    public Dictionary<string, int> GetProductsByCategoryWithCount()
    {
        return products.GroupBy(p => p.Category)
                       .ToDictionary(g => g.Key, g => g.Count());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            string name = input[0];
            string category = input[1];
            int stock = int.Parse(input[2]);
            int price = int.Parse(input[3]);

            inventory.AddProduct(new Product(name, category, stock, price));
        }

        string[] extra = Console.ReadLine().Split();
        string searchCategory = extra[0];
        string searchName = extra[1];
        string deleteName = extra[2];

        Console.WriteLine(searchCategory + ":");

        var categoryProducts = inventory.GetProductsByCategory(searchCategory);
        foreach (var p in categoryProducts)
        {
            Console.WriteLine("Product Name:" + p.Name + " Category:" + p.Category);
        }

        Console.WriteLine();

        Console.WriteLine(searchName + ":");
        var searchProducts = inventory.SearchProductsByName(searchName);
        foreach (var p in searchProducts)
        {
            Console.WriteLine("Product Name:" + p.Name + " Category:" + p.Category);
        }

        Console.WriteLine();

        Console.WriteLine("Total Value:$" + inventory.CalculateTotalValue());
        Console.WriteLine();

        var count = inventory.GetProductsByCategoryWithCount();
        foreach (var c in count)
        {
            Console.WriteLine(c.Key + ":" + c.Value);
        }

        Console.WriteLine();

        var all = inventory.GetAllProductsByCategory();
        foreach (var category in all)
        {
            Console.WriteLine(category.Key + ":");
            foreach (var p in category.Value)
            {
                Console.WriteLine("Product Name:" + p.Name + " Price:" + p.Price);
            }
        }

        inventory.RemoveProduct(deleteName);

        Console.WriteLine();
        Console.WriteLine("New Total Value:$" + inventory.CalculateTotalValue());
    }
}