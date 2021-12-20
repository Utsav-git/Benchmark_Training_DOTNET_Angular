import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css'],
})
export class CalculatorComponent implements OnInit {
  a: number = 0;
  b: number = 0;
  res: number = 0;

  constructor() {}

  ngOnInit(): void {}
  add(a: number, b: number) {
    this.res = this.a + this.b;
    console.log(this.res);
  }
  sub(a: number, b: number) {
    this.res = this.a - this.b;
    console.log(this.res);
  }
  multiply(a: number, b: number) {
    this.res = this.a * this.b;
    console.log(this.res);
  }
  divide(a: number, b: number) {
    this.res = this.a / this.b;
    console.log(this.res);
  }
}
