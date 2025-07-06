using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;



//LAB 4 ->  INSERTING INITIAL DATA INTO THE DATABASE

//var context = new AppDbContext();

//var electronics = new Category { Name = "Electronics" };
//var groceries = new Category { Name = "Groceries" };

//await context.Categories.AddRangeAsync(electronics, groceries);

//var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
//var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

//await context.Products.AddRangeAsync(product1, product2);
//await context.SaveChangesAsync();

//Console.WriteLine("Data inserted successfully.");

//--------------------------------------------------------------------------------------



//LAB 5 ->  RETRIRVING DATA FROM THE DATABASE

//var context = new AppDbContext();

//var products = await context.Products.ToListAsync();
//Console.WriteLine("All Products:");
//foreach (var p in products)
//    Console.WriteLine($"{p.Name} - ₹{p.Price}");

//Console.WriteLine();

//var product = await context.Products.FindAsync(1);
//Console.WriteLine($"Found (by ID 1): {product?.Name}");

//Console.WriteLine();

//var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
//Console.WriteLine($"Expensive product (> ₹50000): {expensive?.Name}");

//--------------------------------------------------------------------------------------



//LAB 6 -> UPDATING & DELETING RECORDS

//var context = new AppDbContext();

//var product = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
//if (product != null)
//{
//    product.Price = 70000;
//    await context.SaveChangesAsync();
//    Console.WriteLine("Laptop price updated to ₹70000");
//}

//var toDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
//if (toDelete != null)
//{
//    context.Products.Remove(toDelete);
//    await context.SaveChangesAsync();
//    Console.WriteLine("Rice Bag deleted");
//}

//--------------------------------------------------------------------------------------



//LAB 7 -> WRITNG QUERIES USING LINQ

var context = new AppDbContext();

var filtered = await context.Products
    .Where(p => p.Price > 1000)
    .OrderByDescending(p => p.Price)
    .ToListAsync();

Console.WriteLine("Filtered Products (Price > ₹1000, Descending):");
foreach (var p in filtered)
    Console.WriteLine($"{p.Name} - ₹{p.Price}");

Console.WriteLine();


var productDTOs = await context.Products
    .Select(p => new { p.Name, p.Price })
    .ToListAsync();

Console.WriteLine("Product DTOs:");
foreach (var dto in productDTOs)
    Console.WriteLine($"{dto.Name} - ₹{dto.Price}");

//--------------------------------------------------------------------------------------



// LAB 10 -> EAGER, EXPLICIT, AND LAZY LOADING

Console.WriteLine("\n=== Lab 10: Eager Loading ===");

var eagerProducts = await context.Products
    .Include(p => p.Category)
    .ToListAsync();

foreach (var p in eagerProducts)
    Console.WriteLine($"{p.Name} - ₹{p.Price} - Category: {p.Category.Name}");

Console.WriteLine("\n=== Lab 10: Explicit Loading ===");

var firstProduct = await context.Products.FirstOrDefaultAsync();

if (firstProduct != null)
{
    await context.Entry(firstProduct).Reference(p => p.Category).LoadAsync();
    Console.WriteLine($"{firstProduct.Name} - ₹{firstProduct.Price} - Category: {firstProduct.Category.Name}");
}

Console.WriteLine("\n=== Lab 10: Lazy Loading ===");

var lazyProduct = await context.Products.FirstOrDefaultAsync();

if (lazyProduct != null)
{
    Console.WriteLine($"{lazyProduct.Name} - ₹{lazyProduct.Price} - Category: {lazyProduct.Category.Name}");
}

//--------------------------------------------------------------------------------------
