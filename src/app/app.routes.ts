import { Routes } from '@angular/router';
import { ItemsComponent } from './components/items/items.component';
import { WarehousesComponent } from './components/warehouses/warehouses.component';

import { EmployeesComponent } from './components/employees/employees.component';
import { InventorylogComponent } from './components/inventorylog/inventorylog.component';

import { SuppliersComponent } from './components/suppliers/suppliers.component';

export const routes: Routes = [
  { path: 'items', component: ItemsComponent },
  { path: 'warehouses', component: WarehousesComponent },
  { path: 'suppliers', component: SuppliersComponent },
  { path: 'employees', component: EmployeesComponent },
  { path: 'inventory-log', component: InventorylogComponent },
  { path: '', redirectTo: '/items', pathMatch: 'full' },
];
