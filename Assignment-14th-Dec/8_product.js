var Product = /** @class */ (function () {
    function Product(p_id, p_name, amt, discount, qty) {
        this.p_id = p_id;
        this.p_name = p_name;
        this.amt = amt;
        this.discount = discount;
        this.qty = qty;
    }
    Product.prototype.calculate_price = function () {
        var disct = (this.amt * this.discount) / 100;
        this.total = (this.amt - disct) * this.qty;
    };
    Product.prototype.disp = function () {
        console.log("[>]Amount: " + this.amt + "\nQuantity " + this.qty + "\nPrice " + (this.amt * this.qty) + "\n Discount: " + this.discount + "\n Total: " + this.total);
    };
    return Product;
}());
var p = new Product(1, "Product-1", 2000, 2, 30);
p.calculate_price();
p.disp();
