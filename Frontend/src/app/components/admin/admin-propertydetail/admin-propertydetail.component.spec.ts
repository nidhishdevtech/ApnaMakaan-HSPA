import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminPropertydetailComponent } from './admin-propertydetail.component';

describe('AdminPropertydetailComponent', () => {
  let component: AdminPropertydetailComponent;
  let fixture: ComponentFixture<AdminPropertydetailComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdminPropertydetailComponent]
    });
    fixture = TestBed.createComponent(AdminPropertydetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
