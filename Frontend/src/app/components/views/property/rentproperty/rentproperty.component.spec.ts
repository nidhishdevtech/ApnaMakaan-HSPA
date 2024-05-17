import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RentpropertyComponent } from './rentproperty.component';

describe('RentpropertyComponent', () => {
  let component: RentpropertyComponent;
  let fixture: ComponentFixture<RentpropertyComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [RentpropertyComponent]
    });
    fixture = TestBed.createComponent(RentpropertyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
