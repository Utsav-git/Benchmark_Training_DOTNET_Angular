var Employee = /** @class */ (function () {
    function Employee(e_id, emp_name, dept_no, base_salary) {
        this.e_id = e_id;
        this.emp_name = emp_name;
        this.dept_no = dept_no;
        this.base_salary = base_salary;
    }
    Employee.prototype.calculate_salary = function () {
        if (this.base_salary < 20000) {
            this.hra = (20 * this.base_salary) / 100;
            this.da = (80 * this.base_salary) / 100;
            this.gross_salary = this.base_salary + this.hra + this.da;
        }
        else if (this.base_salary > 20000 && this.base_salary < 35000) {
            this.hra = (25 * this.base_salary) / 100;
            this.da = (70 * this.base_salary) / 100;
            this.gross_salary = this.base_salary + this.hra + this.da;
        }
        console.log("[>] Base Salary: " + this.base_salary + "\n[>] HRA: " + this.hra + "\n[>] DA: " + this.da + "\n[>] Gross Salary: " + this.gross_salary);
    };
    return Employee;
}());
var e = new Employee(1, "Utsav", 20, 26000);
e.calculate_salary();
