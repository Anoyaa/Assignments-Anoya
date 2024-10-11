import { Component,OnInit } from '@angular/core';
import { ShoppingListServiceService } from '../shopping-list-service.service';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-add-list',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './add-list.component.html',
  styleUrl: './add-list.component.scss'
})
export class AddListComponent {
itemInput:string='';
items:string[]=[];


constructor(private additemservice:ShoppingListServiceService) { }


addItem()
{
  const displayValue=this.itemInput.trim();
  if(displayValue)
  {
    this.items.push(displayValue);
    this.itemInput='';
    this.additemservice.setdata(this.items);
  
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


