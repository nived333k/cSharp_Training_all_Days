using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // SelectData();
            //query();
            insert();
      
        }


        static void SelectData()
        {
            con = GetConnection();
            //string cs = @"data source=ICS-LT-83GB893\SQLEXPRESS;database =assignment_2; integrated security=SSPI";
            //SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from emp", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
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
            dr.Close();
            con.Close();
            Console.ReadLine();

        }
        static SqlConnection GetConnection()
        {
            string cs = @"data source=ICS-LT-83GB893\SQLEXPRESS;database =assignment_2; integrated security=SSPI";
            SqlConnection con = new SqlConnection(cs);
            return con;

        }


        static void query()
        {
            con = GetConnection();
            SqlCommand cmd = new SqlCommand("select COUNT(ename) from emp", con);
            con.Open();
            int totalrows = (int)cmd.ExecuteScalar();
            Console.WriteLine("Total rows = "+totalrows.ToString());
            Console.ReadLine();

        }

        static void insert()
        {
            con = GetConnection();
            cmd = new SqlCommand("insert into emp values (8981,'nnk','well wisher',3456,'1901-12-20',90000,null,20)", con);
            con.Open();
            int totalrowsinserted = cmd.ExecuteNonQuery();
            Console.WriteLine("total rows inserted = "+totalrowsinserted);
            Console.ReadLine();

        }
    }
        
}
