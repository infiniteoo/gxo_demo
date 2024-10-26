// src/app/components/item-form/item-form.component.ts
import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';
import { ItemService } from '../../services/item.service';
import { Item } from '../../models/item.model';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-item-form',
  templateUrl: './item-form.component.html',
  styleUrls: ['./item-form.component.scss'],
  standalone: true,
  imports: [FormsModule]

})
export class ItemFormComponent implements OnInit {
  @Input() item: Item = { id: 0, name: '', quantity: 0, price: 0, description: "", supplierId: 0, warehouseId: 0 }; // Set default empty item for new entries

  constructor(private itemService: ItemService, private router: Router) {}

  ngOnInit(): void {}

  onSubmit(): void {
    if (this.item.id) {
      this.itemService.updateItem(this.item.id, this.item).subscribe(() => {
        this.router.navigate(['/items']);
      });
    } else {
      this.itemService.addItem(this.item).subscribe(() => {
        this.router.navigate(['/items']);
      });
    }
  }
}
