﻿using System;
public class Ques_1
{
    public static void Main()
    {
        int[] arr= new int[100];
        int i, max, min, n;
        Console.Write("Enter the number of array elements:");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter {0} elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }


        max = arr[0];
        min = arr[0];

        for (i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }


            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.Write("Maximum element is : {0}\n", max);
        Console.Write("Minimum element is : {0}\n\n", min);
        Console.ReadKey();
    }
   
}
