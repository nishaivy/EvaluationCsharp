// C# program to illustrate the
// concept of inheritance
using System;
namespace Ques_2 {

// Base class
class Phonebook {


	public string name;
	public string Prof;
	public int age;
	public double num;

		public void readers(string name, string Prof, int age,double num)
		{
			this.name = name;
			this.Prof = Prof;
			this.age = age;
            this.num = num;

            

            if (age < 18)
            {
                //Console.Write("Services and Professionals:\n");
                Console.WriteLine("\n#################################\n");
                Console.WriteLine("\nStudents:\n");
                Console.Write(" Myself: " + name);
                //Console.Write("Prof: " + Prof);
                Console.Write(" age: " + age);
                Console.Write(" num: " + num);
               
            }
            else
            {
                Console.WriteLine("\n#################################\n"); 
                Console.WriteLine("\nCitizens:\n");
                Console.Write(" Myself: " + name);
                Console.Write(" age: " + age);
                Console.Write(" num: " + num);
      
            }

        }
}


    class Profession : Phonebook
    {


        public Profession(string name, string Prof, int age, double num)
        {
            this.name = name;
            this.Prof = Prof;
            this.age = age;
            this.num = num;
            Console.WriteLine("\n#################################\n");
            Console.WriteLine("\nServices and Professionals:\n");
            Console.Write(" Myself: " + name);
            Console.Write(" Prof: " + Prof);
            Console.Write(" age: " + age);
            Console.Write(" num: " + num);
         
        }
    }

    class Program {

	// Main Method
	static void Main(string[] args)
	{

            // creating object of derived class
           
            Profession g = new Profession("Kirti", "doctor",20,1234567890);
            g.readers("nisha", "",17, 1234567890);
            g.readers("Rekha", "doctor", 45, 1234567890);
            g.readers("Hema", "", 17, 1234567890);
            g.readers("Gaurav", "", 12, 1234567890);
            g.readers("Bhavna", "", 25, 1234567890);

           }
}
}
