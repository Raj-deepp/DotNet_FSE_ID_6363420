using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;

namespace RetailInventory.Helpers
{
    public static class CompiledQueries
    {
        public static readonly Func<AppDbContext, decimal, IAsyncEnumerable<Product>> ExpensiveProducts =
            EF.CompileAsyncQuery((AppDbContext ctx, decimal price) =>
                ctx.Products.Where(p => p.Price > price));
    }
}
