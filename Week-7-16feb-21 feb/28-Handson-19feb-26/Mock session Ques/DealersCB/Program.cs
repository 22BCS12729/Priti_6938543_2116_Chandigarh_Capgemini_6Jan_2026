namespace DealersCB
{
    internal class Program
    {
        
            static void Main()
            {
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split(' ');

                    int cars = int.Parse(input[0]);
                    int bikes = int.Parse(input[1]);

                    int result = CarBikeDealers.CalculateTyres(cars, bikes);

                    Console.WriteLine(result);
                }
            }
        }

    }
