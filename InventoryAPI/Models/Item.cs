// Models/Item.cs
namespace InventoryAPI.Models
{
    public class Item
    {
        public int Id { get; set; } // Primary key
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; } // Make this nullable
        public int? SupplierId { get; set; }   
    }
}
