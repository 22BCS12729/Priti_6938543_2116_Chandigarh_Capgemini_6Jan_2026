using static NumericOperations.Numeric;

namespace NumericOperations
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            Source obj = new Source();

            Console.WriteLine("Sum: " + obj.Sum(numbers));

            int? item = obj.GetItemAtIndex(numbers, 3);
            Console.WriteLine("Item at index 3: " + (item.HasValue ? item.Value.ToString() : "null"));

            List<int> result = obj.SplitAndReverse(numbers);
            Console.WriteLine("After Split and Reverse:");
            Console.WriteLine(string.Join(" ", result));
        }
    }
}