import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ShoppingListServiceService {

deleteItem(index: number) {}

private itemslist=new Subject<string[]>;
counter$=this.itemslist.asObservable();

setdata(items:string[])
{
  this.itemslist.next(items);
}
  
}
