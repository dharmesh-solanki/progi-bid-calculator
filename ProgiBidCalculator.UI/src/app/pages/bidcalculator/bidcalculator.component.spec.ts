import { ComponentFixture, TestBed } from '@angular/core/testing';
import { BidCalculatorComponent } from './bidcalculator.component';

describe('BidCalculatorComponent', () => {
  let component: BidCalculatorComponent;
  let fixture: ComponentFixture<BidCalculatorComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BidCalculatorComponent]
    });
    fixture = TestBed.createComponent(BidCalculatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
