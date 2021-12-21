import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NumberOfWordsStringComponent } from './number-of-words-string.component';

describe('NumberOfWordsStringComponent', () => {
  let component: NumberOfWordsStringComponent;
  let fixture: ComponentFixture<NumberOfWordsStringComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NumberOfWordsStringComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NumberOfWordsStringComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
