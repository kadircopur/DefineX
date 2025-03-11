using System;
using AjaxTask.Models;
using Microsoft.EntityFrameworkCore;

namespace AjaxTask.Data
{
    public class ProductsContext: DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {
            Database.EnsureCreated();
            Database.Migrate();
        }
    }
}
