import { Routes } from '@angular/router';
import { ItemListComponent } from './components/item-list/item-list.component';
import { WarehousesComponent } from './components/warehouses/warehouses.component';
import { ItemFormComponent } from './components/item-form/item-form.component';
import { EmployeesComponent } from './components/employees/employees.component';
import { InventorylogComponent } from './components/inventorylog/inventorylog.component';
import { ItemDetailComponent } from './components/item-detail/item-detail.component';
import { SuppliersComponent } from './components/suppliers/suppliers.component';

export const routes: Routes = [
  { path: 'items', component: ItemListComponent },
  { path: 'items/:id', component: ItemDetailComponent },
  { path: 'warehouses', component: WarehousesComponent },
  { path: 'suppliers', component: SuppliersComponent },
  { path: 'employees', component: EmployeesComponent },
  { path: 'inventory-log', component: InventorylogComponent },
  { path: '', redirectTo: '/items', pathMatch: 'full' },
  { path: 'add-item', component: ItemFormComponent },
];
