import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-leap-year',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './leap-year.component.html',
  styleUrl: './leap-year.component.scss'
})
export class LeapYearComponent {

  
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
