using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ques_10
{
    class Program
    {
        static async Task Main(string[] args)
        {
            flower();
            GuestPicked();
            FoodArea();
            gift();
            functionStarted();
            Console.ReadKey();
        }
        static async void flower()
        {
            Console.WriteLine("Flower decorations to be completed on stage");
        }
        static async void GuestPicked()
        {
            Console.WriteLine("Chief guest to be picked up from the airport.");
            await Task.Delay(5000);
            Console.WriteLine("Chief Guest Arrived at stage");
        }
        static async void gift()
        {
            await Task.Delay(4000);
            Console.WriteLine("Arrange the gifts to be distributed in the stage ");
        }
        static async void functionStarted()
        {
            await Task.Delay(6000);
            Console.WriteLine("Started function as Chief guest has arrived at the venue. ");
        }
        static async void FoodArea()
        {
            Console.WriteLine("Co-ordinate with the caterers and set up the food area.");
            
        }
        
    }

}