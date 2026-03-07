using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace VehicleRentalSystem
{
    internal class VehicleRental
    {
        class Vehicle
        {
            protected int vehicleId;
            protected string model;
            protected double rentPerDay;
            protected bool isRented;

            public Vehicle(int id, string model, double rent)
            {
                vehicleId = id;
                this.model = model;
                rentPerDay = rent;
                isRented = false;
            }

            public virtual double CalculateRent(int days)
            {
                return rentPerDay * days;
            }

            public void RentVehicle()
            {
                isRented = true;
            }

            public void ReturnVehicle()
            {
                isRented = false;
            }

            public virtual void Display()
            {
                Console.WriteLine("Vehicle ID: " + vehicleId);
                Console.WriteLine("Model: " + model);
                Console.WriteLine("Rent/Day: " + rentPerDay);
            }
        }

        class Car : Vehicle
        {
            public Car(int id, string model, double rent)
                : base(id, model, rent) { }

            public override void Display()
            {
                base.Display();
                Console.WriteLine("Type: Car");
            }
        }

        class Bike : Vehicle
        {
            public Bike(int id, string model, double rent)
                : base(id, model, rent) { }

            public override void Display()
            {
                base.Display();
                Console.WriteLine("Type: Bike");
            }
        }

        class Truck : Vehicle
        {
            public Truck(int id, string model, double rent)
                : base(id, model, rent) { }

            public override void Display()
            {
                base.Display();
                Console.WriteLine("Type: Truck");
            }
        }

        class Customer
        {
            public string Name { get; set; }

            public Customer(string name)
            {
                Name = name;
            }
        }

        class RentalTransaction
        {
            public static void Rent(Vehicle v, int days)
            {
                v.RentVehicle();
                Console.WriteLine("Total Rent: " + v.CalculateRent(days));
            }
        }
    }
}


