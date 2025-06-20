public static Product BinarySearch(List<Product> products, string targetName)
{
    int low = 0, high = products.Count - 1;

    while (low <= high)
    {
        int mid = (low + high) / 2;
        int compare = string.Compare(products[mid].ProductName, targetName, StringComparison.OrdinalIgnoreCase);

        if (compare == 0)
            return products[mid];
        else if (compare < 0)
            low = mid + 1;
        else
            high = mid - 1;
    }

    return -1;
}
