import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-shoppinglist',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './shoppinglist.component.html',
  styleUrl: './shoppinglist.component.scss'
})
export class ShoppinglistComponent {
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


