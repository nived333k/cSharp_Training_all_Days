﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace anonymous
{
    
    //see peristence
    class Anon
    {
        static void Main(string[] args)
        {
            // WriteBinary();
            // ReadBinary();
            WriteData();
            ReadData();
            Console.Read();
        }



        static void WriteBinary()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("D:/Ics_Training_Each_Day/Day9_training",
                FileMode.Create)))
            {
                writer.Write("0x80234400");
                writer.Write("This is a new Binary File Creation Process..");
                writer.Write(true);
            }



        }
        static void ReadBinary()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("D:/Ics_Training_Each_Day/Day9_training",
                FileMode.Open)))
            {
                Console.WriteLine("Data 1 :" + reader.ReadInt32());
                Console.WriteLine("Data2 : " + reader.ReadString());
                Console.WriteLine("Data3 : " + reader.ReadBoolean());
            }
        }

        public static void ReadData()
        {
            FileStream fs = new FileStream("MyTextFile.txt", FileMode.Open,
                FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            //position the file pointer from the beginning
            sr.BaseStream.Seek(0, SeekOrigin.Begin);



            //read till the end of file



            string dataread = sr.ReadLine();

            while (dataread != null)
            {
                Console.WriteLine("{0}", dataread);
                dataread = sr.ReadLine();
            }
            sr.Close();
            fs.Close();



        }



        public static void WriteData()
        {
            FileStream fs = new FileStream("MyTextFile.Txt", FileMode.Append,
                FileAccess.Write);



            StreamWriter sw = new StreamWriter(fs);
            //prompt the user for some data
            Console.WriteLine("Enter a String of Data to write :");
            //store the entered data in a string
            string str = Console.ReadLine();



            //write the string data into the file
            sw.Write(str);



            //clear the buffer
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
