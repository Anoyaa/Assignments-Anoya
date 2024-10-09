import { Component, NgModule } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AngularmainComponent } from './angularmain/angularmain.component';
import { AlertmeComponent } from './alertme/alertme.component';
import { GeorgianleapyrComponent } from './georgianleapyr/georgianleapyr.component';
import { ShoppinglistComponent } from './shoppinglist/shoppinglist.component';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,AngularmainComponent,AlertmeComponent,GeorgianleapyrComponent,ShoppinglistComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'angularprojects1';
}
