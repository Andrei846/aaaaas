using System;

class Program
{
    static void Main()
    {
      
        int N = int.Parse(Console.ReadLine());

      
        for (int i = 0; i < N; i++)
        {
            
            string[] input = Console.ReadLine().Split();
            float A = float.Parse(input[0]);
            float B = float.Parse(input[1]);
            float C = float.Parse(input[2]);

            
            float weightedAverage = (A * 2 + B * 3 + C * 5) / 10;

            
            Console.WriteLine($"{weightedAverage:F1}");
        }
    }
}
