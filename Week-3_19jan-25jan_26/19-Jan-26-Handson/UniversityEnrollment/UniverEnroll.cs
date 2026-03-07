using System;
using System.Collections.Generic;
using System.Text;
namespace UniversityEnrollmentSystem
{
    
    class Person
    {
        protected int id;
        protected string name;
        protected string email;

        public Person(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }

        public virtual void DisplayProfile()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + email);
        }
    }

    // Derived Class - Student
    class Student : Person
    {
        List<Course> courses = new List<Course>();

        public Student(int id, string name, string email)
            : base(id, name, email) { }

        public void RegisterCourse(Course course)
        {
            courses.Add(course);
        }

        public override void DisplayProfile()
        {
            base.DisplayProfile();
            Console.WriteLine("Role: Student");
            Console.WriteLine("Courses Enrolled:");
            foreach (Course c in courses)
                Console.WriteLine("- " + c.CourseName);
        }
    }

 
    class Professor : Person
    {
        Course assignedCourse;

                    public Professor(int id, string name, string email)
                        : base(id, name, email) { }

                    public void AssignCourse(Course course)
                    {
                        assignedCourse = course;
                    }

                    public override void DisplayProfile()
                    {
                        base.DisplayProfile();
                        Console.WriteLine("Role: Professor");
                        if (assignedCourse != null)
                            Console.WriteLine("Teaching Course: " + assignedCourse.CourseName);
                    }
                }

    
                    class Staff : Person
                    {
                        string department;

                        public Staff(int id, string name, string email, string dept)
                            : base(id, name, email)
                        {
                            department = dept;
                        }

                        public override void DisplayProfile()
                        {
                            base.DisplayProfile();
                            Console.WriteLine("Role: Staff");
                            Console.WriteLine("Department: " + department);
                        }
                    }

              
                class Course
                {
                    public int CourseId { get; set; }
                    public string CourseName { get; set; }

                    public Course(int id, string name)
                    {
                        CourseId = id;
                        CourseName = name;
                    }
                }
            class Department
            {
                public string DeptName { get; set; }

                public Department(string name)
                {
                    DeptName = name;
                }
            }
        }
