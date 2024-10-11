import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ViewListComponent } from './view-list/view-list.component';
import { AddListComponent } from './add-list/add-list.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,ViewListComponent,AddListComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'shoppingwithcomponents';
}

