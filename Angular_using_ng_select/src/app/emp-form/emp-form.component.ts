import { CommonModule } from '@angular/common';
import { Component, NgModule} from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators} from '@angular/forms';
import { IemployeeForm } from '../iemployee-form';
import { ProjectPipePipe } from '../project-pipe.pipe';
import { NgSelectComponent } from '@ng-select/ng-select';

@Component({
  selector: 'app-emp-form',
  standalone: true,
  imports: [CommonModule,ReactiveFormsModule,ProjectPipePipe,FormsModule,CommonModule,NgSelectComponent],
  templateUrl: './emp-form.component.html',
  styleUrl: './emp-form.component.scss'
})

export class EmpFormComponent
{
  formSubmitted = false;
  employeeDetails:any= null;
  
  projects=  [
    { "name": "Hilite", "isActive": true },
    { "name": "Lulu", "isActive": true },
    { "name": "Cordova School", "isActive": true },
    { "name": "Azure Heights Apartments", "isActive": true },
    { "name": "Greenfield Mall", "isActive": true },
    { "name": "Pinnacle Corporate Towers", "isActive": true },
    { "name": "Sunshine Valley Resort", "isActive": true },
    { "name": "Everest Office Park", "isActive": false },
    { "name": "Maplewood Villas", "isActive": false },
    { "name": "Sterling Shopping Complex", "isActive": false }
  ]
  employeeForm:FormGroup< IemployeeForm >

  ngOnInit(): void
   {
    this.employeeForm = new FormGroup<IemployeeForm>
    ({
      firstName: new FormControl('', Validators.required),
      lastName:new FormControl(''),
      email: new FormControl('', [Validators.required, Validators.email]),
      phone: new FormControl('', [Validators.required,Validators.pattern('^[0-9]{10}$')]),
      address:new FormGroup
      ({
        building: new FormControl(''),
        streetName:new FormControl(''),
        city:new FormControl('')
      }),
      project:new FormControl('')
    });
   }
 
  onSubmit()
  {
    this.formSubmitted = true;
    if (this.employeeForm.valid) 
    {
      this.employeeDetails = this.employeeForm.value;
    }
  }
}



