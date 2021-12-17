class Student {
  roll_no: number;
  name: string;
  phy: number;
  chem: number;
  maths: number;

  constructor(
    roll_no: number,
    name: string,
    phy: number,
    chem: number,
    maths: number
  ) {
    this.roll_no = roll_no;
    this.name = name;
    this.phy = phy;
    this.chem = chem;
    this.maths = maths;
  }

  percentage: number;
  calculate_percentage(): void {
    this.percentage = (this.phy + this.chem + this.maths) / 3;
    // console.log("[>] Percentage: " + this.percentage);
    }
    grade: string;
    calculate_grade(): void{
        if (this.percentage >= 75) {
          this.grade = "Distinction";
        } else if (this.percentage >= 60 && this.percentage <= 74) {
          this.grade = "First Class";
        } else if (this.percentage >= 45 && this.percentage <= 59) {
          this.grade = "Second Class";
        } else if (this.percentage >= 35 && this.percentage <= 44) {
          this.grade = "Pass";
        } else if(this.percentage < 34) {
            this.grade = "Fail";
        }
    }
    disp(): void{
        console.log(this.roll_no +" "+this.name+" "+this.percentage+" "+this.grade);
        
    }
}
let s = new Student(1, "Utsav", 60, 70, 80);
s.calculate_grade();
s.calculate_grade();
s.disp();