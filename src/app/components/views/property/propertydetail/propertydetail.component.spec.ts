import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PropertydetailComponent } from './propertydetail.component';

describe('PropertydetailComponent', () => {
  let component: PropertydetailComponent;
  let fixture: ComponentFixture<PropertydetailComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PropertydetailComponent]
    });
    fixture = TestBed.createComponent(PropertydetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
