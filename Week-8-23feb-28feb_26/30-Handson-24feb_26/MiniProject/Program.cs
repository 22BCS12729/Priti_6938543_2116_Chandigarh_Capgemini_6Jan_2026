namespace MiniProject
{
    internal class Program
    {
          // =========================
            // MAIN METHOD (Only Execution)
            // =========================
            static void Main(string[] args)
            {
                // Seed Data
                List<Student> students = new List<Student>
        {
            new Student { StudentID = 1, Name = "Alice", Age = 20, DepartmentID = 1 },
            new Student { StudentID = 2, Name = "Bob", Age = 23, DepartmentID = 1 },
            new Student { StudentID = 3, Name = "Charlie", Age = 22, DepartmentID = 2 },
            new Student { StudentID = 4, Name = "David", Age = 24, DepartmentID = 2 },
            new Student { StudentID = 5, Name = "Eva", Age = 19, DepartmentID = 3 }
        };

                List<Department> departments = new List<Department>
        {
            new Department { DepartmentID = 1, DepartmentName = "Computer Science" },
            new Department { DepartmentID = 2, DepartmentName = "Electronics" },
            new Department { DepartmentID = 3, DepartmentName = "Mechanical" }
        };

                List<Course> courses = new List<Course>
        {
            new Course { CourseID = 1, CourseName = "Databases", DepartmentID = 1 },
            new Course { CourseID = 2, CourseName = "Algorithms", DepartmentID = 1 },
            new Course { CourseID = 3, CourseName = "Circuits", DepartmentID = 2 },
            new Course { CourseID = 4, CourseName = "Thermodynamics", DepartmentID = 3 }
        };

                List<Enrollment> enrollments = new List<Enrollment>
        {
            new Enrollment { EnrollmentID = 1, StudentID = 1, CourseID = 1, Grade = "A" },
            new Enrollment { EnrollmentID = 2, StudentID = 2, CourseID = 1, Grade = "B" },
            new Enrollment { EnrollmentID = 3, StudentID = 2, CourseID = 2, Grade = "A" },
            new Enrollment { EnrollmentID = 4, StudentID = 3, CourseID = 3, Grade = "C" },
            new Enrollment { EnrollmentID = 5, StudentID = 4, CourseID = 2, Grade = "A" }
        };

            // Call Functions
            StudenMangSystem. GetStudentsOlderThan21(students);
            StudenMangSystem. GetStudentEnrollments(students, courses, enrollments);
            StudenMangSystem. GetTopYoungestStudents(students);

                Console.ReadLine();
            }
        }
    }
