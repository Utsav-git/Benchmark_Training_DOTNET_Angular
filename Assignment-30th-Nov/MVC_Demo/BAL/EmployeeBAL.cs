using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Demo.ViewModel;
using System.Data.SqlClient;
using MVC_Demo.DAL;
using System.Data;

namespace MVC_Demo.BAL
{
    public class EmployeeBAL
    {
        EmployeeDAL d = new EmployeeDAL();
        public List<EmployeeVM> GetEmpList() {
            
            SqlDataReader reader = d.GetEmpData();

            List<EmployeeVM> elist = new List<EmployeeVM>();

            while (reader.Read()) {
                EmployeeVM e = new EmployeeVM();

                e.emp_No = Convert.ToInt32(reader["emp_No"].ToString());
                e.emp_Name = reader["emp_Name"].ToString();
                e.salary = Convert.ToInt32(reader["salary"].ToString());
                e.designation = reader["designation"].ToString();
                e.dept_No = Convert.ToInt32(reader["dept_No"].ToString());
                elist.Add(e);
            }
            return elist;
        }

        public EmployeeVM GetEmpUsingEmpNo(int emp_No) {
            SqlDataReader reader = d.GetEmpDataUsingEmpNo(emp_No);
            EmployeeVM e = new EmployeeVM();

            while (reader.Read()) {
                e.emp_No = Convert.ToInt32(reader["emp_No"].ToString());
                e.emp_Name = reader["emp_Name"].ToString();
                e.salary = Convert.ToInt32(reader["salary"].ToString());
                e.designation = reader["designation"].ToString();
                e.dept_No = Convert.ToInt32(reader["dept_No"].ToString());
            }
            return e;

        }
        public int InsertEmployee(EmployeeVM e) {
            int res = d.InsertEmp(e.emp_No, e.emp_Name, e.salary, e.designation, e.dept_No);
            return res;
        }

        public int UpdateEmployee(EmployeeVM e) {
            int res = d.UpdateEmp(e.emp_No, e.emp_Name, e.salary, e.designation, e.dept_No);
            return res;
        }

/*        public int DeleteEmployee(EmployeeVM e) {
            int res = d.DeleteEmp(emp_No);
            return res;
        }*/
    }
}