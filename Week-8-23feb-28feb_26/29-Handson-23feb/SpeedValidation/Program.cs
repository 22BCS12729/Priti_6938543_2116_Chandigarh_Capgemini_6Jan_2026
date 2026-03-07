namespace SpeedValidation
{
    internal class Program
    {
          static void Main(string[] args)
            {
                CarSpeed car = new CarSpeed();
                CarSpeedImplementation impl = new CarSpeedImplementation();

                try
                {
                    Console.WriteLine(impl.setCarSpeed(car, 60));
                }
                catch (SpeedInvalidException ex)
                {
                    Console.WriteLine("Custom Exception: " + ex.Message);
                }

                Console.ReadLine();
            }
        }
    }