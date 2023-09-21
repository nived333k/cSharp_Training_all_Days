using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface IStudent

    {

        int StudentId { get; set; } // Property

        string Name { get; set; }   // Property

        void ShowDetails();         // Method

    }



    // Implement the interface in the Dayscholar class

    class Dayscholar : IStudent

    {

        public int StudentId { get; set; }

        public string Name { get; set; }



        // Constructor for Dayscholar

        public Dayscholar(int studentId, string name)

        {

            StudentId = studentId;

            Name = name;

        }



        // Implement the showDetails method for Dayscholar

        public void ShowDetails()

        {

            Console.WriteLine("Dayscholar Details:");

            Console.WriteLine("Student ID: " + StudentId);

            Console.WriteLine("Name: " + Name);

            // Add additional Dayscholar-specific details here

        }

    }



    // Implement the interface in the Resident class

    class Resident : IStudent

    {

        public int StudentId { get; set; }

        public string Name { get; set; }



        // Constructor for Resident

        public Resident(int studentId, string name)

        {

            StudentId = studentId;

            Name = name;

        }



        // Implement the showDetails method for Resident

        public void ShowDetails()

        {

            Console.WriteLine("Resident Details:");

            Console.WriteLine("Student ID: " + StudentId);

            Console.WriteLine("Name: " + Name);

            // Add additional Resident-specific details here

        }

    }



    class Program

    {

        static void Main(string[] args)

        {

            // Create instances of Dayscholar and Resident

            IStudent dayscholar = new Dayscholar(1, "John");

            IStudent resident = new Resident(2, "Alice");



            // Call the ShowDetails method on both instances

            dayscholar.ShowDetails();

            Console.WriteLine();

            resident.ShowDetails();

        }

    }
}
