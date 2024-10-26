// models/item.model.ts
export interface Item {
    itemId: number;
    name: string;
    description: string;
    price: number;
    quantity: number;
    supplierId: number;
    warehouseId: number;
  }

  