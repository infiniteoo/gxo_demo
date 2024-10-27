// Data/InventoryContext.cs
using Microsoft.EntityFrameworkCore;
using InventoryAPI.Models; // Adjust based on your project structure

namespace InventoryAPI.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        // Seed data method
        public static void SeedData(InventoryContext context)
        {
            if (!context.Items.Any())
            {
                var items = new List<Item>
        {
            new Item { Name = "Hammer", Quantity = 15, Price = 12.99m, Description = "A tool for driving nails." },
            new Item { Name = "Wrench", Quantity = 25, Price = 8.49m, Description = "A tool for gripping and turning." },
            new Item { Name = "Screwdriver", Quantity = 40, Price = 4.99m, Description = "A tool for turning screws." },
            new Item { Name = "Drill", Quantity = 10, Price = 59.99m, Description = "A tool for making holes." },
            new Item { Name = "Saw", Quantity = 8, Price = 22.99m, Description = "A tool for cutting." },
            new Item { Name = "Pliers", Quantity = 20, Price = 7.49m, Description = "A tool for gripping and bending." },
            new Item { Name = "Tape Measure", Quantity = 30, Price = 6.99m, Description = "A tool for measuring length." },
            new Item { Name = "Level", Quantity = 18, Price = 13.99m, Description = "A tool for checking level surfaces." },
            new Item { Name = "Sander", Quantity = 5, Price = 49.99m, Description = "A tool for smoothing surfaces." },
            new Item { Name = "Chisel", Quantity = 12, Price = 11.99m, Description = "A tool for carving or cutting." }
        };

                context.Items.AddRange(items);
                context.SaveChanges();
            }
        }
    }
}
