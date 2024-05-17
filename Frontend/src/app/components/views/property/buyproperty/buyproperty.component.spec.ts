import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BuypropertyComponent } from './buyproperty.component';

describe('BuypropertyComponent', () => {
  let component: BuypropertyComponent;
  let fixture: ComponentFixture<BuypropertyComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BuypropertyComponent]
    });
    fixture = TestBed.createComponent(BuypropertyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
