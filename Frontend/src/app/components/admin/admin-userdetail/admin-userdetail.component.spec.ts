import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminUserdetailComponent } from './admin-userdetail.component';

describe('AdminUserdetailComponent', () => {
  let component: AdminUserdetailComponent;
  let fixture: ComponentFixture<AdminUserdetailComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdminUserdetailComponent]
    });
    fixture = TestBed.createComponent(AdminUserdetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
