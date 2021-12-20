import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-atm',
  templateUrl: './atm.component.html',
  styleUrls: ['./atm.component.css']
})
export class AtmComponent implements OnInit {
  balance: number;
  constructor() { 
    this.balance = 1000000;
  }

  ngOnInit(): void {
  }
  showBalance(): void{
    console.log(this.balance);
    
  }
  withDraw(wdAmt: number): void{
    this.balance = this.balance - wdAmt;
    console.log(this.balance);
    
  }
  deposit(dpAmt: number): void{
    this.balance = this.balance + dpAmt;
    console.log(this.balance);
    
  }

}
