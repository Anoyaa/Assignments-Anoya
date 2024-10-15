import { FormControl, FormGroup } from "@angular/forms";

export interface IemployeeForm {
    firstName:FormControl<string>;
    lastName:FormControl<string>;
    email:FormControl<string>;
    phone:FormControl<string>;
    address:FormGroup<
    {
      building:FormControl<string>;
      streetName:FormControl<string>;
      city:FormControl<string>;
    }>

}
