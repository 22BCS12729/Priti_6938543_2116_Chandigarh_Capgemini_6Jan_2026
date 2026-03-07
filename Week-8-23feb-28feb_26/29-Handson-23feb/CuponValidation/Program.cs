using static CuponValidation.Validation;

namespace CuponValidation
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Product p = new Product("Laptop", 50000, "Laptop-20");
                Validator v = new Validator();

                Console.WriteLine(v.ValidateCoupon(p));
                Console.WriteLine("Net Price: " + v.NetPrice(p));
            }
            catch (InvalidCouponException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}