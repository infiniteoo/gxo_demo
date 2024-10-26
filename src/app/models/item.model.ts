// models/item.model.ts
export interface Item {
    id: number;
    name: string;
    description: string;
    price: number;
    quantity: number;
    supplierId: number;
    warehouseId: number;
  }

  