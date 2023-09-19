using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Stock { get; set; }
}

public class InventoryManager
{
    public static List<Product> SortProducts(List<Product> products, string sortKey, bool ascending)
    {
        switch (sortKey)
        {
            case "name":
                products = ascending
                    ? products.OrderBy(p => p.Name).ToList()
                    : products.OrderByDescending(p => p.Name).ToList();
                break;
            case "price":
                products = ascending
                    ? products.OrderBy(p => p.Price).ToList()
                    : products.OrderByDescending(p => p.Price).ToList();
                break;
            case "stock":
                products = ascending
                    ? products.OrderBy(p => p.Stock).ToList()
                    : products.OrderByDescending(p => p.Stock).ToList();
                break;
            default:
                throw new ArgumentException("Invalid sort key. Use 'name', 'price', or 'stock'.");
        }

        return products;
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Product A", Price = 100, Stock = 5 },
            new Product { Name = "Product B", Price = 200, Stock = 3 },
            new Product { Name = "Product C", Price = 50, Stock = 10 }
        };

        string sortKey = "price";
        bool ascending = false;

        List<Product> sortedProducts = InventoryManager.SortProducts(products, sortKey, ascending);

        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
    }
}
