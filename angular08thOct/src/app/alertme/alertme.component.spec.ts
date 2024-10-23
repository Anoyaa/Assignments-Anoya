import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AlertmeComponent } from './alertme.component';

describe('AlertmeComponent', () => {
  let component: AlertmeComponent;
  let fixture: ComponentFixture<AlertmeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AlertmeComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AlertmeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
