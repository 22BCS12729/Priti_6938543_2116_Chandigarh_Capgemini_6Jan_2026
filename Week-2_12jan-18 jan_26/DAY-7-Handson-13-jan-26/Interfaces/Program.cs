namespace Interfaces
{
    internal class InterfaceDemo
    {
        class clsInterface
        {
            static void Main()
            {
                c3 b1 = new c3();

                Inter1 b2 = (Inter1)b1;
                Inter2 b3 = (Inter2)b1;

                b2.f1();
                b3.f1();

                Console.Read();
            }
        }
    }
}
