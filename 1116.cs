using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());  

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int X = int.Parse(input[0]);  
            int Y = int.Parse(input[1]);  

            if (Y == 0)
            {
                Console.WriteLine("divisao impossivel");  
            }
            else
            {
                double result = (double)X / Y;  
                Console.WriteLine($"{result:F1}");  
            }
        }
    }
}
