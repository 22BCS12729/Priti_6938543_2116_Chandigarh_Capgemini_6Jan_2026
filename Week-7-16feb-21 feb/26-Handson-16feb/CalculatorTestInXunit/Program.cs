namespace CalculatorTestInXunit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Addition: " + calc.Add(5, 3));
            Console.WriteLine("Subtraction: " + calc.Subtract(10, 4));
            Console.WriteLine("Multiplication: " + calc.Multiply(7, 6));

            try
            {
                Console.WriteLine("Division: " + calc.Divide(20, 4));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
