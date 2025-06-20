using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePlatformSearchFunction
{
    public static class SearchAlgorithms
    {
        public static Product LinearSearch(Product[] products, string productName)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                    return product;
            }
            return null;
        }

        public static Product BinarySearch(Product[] products, string productName)
        {
            int left = 0, right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int compare = string.Compare(products[mid].ProductName, productName, StringComparison.OrdinalIgnoreCase);

                if (compare == 0)
                    return products[mid];
                else if (compare < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }
    }
}
