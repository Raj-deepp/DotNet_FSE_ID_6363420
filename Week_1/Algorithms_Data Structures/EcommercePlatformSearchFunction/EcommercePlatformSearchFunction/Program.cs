using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePlatformSearchFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Shampoo", "Personal Care"),
                new Product(3, "Desk", "Furniture"),
                new Product(4, "Mouse", "Electronics")
            };

            var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();

            Console.WriteLine("Enter product name to search:");
            string searchQuery = Console.ReadLine();

            var resultLinear = SearchAlgorithms.LinearSearch(products, searchQuery);
            var resultBinary = SearchAlgorithms.BinarySearch(sortedProducts, searchQuery);

            Console.WriteLine("\n-- Search Results --");

            Console.WriteLine("Linear Search Result: " +
                (resultLinear != null ? $"{resultLinear.ProductName} in {resultLinear.Category}" : "Not Found"));

            Console.WriteLine("Binary Search Result: " +
                (resultBinary != null ? $"{resultBinary.ProductName} in {resultBinary.Category}" : "Not Found"));
        }
    }
}
