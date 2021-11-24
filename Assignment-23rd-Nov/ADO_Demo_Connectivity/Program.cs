using System;
using System.Data.SqlClient;
using System.Data;

namespace ADO_Demo_Connectivity
{
    class EmployeeDAL
    {
        public SqlDataReader GetEmployeeData() {
            SqlDataReader reader = null;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Server = UTSAV\\MSSQLSERVER01; Database = EmpDB; trusted_connection = true";
                con.Open();

                SqlCommand cmd = new SqlCommand("GetEmployeeData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

            }
            catch (SqlException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            /*finally
            {
                con.Close();
            }*/
            
            return reader;

        }
        public SqlDataReader GetEmpUsingEmpNo(int empNo) {
            SqlDataReader reader = null;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Server = UTSAV\\MSSQLSERVER01; Database = EmpDB; trusted_connection = true";
                con.Open();

                SqlCommand cmd = new SqlCommand("GetEmpUsingEmpNo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("emno", empNo);
                cmd.Parameters.Add(p);
                reader = cmd.ExecuteReader();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            /*finally
            {
                con.Close();
            }*/
            return reader;
        }
        public int InsertEmployee(int empNo, string empName, int salary, string designation, int deptNo ) {
            int res = 0;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Server = UTSAV\\MSSQLSERVER01; Database = EmpDB; trusted_connection = true";
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter p1 = new SqlParameter("emno", empNo);
                SqlParameter p2 = new SqlParameter("emnm", empName);
                SqlParameter p3 = new SqlParameter("sal", salary);
                SqlParameter p4 = new SqlParameter("desig", designation);
                SqlParameter p5 = new SqlParameter("deptNo", deptNo);
               
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);

                res = cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            /*finally
            {
                con.Close();
            }*/
            return res;
        }
        public int UpdateEmployee(int empNo, string empName, int salary, string designation, int deptNo) {
            int res = 0;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Server = UTSAV\\MSSQLSERVER01; Database = EmpDB; trusted_connection = true";
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("emno", empNo);
                SqlParameter p2 = new SqlParameter("emnm", empName);
                SqlParameter p3 = new SqlParameter("sal", salary);
                SqlParameter p4 = new SqlParameter("desig", designation);
                SqlParameter p5 = new SqlParameter("deptNo", deptNo);

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);

                res = cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            /*finally
            {
                con.Close();
            }*/
            return res;
        }
        public int DeleteEmployee(int empNo) {
            int res = 0;
            SqlConnection con = null;
            try {
                con = new SqlConnection();
                con.ConnectionString = "Server = UTSAV\\MSSQLSERVER01; Database = EmpDB; trusted_connection = true";
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteEmpUsingEmpNo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("emno", empNo);
                
                cmd.Parameters.Add(p1);

                res = cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            /*finally
            {
                con.Close();
            }*/
            return res;

        }

        public void PrintReader(SqlDataReader reader) {
            
            while (reader.Read()) {
                Console.WriteLine(reader[0].ToString()+"\t"+ reader[1].ToString()+ "\t"+reader[2].ToString()+"\t"+reader[3].ToString()+"\t"+reader[4].ToString());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int ch;

            EmployeeDAL ed = new EmployeeDAL();

            do
            {
                Console.WriteLine("++++++++++++ Menu ++++++++++++++");
                Console.WriteLine("\t1.Get Employee Data \n\t2. Get Employee Data using Employee Number \n\t3. Insert Employee Data \n\t4. Update Employee Data \n\t5. Delete Employee Data");
                Console.WriteLine("\nEnter Choice: ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        ed.PrintReader(ed.GetEmployeeData());
                        break;

                    case 2:
                        Console.WriteLine("\n Enter Employee Number: ");
                        int empNo = Convert.ToInt32(Console.ReadLine());

                        ed.PrintReader(ed.GetEmpUsingEmpNo(empNo));
                        break;

                    case 3:
                        Console.WriteLine("\nEnter Employee Details: \n Enter Employee Number:");
                        int eNo = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("\n Enter Employee Name: ");
                        string eNm = Console.ReadLine();

                        Console.WriteLine("\n Enter Salary: ");
                        int salary = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\n Enter Designation: ");
                        string designation = Console.ReadLine();

                        Console.WriteLine("\n Enter Department Number: ");
                        int deptNo = Convert.ToInt32(Console.ReadLine());

                        ed.InsertEmployee(eNo, eNm, salary, designation, deptNo);
                        Console.WriteLine("\n Data Entered Successfully");

                        break;


                    case 4:
                        Console.WriteLine("\nEnter Employee Details For Update: \n Enter Employee Number:");
                        int e_No = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("\n Enter Employee Name: ");
                        string e_Nm = Console.ReadLine();

                        Console.WriteLine("\n Enter Salary: ");
                        int sal = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\n Enter Designation: ");
                        string desig = Console.ReadLine();

                        Console.WriteLine("\n Enter Department Number: ");
                        int dept_No = Convert.ToInt32(Console.ReadLine());

                        ed.UpdateEmployee(e_No, e_Nm, sal, desig, dept_No);
                        Console.WriteLine("\n Data Updated Successfully");

                        break;

                    case 5:
                        Console.WriteLine("\n Enter Employee Number to delete: ");
                        int em_No = Convert.ToInt32(Console.ReadLine());

                        ed.DeleteEmployee(em_No);
                        Console.WriteLine("\n Data deleted Successfully");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice \n Please Select from 1 to 5 only.\n");
                        break;

                }
                Console.WriteLine("\n Do you want to continue ? \n Enter 'Y' or 'y' to continue\n");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'Y'|| ch == 'y');
        }
    }
}
