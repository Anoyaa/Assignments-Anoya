import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AngularmainComponent } from './angularmain.component';

describe('AngularmainComponent', () => {
  let component: AngularmainComponent;
  let fixture: ComponentFixture<AngularmainComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AngularmainComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AngularmainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
