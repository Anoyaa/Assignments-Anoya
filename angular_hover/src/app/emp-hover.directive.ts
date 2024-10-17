import { Directive, ElementRef, HostBinding, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[appEmpHover]',
  standalone: true
})
export class EmpHoverDirective {

  constructor(private el:ElementRef) {}

  private highlight(color:string)
  {
    this.el.nativeElement.style.backgroundColor=color;
  }
  
  @HostListener('mouseenter') onMouseEnter() 
   { 
    this.highlight("green")
   }  

  @HostListener('mouseleave') onMouseLeave() 
    { 
      this.highlight('blue') 
    } 

}

