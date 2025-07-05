using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;


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

var context = new AppDbContext();

var product = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
if (product != null)
{
    product.Price = 70000;
    await context.SaveChangesAsync();
    Console.WriteLine("Laptop price updated to ₹70000");
}

var toDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
if (toDelete != null)
{
    context.Products.Remove(toDelete);
    await context.SaveChangesAsync();
    Console.WriteLine("Rice Bag deleted");
}