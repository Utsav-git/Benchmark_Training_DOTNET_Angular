using System;
using System.Data.SqlClient;
using System.Data;

namespace ADO_Disconnected_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            try {
                int ch;

                SqlConnection con = new SqlConnection("Server = UTSAV\\MSSQLSERVER01; Database = EmpDB; trusted_connection = true");
                SqlCommand cmd = new SqlCommand("Select * from course", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "course");
                DataTable table = ds.Tables["course"];
                
                do
                {
                    Console.WriteLine("++++++++++++ Menu ++++++++++++++");
                    Console.WriteLine("\t1.Get Course Details \n\t2. Get Course Details using Course ID \n\t3. Insert Course Details \n\t4. Update Course Details \n\t5. Delete Course Details ");
                    Console.WriteLine("\nEnter Choice: ");
                    ch = Convert.ToInt32(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:
                            foreach (DataRow r in table.Rows) {
                                Console.WriteLine(r[0].ToString() + "/" + r[1].ToString() + "/" + r[2].ToString()+ "/" + r[3].ToString());
                            }
                            break;

                        case 2:
                            Console.WriteLine("\n Enter Course ID: ");
                            int c_ID = Convert.ToInt32(Console.ReadLine());

                            DataRow[] rows = table.Select("course_ID = "+c_ID);

                            Console.WriteLine("\n Course Details: \n");
                            foreach (DataRow row in rows) {
                                Console.WriteLine(row[0].ToString() + "/" + row[1].ToString() + "/" + row[2].ToString() + "/" + row[3].ToString());
                            }
                            break;

                        case 3:
                            Console.WriteLine("\nEnter Course Details: \n Enter Course ID:");
                            int c_ID1= Convert.ToInt32(Console.ReadLine());


                            Console.WriteLine("\n Enter Course Name: ");
                            string c_Name1= Console.ReadLine();

                            Console.WriteLine("\n Enter Instructor Name: ");
                            string inst_Name1 = Console.ReadLine();

                            Console.WriteLine("\n Enter Course Fees: ");
                            decimal fees1 = Convert.ToDecimal(Console.ReadLine());

                            DataRow newRow = table.NewRow();
                            newRow["course_ID"] = c_ID1;
                            newRow["course_Name"] = c_Name1;
                            newRow["instructor"] = inst_Name1;
                            newRow["fees"] = fees1;

                            table.Rows.Add(newRow);
                            adapter.Update(table);
                            Console.WriteLine("\n Course Details Entered Successfully");

                            break;


                        case 4:
                            Console.WriteLine("\nEnter Course Details For Update: \n Enter Course ID:");
                            int c_ID2 = Convert.ToInt32(Console.ReadLine());


                            Console.WriteLine("\n Enter Course Name: ");
                            string c_Name2 = Console.ReadLine();

                            Console.WriteLine("\n Enter Instructor Name: ");
                            string inst_Name2 = Console.ReadLine();

                            Console.WriteLine("\n Enter Course Fees: ");
                            decimal fees2= Convert.ToDecimal(Console.ReadLine());

                            DataRow[] r1 = table.Select("course_ID = " +c_ID2);

                            DataRow updateRow = r1[0];
                            updateRow["course_Name"] = c_Name2;
                            updateRow["instructor"] = inst_Name2;
                            updateRow["fees"] = fees2;

                            adapter.Update(table);

                            Console.WriteLine("\n Course Details Updated Successfully");

                            break;

                        case 5:
                            Console.WriteLine("\n Enter Course ID to delete: ");
                            int c_ID3= Convert.ToInt32(Console.ReadLine());

                            DataRow[] r2 = table.Select("course_ID = "+c_ID3);
                            DataRow deleteRow = r2[0];
                            //table.Rows.Remove(deleteRow);
                            deleteRow.Delete();
                            adapter.Update(ds, "course");
                            Console.WriteLine("\n Course Details deleted Successfully");
                            break;

                        default:
                            Console.WriteLine("Invalid Choice \n Please Select from 1 to 5 only.\n");
                            break;

                    }
                    Console.WriteLine("\n Do you want to continue ? \n Enter 'Y' or 'y' to continue\n");
                    ch = Convert.ToChar(Console.ReadLine());
                } while (ch == 'Y' || ch == 'y');
            }
            catch (SqlException e) {
                Console.WriteLine(e.Message);
            }


        }
    }
}
