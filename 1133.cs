using System;

class Program
{
    static void Main()
    {
       
        string[] input = Console.ReadLine().Split();
        int X = int.Parse(input[0]);
        int Y = int.Parse(input[1]);

        
        if (X > Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
        }

       
        for (int i = X; i <= Y; i++)
        {
            
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);  
            }
        }
    }
}
