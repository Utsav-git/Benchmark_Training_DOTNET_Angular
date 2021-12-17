class Product {
  p_id: number;
  p_name: string;
  amt: number;
  discount: number;
  qty: number;

  constructor(
    p_id: number,
    p_name: string,
    amt: number,
    discount: number,
    qty: number
  ) {
    this.p_id = p_id;
    this.p_name = p_name;
    this.amt = amt;
    this.discount = discount;
    this.qty = qty;
  }
  total: number;
  calculate_price(): void {
    var disct = (this.amt * this.discount) / 100;
    this.total = (this.amt - disct) * this.qty;
    }
    disp(): void{
        console.log("[>]Amount: "+this.amt+ "\nQuantity "+ this.qty+ "\nPrice "+(this.amt * this.qty)+"\n Discount: "+this.discount+"\n Total: "+this.total);
        
    }
}
var p = new Product(1, "Product-1", 2000, 2, 30);
p.calculate_price();
p.disp();