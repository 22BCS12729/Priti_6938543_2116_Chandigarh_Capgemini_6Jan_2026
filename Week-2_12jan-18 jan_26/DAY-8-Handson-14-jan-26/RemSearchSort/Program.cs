namespace RemSearchSort
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 54, 26, 78, 32, 55 };
            int size = 5;
            int search = 78;

            int[] output = RemoveSearchSort. RemoveSearchAndSort(arr, size, search);

            for (int i = 0; i < output.Length; i++)
                Console.Write(output[i] + " ");
        }

    }
}
