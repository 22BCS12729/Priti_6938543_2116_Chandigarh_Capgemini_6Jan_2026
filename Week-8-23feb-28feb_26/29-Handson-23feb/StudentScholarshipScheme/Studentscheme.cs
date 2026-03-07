using System;
using System.Collections.Generic;
using System.Text;

namespace StudentScholarshipScheme
{
    internal class Studentscheme
    {
        public class Student
        {
            public string studentName { get; set; }
            public int studentId { get; set; }
            public int studentScore { get; set; }
            public string scholarshipScheme { get; set; }
        }

        public class ScholarshipImpl
        {
            private List<Student> students = new List<Student>();

            public void AddStudent(Student s)
            {
                if (s.studentScore >= 90)
                    s.scholarshipScheme = "Gold";
                else if (s.studentScore >= 75)
                    s.scholarshipScheme = "Silver";
                else if (s.studentScore >= 60)
                    s.scholarshipScheme = "Bronze";
                else
                    s.scholarshipScheme = "No Scholarship";

                students.Add(s);
            }

            public List<Student> GetStudentDetails(string scheme)
            {
                return students
                    .Where(s => s.scholarshipScheme == scheme)
                    .ToList();
            }

            public string DeleteStudent(int id)
            {
                var student = students.FirstOrDefault(s => s.studentId == id);

                if (student != null)
                {
                    students.Remove(student);
                    return "Student deleted successfully.";
                }

                return "Student not found.";
            }
        }
    }
}