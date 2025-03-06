using System;

class Program
{
    static void Main()
    {
       
        int N = int.Parse(Console.ReadLine());

        
        int factorial = 1;

        
        for (int i = 1; i <= N; i++)
        {
            factorial *= i; 
        }

        
        Console.WriteLine(factorial);
    }
}
