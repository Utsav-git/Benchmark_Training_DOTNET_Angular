var discountedBill = function (bill) {
    var discountedBill;
    if (bill <= 10000) {
        discountedBill = (bill * 5) / 100;
    }
    else if (bill > 10000 && bill <= 20000) {
        discountedBill = (bill * 10) / 100;
    }
    else if (bill > 20000 && bill < 30000) {
        discountedBill = (bill * 15) / 100;
    }
    else if (bill >= 30000) {
        discountedBill = (bill * 25) / 100;
    }
    console.log("[>] Discount for " + bill + " amount is " + discountedBill);
};
discountedBill(25000);
