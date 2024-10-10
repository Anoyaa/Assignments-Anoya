import { Component, Input, Output, EventEmitter} from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-add-item',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './add-item.component.html',
  styleUrls: ['./add-item.component.scss']
})
export class AddItemComponent {
  @Input() items: string[] = [];
  @Output() itemsChange = new EventEmitter<string[]>(); 
  itemInput: string = '';

  addItem() {
    const displayValue = this.itemInput.trim();
    if (displayValue) {
      this.items.push(displayValue); 
      this.itemsChange.emit(this.items);
      this.itemInput = ''; 
    }
  }
  handleKeydown(event:KeyboardEvent)
  {
    if(event.key==='Enter')
    {
      this.addItem();
    }
  }
}