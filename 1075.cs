﻿using System;

class Program
{
    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());

     
        for (int i = 1; i <= 10000; i++)
        {
           
            if (i % N == 2)
            {
               
                Console.WriteLine(i);
            }
        }
    }
}
