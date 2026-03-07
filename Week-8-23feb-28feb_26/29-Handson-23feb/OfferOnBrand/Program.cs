namespace OfferOnBrand
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                List<Model> modelList = new List<Model>()
            {
                new Model { ModelName = "BMW", CarSpeed = 200 },
                new Model { ModelName = "Audi", CarSpeed = 180 },
                new Model { ModelName = "Tesla", CarSpeed = 220 }
            };

                Implementation impl = new Implementation();

                var names = impl.GetModelName(modelList);
                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }

                var result = impl.GetModelInfo(modelList, "Audi", 180);

                if (result != null)
                {
                    Console.WriteLine("Model: " + result.ModelName +
                                      ", Speed: " + result.CarSpeed);
                }
                else
                {
                    Console.WriteLine("Model not found");
                }

                Console.ReadLine();
            }
        }
    }
