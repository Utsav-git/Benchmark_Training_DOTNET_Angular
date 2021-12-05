using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace MVC_Demo.DAL
{
    public class EmployeeDAL
    {
        public SqlDataReader GetEmpData() {
            SqlConnection con = new SqlConnection("Server = UTSAV\\MSSQLSERVER01; Database = EmpDB; trusted_connection = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employee", con);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public SqlDataReader GetEmpDataUsingEmpNo(int emp_No)
        {
            SqlDataReader reader = null;
            try {
                SqlConnection con = new SqlConnection("Server = UTSAV\\MSSQLSERVER01; Database = EmpDB; trusted_connection = true");
                con.Open();

                SqlCommand cmd = new SqlCommand("GetEmpUsingEmpNo", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("emp_No", emp_No);
                cmd.Parameters.Add(p1);

                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex) {
                Console.WriteLine(ex.Message);
                throw;
            }
            return reader;
        }

        public int InsertEmp(int emp_No, string emp_Name, int salary, string designation, int dept_No) {
            int res = 0;
            try
            {
                SqlConnection con = new SqlConnection("Server = UTSAV\\MSSQLSERVER01; Database = EmpDB; trusted_connection = true");
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("emp_No", emp_No);
                cmd.Parameters.AddWithValue("emp_Name", emp_Name);
                cmd.Parameters.AddWithValue("salary", salary);
                cmd.Parameters.AddWithValue("designation", designation);
                cmd.Parameters.AddWithValue("dept_No", dept_No);

                res = cmd.ExecuteNonQuery();

                con.Close();

            }
            catch (SqlException ex) {
                Console.WriteLine(ex.Message);
                throw;
            }
            return res;

        }

        public int UpdateEmp(int emp_No, string emp_Name, int salary, string designation, int dept_No)
        {
            int res = 0;
            try
            {
                SqlConnection con = new SqlConnection("Server = UTSAV\\MSSQLSERVER01; Database = EmpDB; trusted_connection = true");
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("emp_No", emp_No);
                cmd.Parameters.AddWithValue("emp_Name", emp_Name);
                cmd.Parameters.AddWithValue("salary", salary);
                cmd.Parameters.AddWithValue("designation", designation);
                cmd.Parameters.AddWithValue("dept_No", dept_No);

                res = cmd.ExecuteNonQuery();

                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return res;
        }
    }
}