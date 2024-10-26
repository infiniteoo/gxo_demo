// Models/InventoryLog.cs

public class InventoryLog
{
    public int InventoryLogId { get; set; }
    public int ItemId { get; set; }
    public int WarehouseId { get; set; }
    public int EmployeeId { get; set; }
    public int Quantity { get; set; }
    public DateTime Date { get; set; }
    public string Notes { get; set; }
}