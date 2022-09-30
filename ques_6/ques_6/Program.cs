using System;
using System.IO;
using System.Security.Cryptography;



namespace ques_6
{
    class Copy_File
    {

       static void Main()
        {
            // Copy contents from file1 to file2
            File.Copy("nisha.txt", "nisha_enycrpt2.txt");



           // Display file2 contents
            Console.WriteLine(File.ReadAllText("nisha_enycrpt2.txt"));
            var file= File.ReadAllText(@"C:\Users\nisha.hiremani\source\repos\evalutionC#\ques_6\ques_6\bin\Debug\nisha_enycrpt2.txt");
            FileInfo filetodecrypt = new FileInfo(file);
            filetodecrypt.Encrypt(); //Encrypt

            filetodecrypt.Decrypt(); //Decrypt

       }
    }
    }