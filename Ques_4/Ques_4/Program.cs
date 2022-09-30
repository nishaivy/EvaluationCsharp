using System;
using System.Security.Cryptography.X509Certificates;

namespace abstraction
{
    abstract class Birds
    {
        //abstract method
        public abstract void Eat();
        //non-abstract method
        public void SetName( string name)
        {
            Console.WriteLine("Enter the bird name "+name);
        }
    }
    class GetName : Birds
    {
        public override void Eat()
        {
            return;
        }
    }
    class Flying : Birds
    {
        public override void Eat()
        {
            Console.WriteLine("\nParrot is flying");
        }
    }
    public class AbstractionDemo
    {
        public static void Main(string[] args)
        {
           
            Birds g = new GetName();
            g.Eat();
            g.SetName("Parrot");
            Birds birdCrow = new Flying();
            birdCrow.Eat();
          
        }
    }
}