import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-shopping-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './shopping-list.component.html',
  styleUrl: './shopping-list.component.scss'
})
export class ShoppingListComponent {
  items: string[] = []; 


  addItem(itemInput: HTMLInputElement) {
    const itemText = itemInput.value.trim(); 
    if (itemText) {
      this.items.push(itemText); 
      itemInput.value = '';
      itemInput.focus(); 
      console.log('Item added:', itemText); 
      console.log('Current items:', this.items); 
    }
  }

  
  deleteItem(index: number) {
    this.items.splice(index, 1); 
    console.log('Item deleted. Current items:', this.items); 
  }
}

