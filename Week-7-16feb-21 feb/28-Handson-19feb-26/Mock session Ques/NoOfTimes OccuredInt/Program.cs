namespace NoOfTimes_OccuredInt
{
    internal class Program
    {
       static void Main()
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];

                string[] input = Console.ReadLine().Split(' ');

                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(input[i]);
                }

            // Call the function
            CountInteger.CountInt(arr);
            }
        }
    }
