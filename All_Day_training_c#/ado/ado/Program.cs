using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ado
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            UpdateData();
            SelectData();
            Console.Read();
        }

        static void SelectData()
        {
            //get the connection object
            con = GetConnection();
            //issue the command
            //  cmd = new SqlCommand("select * from emp", con); or
            cmd = new SqlCommand("select * from emp");
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Console.WriteLine(dr[0] + " "+dr[1] +" "+dr[2]+" "+dr[3]+" "+dr[4]);
                Console.WriteLine("empno :" + " " + dr[0]);
                Console.WriteLine("ename :" + " " + dr[1]);
                Console.WriteLine("ejob :" + " " + dr[2]);
                Console.WriteLine("emgr_id :" + " " + dr[3]);
                Console.WriteLine("ehire_date :" + " " + dr[4]);
                Console.WriteLine("salary :" + " " + dr[5]);
                Console.WriteLine("comm :" + " " + dr[6]);
                Console.WriteLine("deptno :" + " " + dr[7]);
                Console.WriteLine("---------------------------");
            }

        }
        static SqlConnection GetConnection()
        {
            //when windows authenticated
            con = new SqlConnection(@"Data Source=ICS-LT-83GB893\SQLEXPRESS;Initial Catalog=assignment_2;" +
                "Integrated Security=True");
            con.Open();
            return con;
            //when sql authenticated
            // con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;Initial Catalog=InfiniteDB;"+
            //"user id=sa;password=pwd);
        }
        static void UpdateData()
        {

            con = GetConnection();



            try
            {
                Console.Write("Enter Employee Number: ");
                int empNo = int.Parse(Console.ReadLine());



                Console.Write("Enter New Salary: ");
                decimal newSalary = decimal.Parse(Console.ReadLine());



                cmd = new SqlCommand("UPDATE EMP SET Salary = @NewSalary WHERE EmpNo = @EmpNo", con);
                cmd.Parameters.AddWithValue("@NewSalary", newSalary);
                cmd.Parameters.AddWithValue("@EmpNo", empNo);



                int rowsAffected = cmd.ExecuteNonQuery();



                if (rowsAffected > 0)
                {
                    Console.WriteLine("Update successful. Rows affected: " + rowsAffected);
                }
                else
                {
                    Console.WriteLine("No records updated.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating data: " + ex.Message);
            }

        }
    }
}