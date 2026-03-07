namespace CountryCodeValidation
{
    internal class Program
    {
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine(RepositoryImplementation.GetCountry("75"));
                    Console.WriteLine(RepositoryImplementation.GetCountry("908"));
                    Console.WriteLine(RepositoryImplementation.GetCountry("011"));
                    Console.WriteLine(RepositoryImplementation.GetCountry("500"));
                }
                catch (InvalidCodeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadLine();
            }
        }
    }