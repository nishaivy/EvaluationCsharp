using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ques_3
{
    public class FirstInterface
    {
        public static void Main(string[] args) 
        { 
            Car car = new Car(0);
            Console.WriteLine("Enter the amount of petrol/diesel to refuel");
            int fuel = int.Parse(Console.ReadLine()); 
            if (car.Refuel(fuel)) { 
                car.Drive(); 
            }
        }
        public interface IVehicle {
            void Drive(); 
            bool Refuel(int amount); 
        }
        public class Car : IVehicle 
        {
            public int Fuel
            { 
                get; 
                set; 
            } 
            public Car(int fuel) 
            { 
                Fuel = fuel;
            }
            public void Drive() 
            { 
                if (Fuel > 0)
                { 
                    Console.WriteLine("The car is Driving"); 
                } else {
                    Console.WriteLine("No fuel in the Car"); 
                }
            }
            public bool Refuel(int amount) 
            {
                Fuel += amount; 
                return true;
            } 
        }
    }



}
