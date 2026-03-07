using System;
using System.Collections.Generic;
using System.Text;

namespace MiniProject
{
    internal class StudenMangSystem
    {

        // =========================
        // FUNCTIONS (Same Class)
        // =========================

       public  static void GetStudentsOlderThan21(List<Student> students)
        {
            Console.WriteLine("\nStudents older than 21:");
            var result = students.Where(s => s.Age > 21);

            foreach (var s in result)
                Console.WriteLine(s.Name);
        }

       public  static void GetStudentEnrollments(
            List<Student> students,
            List<Course> courses,
            List<Enrollment> enrollments)
        {
            Console.WriteLine("\nStudent with Courses:");

            var result = from s in students
                         join e in enrollments on s.StudentID equals e.StudentID
                         join c in courses on e.CourseID equals c.CourseID
                         select new { s.Name, c.CourseName };

            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.CourseName}");
        }

       public  static void GetTopYoungestStudents(List<Student> students)
        {
            Console.WriteLine("\nTop 2 Youngest Students:");

            var result = students.OrderBy(s => s.Age).Take(2);

            foreach (var s in result)
                Console.WriteLine($"{s.Name} - {s.Age}");
        }
    }

    // =========================
    // ENTITY CLASSES
    // =========================

  public  class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentID { get; set; }
    }

    class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }

    class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int DepartmentID { get; set; }
    }

    class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public string Grade { get; set; }
    }
}

