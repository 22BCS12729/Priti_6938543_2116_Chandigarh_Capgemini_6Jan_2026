using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NumericOperations
{
    internal class Numeric
    {
        public class Source
        {
            public int Sum(List<int> numbers)
            {
                return numbers.Sum();
            }

            public int? GetItemAtIndex(List<int> numbers, int index)
            {
                if (index >= 0 && index < numbers.Count)
                    return numbers[index];
                return null;
            }

            public List<int> SplitAndReverse(List<int> numbers)
            {
                int mid = numbers.Count / 2;

                List<int> firstHalf = numbers.Take(mid).ToList();
                List<int> secondHalf = numbers.Skip(mid).ToList();

                firstHalf.Reverse();
                secondHalf.Reverse();

                List<int> result = new List<int>();
                result.AddRange(firstHalf);
                result.AddRange(secondHalf);

                return result;
            }
        }

    }
}
