using System;

class Program
{
    static void Main()
    {
     
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());

        
        int sum = 0;

   
        for (int i = X; i <= Y; i++)
        {
            
            if (i % 2 != 0)
            {
               
                sum += i;
            }
        }

      

        Console.WriteLine(sum);
    }
}
