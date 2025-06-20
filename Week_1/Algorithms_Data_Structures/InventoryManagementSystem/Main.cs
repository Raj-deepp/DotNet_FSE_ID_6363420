using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shoes", "Footwear"),
            new Product(3, "Phone", "Electronics"),
            new Product(4, "Book", "Stationery")
        };

        var linearRes = LinearSearch(products, "Phone");
        Console.WriteLine("Linear Search Result: " + (linearRes ?? "Not Found"));

        products.Sort((p1, p2) => string.Compare(p1.ProductName, p2.ProductName, StringComparison.OrdinalIgnoreCase));

        var binaryRes = BinarySearch(products, "Phone");
        Console.WriteLine("Binary Search Result: " + (binaryRes ?? "Not Found"));
    }
}
