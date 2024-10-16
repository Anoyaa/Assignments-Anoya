import { CommonModule } from '@angular/common';
import { Component} from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators} from '@angular/forms';
import { IemployeeForm } from '../iemployee-form';
@Component({
  selector: 'app-emp-form',
  standalone: true,
  imports: [CommonModule,ReactiveFormsModule],
  templateUrl: './emp-form.component.html',
  styleUrl: './emp-form.component.scss'
})

export class EmpFormComponent
{
  formSubmitted = false;
  employeeDetails:any= null;
  
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
      })
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



