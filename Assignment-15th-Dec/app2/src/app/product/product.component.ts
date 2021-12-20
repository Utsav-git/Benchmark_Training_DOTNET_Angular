import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  prod_name: string = "Product - 1";
  prod_price: number = 20000;
  prod_qty: number = 1;
  total: number = 0;

  calcBill(): number{
    this.total = this.prod_price * this.prod_qty;
    return this.total;
  }
}
