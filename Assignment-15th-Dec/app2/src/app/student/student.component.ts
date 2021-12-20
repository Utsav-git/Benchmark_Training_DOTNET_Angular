import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css'],
})
export class StudentComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {}
  id: number = 1;
  name: string = 'Utsav';
  phy: number = 66;
  chem: number = 77;
  maths: number = 88;
  percentage: number = 0;

  disp(): number {
    this.percentage = (this.phy + this.chem + this.maths) / 3;
    console.log(this.percentage);
    return this.percentage;
  }
}
