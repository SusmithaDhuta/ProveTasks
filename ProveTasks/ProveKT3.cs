using System;
using System.Collections.Generic;
using System.Text;

namespace ProveTasks
{
    class ProveKT3
    {
        public static void Main(string[] args)
        {
            Car car = new Car(0); //Creating Object of class Car with 0 fuel(Gasoline)

            int fuel = int.Parse(Console.ReadLine()); //Reading input value from user 
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }

        public interface IVehicle // Defining IVehicle Interface
        {
            void Drive();   
            bool Refuel(int amount);
        }

        public class Car : IVehicle // Defining class Car Inheriting from Interface IVehicle
        {
            public int Fuel { get; set; } // Defining Fuel Property

            public Car(int fuel) // Car Constructor which takes Fuel as Parameter from user
            {
                Fuel = fuel;
            }

            public void Drive() //Implementing Drive method which is Defined in Interface IVehicle
            {
                if (Fuel > 0)
                {
                    Console.WriteLine("Driving");
                }
                else
                {
                    Console.WriteLine("No fuel");
                }
            }

            public bool Refuel(int amount)   //Implementing Refuel method which is Defined in Interface IVehicle
            {
                Fuel += amount;
                return true;
            }
        }


    }
    }
