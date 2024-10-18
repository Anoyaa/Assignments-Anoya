import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListsNNestedlistsComponent } from './lists-n-nestedlists.component';

describe('ListsNNestedlistsComponent', () => {
  let component: ListsNNestedlistsComponent;
  let fixture: ComponentFixture<ListsNNestedlistsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ListsNNestedlistsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListsNNestedlistsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
