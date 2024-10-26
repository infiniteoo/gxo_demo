// src/app/components/item-list/item-list.component.ts
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ItemService } from '../../services/item.service';
import { Item } from '../../models/item.model';

@Component({
  selector: 'app-item-list',
  templateUrl: './item-list.component.html',
  styleUrls: ['./item-list.component.scss']
})
export class ItemListComponent implements OnInit {
  items: Item[] = [];

  constructor(private itemService: ItemService, private router: Router) {}

  ngOnInit(): void {
    this.fetchItems();
  }

  fetchItems(): void {
    this.itemService.getItems().subscribe((data: Item[]) => {
      this.items = data;
    });
  }

  deleteItem(id: number): void {
    this.itemService.deleteItem(id).subscribe(() => {
      this.items = this.items.filter(item => item.id !== id);
    });
  }

  viewItem(id: number): void {
    this.router.navigate(['/items', id]); // Navigates to ItemDetailComponent with the item's ID
  }

  editItem(id: number): void {
    this.router.navigate(['/edit-item', id]); // Navigates to ItemFormComponent with the item's ID
  }
}
