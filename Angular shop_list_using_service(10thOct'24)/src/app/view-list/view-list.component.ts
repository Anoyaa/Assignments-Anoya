import { Component } from '@angular/core';
import { ShoppingListServiceService } from '../shopping-list-service.service';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-view-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './view-list.component.html',
  styleUrl: './view-list.component.scss'
})
export class ViewListComponent {

  items: string[] = [];

  constructor(private shoppingListService: ShoppingListServiceService) {}

  ngOnInit() {
    this.shoppingListService.counter$.subscribe(x=>this.items=x);
  }

  deleteItem(index: number) {
    this.items.splice(index,1);
    this.shoppingListService.deleteItem(index);

  }
}
