import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'projectPipe',
  standalone: true
})
export class ProjectPipePipe implements PipeTransform {

  transform(activeList: string,isActive:boolean): any {
    if(isActive===true)
    return activeList;
  }


}
