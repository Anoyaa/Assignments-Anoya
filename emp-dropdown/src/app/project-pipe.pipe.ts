import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'projectPipe',
  standalone: true
})
export class ProjectPipePipe implements PipeTransform {

  transform(activeList: any[],isactive:boolean): any
  {
    return activeList.filter(x=>x.isActive==isactive);
  }

}
