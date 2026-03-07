using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, decimal> prices = new Dictionary<string, decimal>()
        {
            {"apple",2},
            {"banana",1}
        };

        Dictionary<string, int> discount = new Dictionary<string, int>()
        {
            {"apple",2}
        };

        List<(string, int)> shopping = new List<(string, int)>()
        {
            ("apple",3),
            ("banana",5)
        };

        foreach (var item in shopping)
        {
            decimal price = prices[item.Item1];
            decimal total = price * item.Item2;

            Console.WriteLine($"{item.Item1} {price} {total}");
        }
    }
}