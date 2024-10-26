// models/inventorylog.model.ts
export interface InventoryLog {
    itemId: number;
    name: string;
    description: string;
    price: number;
    quantity: number;
    supplierId: number;
    warehouseId: number;
  }

  
  