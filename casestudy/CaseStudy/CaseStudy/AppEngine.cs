using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    public class AppEngine
    {
         
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Enrollment> enrollments = new List<Enrollment>();

        // Constructor
        public AppEngine()
        {
            
            InitializeData();
        }
        private void InitializeData()
        {
            //students
            //students.Add(new Student(1021, "Nived k", "2001-12-20"));
            //students.Add(new Student(6969, "Kiran S", "2001-12-05"));
            //students.Add(new Student(4201, "Kevin Mani", "2001-09-9"));


           //course
            //courses.Add(new Course(9876, "Artificial intelligence"));
            //courses.Add(new Course(9823, "Marine Engineering"));
            //courses.Add(new Course(9123, "Petroleum engineering "));
            //courses.Add(new Course(9125, "Aero space"));
            //courses.Add(new Course(9834, "Textile engineering"));
            //courses.Add(new Course(9555, "chemical engineering"));

    
        }

        public void RegisterStudent(Student student)
        {
            students.Add(student);
        }

        public void IntroduceCourse(Course course)
        {
            courses.Add(course);
        }

        public void EnrollStudent(Student student, Course course)
        {
            DateTime enrollmentDate = DateTime.Now;
            enrollments.Add(new Enrollment(student, course, enrollmentDate));
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public List<Course> GetCourses()
        {
            return courses;
        }

        public List<Enrollment> GetEnrollments()
        {
            return enrollments;
        }
    }
}

