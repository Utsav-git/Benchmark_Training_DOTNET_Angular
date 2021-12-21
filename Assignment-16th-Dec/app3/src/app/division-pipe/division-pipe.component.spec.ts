import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DivisionPipeComponent } from './division-pipe.component';

describe('DivisionPipeComponent', () => {
  let component: DivisionPipeComponent;
  let fixture: ComponentFixture<DivisionPipeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DivisionPipeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DivisionPipeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
