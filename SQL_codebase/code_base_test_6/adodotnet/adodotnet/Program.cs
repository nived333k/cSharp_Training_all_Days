using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace adodotnet
{
    //c. Using Ado.net classes/methods, insert employee record in the table by invoking the procedure  
   // d.Display all the records(including the newely added record)
    class Program
    {
        static void Main(string[] args)
        {
            //Program.connection();
            Program.showdata();
        }

        static void connection()
        {
            string cs = ConfigurationManager.ConnectionStrings["spdata"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
                    string query = "addemployee";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    Console.WriteLine("enter the employee name ");
                    string empname = Console.ReadLine();
                    Console.WriteLine("enter the employee salary ");
                    string empsal = Console.ReadLine();
                    Console.WriteLine("enter the employee type ");
                    string emptype = Console.ReadLine();

                    cmd.Parameters.Add(new SqlParameter("@empname", empname));
                    cmd.Parameters.Add(new SqlParameter("@empsal", empsal));
                    cmd.Parameters.Add(new SqlParameter("@emptype", emptype));
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        Console.WriteLine("the data is inserted");
                    }
                    else
                    {
                        Console.WriteLine("the data is not inserted");
                    }
                    Console.ReadLine();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();

            }
        }

        static void showdata()
        {
            string cs = ConfigurationManager.ConnectionStrings["spdata"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
                    string query = "select * from code_employee";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("id" +"  "+ dr[0]);
                        Console.WriteLine("name" +" " + dr[1]);
                        Console.WriteLine("salary" + " " +  dr[2]);
                        Console.WriteLine("type" +" " + dr[3]);
                    }
                    Console.ReadLine();

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();

            }
        }
    
}
}
