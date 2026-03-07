using static StudentScholarshipScheme.Studentscheme;

namespace StudentScholarshipScheme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScholarshipImpl impl = new ScholarshipImpl();

            impl.AddStudent(new Student { studentName = "Krishna", studentId = 1, studentScore = 95 });
            impl.AddStudent(new Student { studentName = "Amit", studentId = 2, studentScore = 80 });
            impl.AddStudent(new Student { studentName = "Riya", studentId = 3, studentScore = 65 });

            var goldStudents = impl.GetStudentDetails("Gold");

            Console.WriteLine("Gold Scholarship Students:");
            foreach (var s in goldStudents)
            {
                Console.WriteLine(s.studentName);
            }

            Console.WriteLine(impl.DeleteStudent(2));

            Console.ReadLine();
        }
    }
}