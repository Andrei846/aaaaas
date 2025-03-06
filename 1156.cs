using System;

class Program
{
    static void Main()
    {
        
        double S = 0;

        
        int numerator = 1;
        int denominator = 1;

        
        for (int i = 0; i < 20; i++)  
        {
            
            S += (double)numerator / denominator;

            
            numerator += 2;  
            denominator *= 2;  
        }

        
        Console.WriteLine($"{S:F2}");
    }
}
