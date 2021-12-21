import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StrFormatComponent } from './str-format.component';

describe('StrFormatComponent', () => {
  let component: StrFormatComponent;
  let fixture: ComponentFixture<StrFormatComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StrFormatComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StrFormatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
