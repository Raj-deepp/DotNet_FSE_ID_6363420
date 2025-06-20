public static Product LinearSearch(List<Product> products, string targetName)
{
    foreach (var product in products)
    {
        if (product.ProductName == targetName)
        {
            return product;
        }
    }
    return -1;
}