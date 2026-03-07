using UniversityEnrollmentSystem;

namespace UniversityEnrollment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                Course c1 = new Course(101, "C# Programming");
                Course c2 = new Course(102, "Data Structures");

                Student s1 = new Student(1, "Priti", "priti@gmail.com");
                s1.RegisterCourse(c1);
                s1.RegisterCourse(c2);

                Professor p1 = new Professor(10, "Dr. Sharma", "sharma@gmail.com");
                p1.AssignCourse(c1);

                Staff st1 = new Staff(20, "Anil", "anil@gmail.com", "Administration");

                Console.WriteLine("---- Student Profile ----");
                s1.DisplayProfile();

                Console.WriteLine("\n---- Professor Profile ----");
                p1.DisplayProfile();

                Console.WriteLine("\n---- Staff Profile ----");
                st1.DisplayProfile();
            }
        }
    }
}
