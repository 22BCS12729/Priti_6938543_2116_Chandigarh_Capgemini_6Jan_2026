using DishOperations;

namespace AllSpanish
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                List<Dish> dishList = new List<Dish>
            {
                new Dish { dishName = "Pizza" },
                new Dish { dishName = "Pasta" },
                new Dish { dishName = "Burger" }
            };

                DishTest dt = new DishTest();

                var updatedList = dt.addYummyToName(dishList, " Yummy");

                Console.WriteLine("Updated Dishes:");
                foreach (var d in updatedList)
                {
                    Console.WriteLine(d.dishName);
                }

                long result = dt.count(updatedList, "Yummy");
                Console.WriteLine("Count: " + result);

                Console.ReadLine();
            }
        }
    }
