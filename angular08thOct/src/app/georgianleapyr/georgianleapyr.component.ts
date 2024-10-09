import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-georgianleapyr',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './georgianleapyr.component.html',
  styleUrl: './georgianleapyr.component.scss'
})
export class GeorgianleapyrComponent {

  year: number = 2024; 
  isLeap: boolean | null = null; 

 
  isLeapYear(year: number): boolean {
    return (year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0);
  }

 
  checkLeapYear() {
    this.isLeap = this.isLeapYear(this.year);
    console.log(`The year ${this.year} is ${this.isLeap ? '' : 'not '}a leap year`);
  }

}
