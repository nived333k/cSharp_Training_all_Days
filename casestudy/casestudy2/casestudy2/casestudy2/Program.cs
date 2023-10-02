using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using casestudy1;
namespace casestudy2
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }
    }
    public class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;

        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }

        public Student Student
        {
            get { return student; }
        }

        public Course Course
        {
            get { return course; }
        }

        public DateTime EnrollmentDate
        {
            get { return enrollmentDate; }
        }



    }
    public class AppEngine
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Enroll> enrollments = new List<Enroll>();

        public void Introduce(Course course)
        {
            courses.Add(course);
        }

        public void Register(Student student)
        {
            students.Add(student);
        }

        public Student[] ListOfStudents()
        {
            return students.ToArray();
        }

        public Course[] ListOfCourses()
        {
            return courses.ToArray();
        }

        public void Enroll(Student student, Course course)
        {
            DateTime enrollmentDate = DateTime.Now;
            Enroll enrollment = new Enroll(student, course, enrollmentDate);
            enrollments.Add(enrollment);
        }

        public Enroll[] ListOfEnrollments()
        {
            return enrollments.ToArray();
        }
    }

    public class Info
    {
        // Existing code for displaying Student details
        public void Display(Student student)
        {
            Console.WriteLine("Student ID: " + student.Id);
            Console.WriteLine("Student Name: " + student.Name);
            Console.WriteLine("Date of Birth: " + student.DateofBirth);
        }

        // New method for displaying Course details
        public void Display(Course course)
        {
            Console.WriteLine("Course ID: " + course.CourseId);
            Console.WriteLine("Course Name: " + course.CourseName);
            
        }

        // New method for displaying Enrollment details
        public void Display(Enroll enrollment)
        {
            Console.WriteLine("Enrollment Date: " + enrollment.EnrollmentDate.ToString("yyyy-MM-dd HH:mm:ss"));
            Display(enrollment.Student);
            Display(enrollment.Course);
            Console.WriteLine();
        }
    }

    public class App
    {
        static void Main()
        {
            AppEngine appEngine = new AppEngine();
            Info info = new Info();

            // Create students
            Console.Write("Enter the number of students: ");
            int numStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Enter details for Student {i + 1}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Date of Birth (yyyy-MM-dd): ");
                string dob = Console.ReadLine();

                Student student = new Student(id, name, dob);
                appEngine.Register(student);
            }

            // Create courses
            Console.Write("Enter the number of courses: ");
            int numCourses = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCourses; i++)
            {
                Console.WriteLine($"Enter details for Course {i + 1}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                

                Course course = new Course(id, name);
                appEngine.Introduce(course);
            }

            // Enroll students in courses
            Console.Write("Enter the number of enrollments: ");
            int numEnrollments = int.Parse(Console.ReadLine());
            for (int i = 0; i < numEnrollments; i++)
            {
                Console.WriteLine($"Enter details for Enrollment {i + 1}");
                Console.Write("Student ID: ");
                int studentId = int.Parse(Console.ReadLine());
                Console.Write("Course ID: ");
                int courseId = int.Parse(Console.ReadLine());

                Student student = appEngine.ListOfStudents().FirstOrDefault(s => s.Id == studentId);
                Course course = appEngine.ListOfCourses().FirstOrDefault(c => c.CourseId== courseId);

                if (student != null && course != null)
                {
                    appEngine.Enroll(student, course);
                }
                else
                {
                    Console.WriteLine("Invalid Student ID or Course ID. Enrollment skipped.");
                }
            }

            // Display the list of students, courses, and enrollments
            Console.WriteLine("\nList of Students:");
            foreach (Student student in appEngine.ListOfStudents())
            {
                info.Display(student);
            }

            Console.WriteLine("\nList of Courses:");
            foreach (Course course in appEngine.ListOfCourses())
            {
                info.Display(course);
            }

            Console.WriteLine("\nList of Enrollments:");
            foreach (Enroll enrollment in appEngine.ListOfEnrollments())
            {
                info.Display(enrollment);
            }
        }
    }
}