namespace RemoveARrray
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] result = RemDuplicate.RemoveDuplicateElements(arr, size);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
  
