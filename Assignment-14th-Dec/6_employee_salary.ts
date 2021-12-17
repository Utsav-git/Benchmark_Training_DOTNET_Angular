class Employee {
  e_id: number;
  emp_name: string;
  dept_no: number;
  base_salary: number;
  gross_salary: number;
  hra: number;
  da: number;

  constructor(
    e_id: number,
    emp_name: string,
    dept_no: number,
    base_salary: number
  ) {
    this.e_id = e_id;
    this.emp_name = emp_name;
    this.dept_no = dept_no;
    this.base_salary = base_salary;
  }
  calculate_salary(): void {
    if (this.base_salary < 20000) {
      this.hra = (20 * this.base_salary) / 100;
      this.da = (80 * this.base_salary) / 100;
      this.gross_salary = this.base_salary + this.hra + this.da;
    } else if (this.base_salary > 20000 && this.base_salary < 35000) {
      this.hra = (25 * this.base_salary) / 100;
      this.da = (70 * this.base_salary) / 100;
      this.gross_salary = this.base_salary + this.hra + this.da;
      }
      console.log("[>] Base Salary: "+ this.base_salary+"\n[>] HRA: "+this.hra+"\n[>] DA: "+this.da+ "\n[>] Gross Salary: "+this.gross_salary);
      
  }
}
var e = new Employee(1, "Utsav", 20, 26000);
e.calculate_salary();
