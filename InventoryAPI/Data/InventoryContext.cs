// Data/InventoryContext.cs


public class InventoryContext : DbContext
{
    public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
    {
    }

    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<InventoryLog> InventoryLogs { get; set; }
}