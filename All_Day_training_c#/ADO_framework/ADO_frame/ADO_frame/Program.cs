using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_frame
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.connection();


            Console.ReadLine();
            
        }


        static void connection()
        {
            //string cs = @"Data Source=ICS-LT-83GB893\SQLEXPRESS; initial catalog=northwind;integrated security=true;";
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using ( con = new SqlConnection(cs))
                {
                    //-------executeReader()------------
                    //string query = "spgetcustomer";
                    //SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.StoredProcedure;

                    ////or we can use the command text and connection
                    ////cmd.CommandText = query;
                    ////cmd.Connection = con;

                    ////command type - we need to execute the stored procedure
                    //con.Open();
                    //SqlDataReader dr = cmd.ExecuteReader();
                    //while (dr.Read())
                    //{
                    //    Console.WriteLine("id"+"  "+dr[0]);
                    //    Console.WriteLine("Name" + dr[1]);
                    //    Console.WriteLine("discription" + dr[3]);
                    //}

                    //-------executenonquery------------

                    //--------insert method-----------

                    //Console.WriteLine("enter the gamer_id");
                    //string id = Console.ReadLine();
                    //Console.WriteLine("enter the gamer_name");
                    //string name = Console.ReadLine();
                    //Console.WriteLine("enter the game_type");
                    //string type = Console.ReadLine();

                    //insert
                    //string query = "insert into gamers values(@id , @name , @type)";


                    //update
                    //string query = "update gamers set gamer_name = @name , game_type=@type where gamer_id=@id";

                    //delete
                    //string query = "delete from gamers where gamer_id=@id";

                    string query = "select max(salary) from gamers";

                    SqlCommand cmd = new SqlCommand(query, con);

                    //cmd.Parameters.AddWithValue("@id", id);
                    //cmd.Parameters.AddWithValue("@name", name);
                    //cmd.Parameters.AddWithValue("@type", type);

                    con.Open();
                    int a = (int)cmd.ExecuteScalar();
                    Console.WriteLine(a);
                    //if (a > 0)
                    //{
                    //    Console.WriteLine("data has been inserted succesfully");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("data was not inserted");
                    //}

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

            //try
            //{
            //    con.Open();


            //    if (con.State == ConnectionState.Open)
            //    {
            //        Console.WriteLine("Connection has been sucessfully...");

            //    }

            //}

            //catch(SqlException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    con.Close();

            //}

        }
    }
}
