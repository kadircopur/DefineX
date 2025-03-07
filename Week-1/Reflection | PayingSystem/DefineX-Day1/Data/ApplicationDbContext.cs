using System;
using DefineX_Day1.Helpers;
using DefineX_Day1.Models;
using Microsoft.EntityFrameworkCore;

namespace DefineX_Day1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;port=3306;database=PaymentDb;user=root;password=Asd.1234;";
            optionsBuilder.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString)
            );
        }
    }
}
