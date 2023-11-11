using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileandtext
{
    class Program
    {
        static void Main(string[] args)
        {
            // specify the path

            string path = @"D:\Ics_Training_Each_Day\CSharp_Exams\Csharp_code_Base_Exam4\example";

            try
            {
                using(StreamWriter writer=new StreamWriter(@"D:\Ics_Training_Each_Day\CSharp_Exams\Csharp_code_Base_Exam4\example", true))
                {
                    string append = "my name is nived ";

                    writer.WriteLine(append);

                    writer.Close();
                }
                Console.WriteLine("text is appened success");
            }
            catch (Exception e)
            {
                Console.WriteLine("error");

            }
        }
    }
}
