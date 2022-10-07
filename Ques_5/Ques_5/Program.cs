using System;
public class Ques_5
{
    public static void Main()
    {
        int j, n;
        Console.Write("Enter the number : \n");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("the multiplication table:\n");
        for (j = 1; j <= 10; j++)
        {
            Console.Write("{0} X {1} = {2} \n", n, j, n * j);
        }
        
        int i,f=1;
        for(i=1;i<=n;i++)
          f=f*i;
          Console.Write("The Factorial of {0} is: {1}\n",n,f);
        Console.ReadKey();
    }
}
