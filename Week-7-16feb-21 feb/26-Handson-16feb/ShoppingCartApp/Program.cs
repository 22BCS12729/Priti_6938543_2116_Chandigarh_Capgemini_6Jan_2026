namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiscountService service = new DiscountService();

            Console.Write("Enter cart total: ");
            decimal total = decimal.Parse(Console.ReadLine());

            decimal finalAmount = service.ApplyDiscount(total);

            Console.WriteLine("Final amount after discount: " + finalAmount);
        }
    }
}