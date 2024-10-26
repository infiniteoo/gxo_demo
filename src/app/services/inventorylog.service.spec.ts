import { TestBed } from '@angular/core/testing';

import { InventorylogService } from './inventorylog.service';

describe('InventorylogService', () => {
  let service: InventorylogService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(InventorylogService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
