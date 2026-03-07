using GradeCalculatorApp;

namespace GraduateCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                GradeCalculator calculator = new GradeCalculator();

                Console.Write("Enter student score: ");
                int score = int.Parse(Console.ReadLine());

                string grade = calculator.GetGrade(score);

                Console.WriteLine("Grade: " + grade);
            }
        }
    }

