import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GeorgianleapyrComponent } from './georgianleapyr.component';

describe('GeorgianleapyrComponent', () => {
  let component: GeorgianleapyrComponent;
  let fixture: ComponentFixture<GeorgianleapyrComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GeorgianleapyrComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GeorgianleapyrComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
