using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            int t = 5;
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your age");
                int age = int.Parse(Console.ReadLine());



                queue.Enqueue(new Person()
                {
                    Name = name,
                    Age = age
                });
            }
            for (int i = 0; i < t; i++)
            {
                Person p = (Person)queue.Dequeue();
                Console.WriteLine(p.ToString());
            }
        }
        public class Person
        {
            public string Name;
            public int Age;
            public override string ToString()
            {
                return Name + " : " + Age;
            }
        }
    }
}
