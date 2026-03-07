using System;
using System.Collections.Generic;
using System.Linq;

namespace DishOperations
{
    public class Dish
    {
        public string dishName { get; set; }
    }

    public class DishTest
    {
        public List<Dish> addYummyToName(List<Dish> dishes, string value)
        {
            return dishes
                .Select(d => new Dish { dishName = d.dishName + value })
                .ToList();
        }

        public long count(List<Dish> dishes, string value)
        {
            return dishes
                .Where(d => d.dishName.Contains(value))
                .LongCount();
        }
    }
}

   