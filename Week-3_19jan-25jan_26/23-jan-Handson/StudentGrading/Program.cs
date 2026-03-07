namespace StudentGrading
{
    internal class Program
    {
 
            static void Main(string[] args)
            {
                Dictionary<int, int> stud = new Dictionary<int, int>();

                Console.WriteLine("Enter the number of students");
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter the roll no");
                    int roll = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Grade");
                    int grade = int.Parse(Console.ReadLine());

                    stud[roll] = grade;
                }

                // Func to calculate average grade
                Func<Dictionary<int, int>, double> avgGrade = dict =>
                {
                    int sum = 0;
                    foreach (int g in dict.Values)
                    {
                        sum += g;
                    }
                    return (double)sum / dict.Count;
                };

                Console.WriteLine("Avg Grade: " + avgGrade(stud));

                Console.WriteLine("Enter the Risk Threshold");
                int th = int.Parse(Console.ReadLine());

                // Predicate to identify risk
                Predicate<int> isRisk = grade => grade < th;

                Console.WriteLine("\nStudents at Risk:");
                foreach (var s in stud)
                {
                    if (isRisk(s.Value))
                        Console.WriteLine("Roll No: " + s.Key + ", Grade: " + s.Value);
                }

                // Update grade
                Console.Write("\nEnter roll number to update grade: ");
                int updateRoll = int.Parse(Console.ReadLine());

                Console.Write("Enter new grade: ");
                int newGrade = int.Parse(Console.ReadLine());

                // ❗ corrected variable name
                stud[updateRoll] = newGrade;

                // Re-check risk
                Console.WriteLine("\nStudents at Risk After Update:");
                foreach (var s in stud)
                {
                    if (isRisk(s.Value))
                        Console.WriteLine("Roll No: " + s.Key + ", Grade: " + s.Value);
                }
            }
        }
    }