using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using CERAXLAN.OKR.ProductApi.Domain.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CERAXLAN.OKR.ProductApi.Persistence.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext(DbContextOptions<ProductContext> dbContextOptions) : base(dbContextOptions)
        {
            try
            {
                var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (databaseCreator != null)
                {
                    // Create Database if cannot connect
                    if (!databaseCreator.CanConnect()) databaseCreator.Create();

                    // Create Tables if no tables exist
                    if (!databaseCreator.HasTables()) databaseCreator.CreateTables();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
