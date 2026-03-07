using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleToPurchase
{
    
        public class Vehicle
        {
            public string name;
            public double price;

            public Vehicle(string name, double price)
            {
                this.name = name;
                this.price = price;
            }
        }

        public class VehicleImplementation
        {
            public double SumOfPrices(List<Vehicle> vehicles)
            {
                return vehicles.Sum(v => v.price);
            }

            public List<string> GetVehicleList(List<Vehicle> vehicles)
            {
                return vehicles
                       .Where(v => v.price > 25000)
                       .Select(v => v.name)
                       .ToList();
            }

            public double MaxPrice(List<Vehicle> vehicles)
            {
                return vehicles.Max(v => v.price);
            }
        }

    }

