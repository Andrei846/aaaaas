﻿using System;

class Program
{
    static void Main()
    {
       
        int N = int.Parse(Console.ReadLine());

      
        for (int i = 0; i < N; i++)
        {
           
            int X = int.Parse(Console.ReadLine());

         
            if (X == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
               
                string evenOdd = (X % 2 == 0) ? "EVEN" : "ODD";

               
                string positiveNegative = (X > 0) ? "POSITIVE" : "NEGATIVE";

               
                Console.WriteLine($"{evenOdd} {positiveNegative}");
            }
        }
    }
}
