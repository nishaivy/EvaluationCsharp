using System.IO;
using System;

namespace Ques_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name");
            string name = Console.ReadLine();
            string fileName = @"C:\Users\nisha.hiremani\source\repos\evalutionC#\Ques_8\Ques_8\bin\Debug\" + name + ".txt";
            try
            {
                StreamWriter sw = File.AppendText(fileName);



                sw.WriteLine("The 1st line has been added");
                sw.WriteLine("2nd line");
                sw.WriteLine("3rd Line");
                sw.WriteLine("4th line has been added");
                sw.WriteLine("5th line has been added");
                sw.WriteLine("6th line has been added");
                sw.WriteLine("7th line has been added");
                sw.WriteLine("8th line has been added");
                sw.WriteLine("9th line has been added");
                sw.WriteLine("10th line has been added");
                sw.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    sr.Close();
                }
            }



            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Enter the text to be replaced");
            string OldText = Console.ReadLine();



            Console.WriteLine("Enter the text you want in the file");
            string NewText = Console.ReadLine();



            string text = File.ReadAllText(fileName);
            text = text.Replace(OldText, NewText);
            File.WriteAllText(fileName, text);
            Console.ReadKey();




        }
    }
}