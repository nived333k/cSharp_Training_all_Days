using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CaseStudy
{
        
    public class UserInterface : IUserInterface
    {
        private AppEngine appEngine;

        public UserInterface(AppEngine appEngine)
        {
            this.appEngine = appEngine;
        }

        public void ShowFirstScreen()
        {
            Console.WriteLine("Welcome to SMS (Student Management System)");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin\n3. Exit");
            Console.Write("Enter your choice (1, 2, or 3): ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ShowStudentScreen();
                    break;
                case 2:
                    ShowAdminScreen();
                    break;
                case 3:
                    Console.WriteLine("Exiting the program.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    ShowFirstScreen();
                    break;
            }
        }

        public void ShowStudentScreen()
        {
            Console.WriteLine("Student Menu:");
            Console.WriteLine("1. Show all Courses");
            Console.WriteLine("2. Register for a Course");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice 1 , 2 or 3: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowAllCoursesScreen();
                    break;
                case 2:
                    ShowStudentRegistrationScreen();
                    break;
                case 3:
                    Console.WriteLine("Exiting Student NAme Menu.");
                    ShowFirstScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option 1 , 2 or 3.");
                    ShowStudentScreen();
                    break;
            }
        }

        public void ShowAdminScreen()
        {
            Console.WriteLine("Admin Menu:");
            Console.WriteLine("1. Introduce New Course");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    IntroduceNewCourseScreen();
                    break;
                case 2:
                    ShowAllStudentsScreen();
                    break;
                case 3:
                    Console.WriteLine("Exiting Admin Menu.");
                    ShowFirstScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option 1 ,  2 or 3.");
                    ShowAdminScreen();
                    break;
            }
        }

        public void ShowAllStudentsScreen()
        {
            Console.WriteLine("List of Students:");
            foreach (Student student in appEngine.GetStudents())
            {
                Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}, Date of Birth: {student.DateOfBirth}");
            }
            Console.WriteLine("Press Enter to return to the previous menu");
            Console.ReadLine();
            ShowAdminScreen();
        }

         public  void ShowStudentRegistrationScreen()
        {
            string cs = ConfigurationManager.ConnectionStrings["studentreg"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
                    Console.WriteLine("enter the student_id");
                    string studentId = Console.ReadLine();
                    Console.WriteLine("enter the student_name");
                    string studentName = Console.ReadLine();
                    Console.WriteLine("enter the student_dob");
                    string studentdob = Console.ReadLine();


                    string query = "insert into studentregDB values(@studentId , @studentName , @studentdob)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@studentId",studentId);
                    cmd.Parameters.AddWithValue("@studentName", studentName);
                    cmd.Parameters.AddWithValue("@studentdob", studentdob);

                    con.Open();
                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                    {
                        Console.WriteLine("The students has been added to DataBase");
                    }
                    else
                    {
                        Console.WriteLine("The data is not inserted");
                    }
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
            Console.WriteLine("Press Enter to return to the previous menu...");

            Console.ReadLine();
            ShowStudentScreen();
            




            //Console.Write("Enter Student ID: ");
            //int studentId = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Student Name: ");
            //string studentName = Console.ReadLine();
            //Console.Write("Enter Student Date of Birth (yyyy-MM-dd): ");
            //string stddob = Console.ReadLine();

            //appEngine.RegisterStudent(new Student(studentId, studentName, stddob));
            //Console.WriteLine("Student registered successfully.");
            //Console.WriteLine("Press Enter to return to the previous menu...");
            //Console.ReadLine();
            //ShowStudentScreen();
        }

        public void IntroduceNewCourseScreen()
        {
            Console.Write("Enter Course ID: ");
            int courseId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Course Name: ");
            string courseName = Console.ReadLine();

            appEngine.IntroduceCourse(new Course(courseId, courseName));
            Console.WriteLine("Course introduced successfully.");
            Console.WriteLine("Press Enter to return to the previous menu...");
            Console.ReadLine();
            ShowAdminScreen();
        }

        public void ShowAllCoursesScreen()
        {
            Console.WriteLine("List of Courses:");
            foreach (Course course in appEngine.GetCourses())
            {
                Console.WriteLine($"Course ID: {course.CourseId}, Name: {course.CourseName}");
            }
            Console.WriteLine("Press Enter to return to the previous menu...");
            Console.ReadLine();
            ShowStudentScreen();
        }
    }
}
    
