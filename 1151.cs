using System;

class Program
{
    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());

       
        long a = 0, b = 1;

        
        for (int i = 0; i < N; i++)
        {
            if (i > 0)
            {
                Console.Write(" ");  
            }

            
            Console.Write(a);

            
            long next = a + b;
            a = b;
            b = next;
        }

       
        Console.WriteLine();
    }
}
