namespace MaxScored
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter no of semesters: ");
            int semesters = int.Parse(Console.ReadLine());

            for (int i = 1; i <= semesters; i++)
            {
                Console.Write("Enter no of subjects in " + i + " semester: ");
                int subjects = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter marks obtained in semester " + i + ":");

                int result = CalculateMaxScore.Calculate(subjects);

                if (result == -1)  
                    return;

                Console.WriteLine("Maximum mark in " + i + " semester: " + result);
            }
        }

    }
}