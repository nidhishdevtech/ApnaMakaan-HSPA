import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminPropertybyuserComponent } from './admin-propertybyuser.component';

describe('AdminPropertybyuserComponent', () => {
  let component: AdminPropertybyuserComponent;
  let fixture: ComponentFixture<AdminPropertybyuserComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdminPropertybyuserComponent]
    });
    fixture = TestBed.createComponent(AdminPropertybyuserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
