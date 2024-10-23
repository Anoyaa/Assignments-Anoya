import { Component } from '@angular/core';

@Component({
  selector: 'app-alertme',
  standalone: true,
  imports: [],
  templateUrl: './alertme.component.html',
  styleUrl: './alertme.component.scss'
})
export class AlertmeComponent {
  showAlert() {
    alert('Hello World!');
  }
}
