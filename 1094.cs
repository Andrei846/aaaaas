using System;

class Program
{
    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());

        
        int totalAnimals = 0;
        int rabbits = 0;
        int rats = 0;
        int frogs = 0;

        
        for (int i = 0; i < N; i++)
        {
            
            string[] input = Console.ReadLine().Split();
            int amount = int.Parse(input[0]);
            char type = char.Parse(input[1]);

           
            totalAnimals += amount;

           
            if (type == 'C') 
            {
                rabbits += amount;
            }
            else if (type == 'R') 
            {
                rats += amount;
            }
            else if (type == 'S') 
            {
                frogs += amount;
            }
        }

       
        Console.WriteLine($"Total: {totalAnimals} animals");

        
        Console.WriteLine($"Total de coelhos: {rabbits}");
        Console.WriteLine($"Total de ratos: {rats}");
        Console.WriteLine($"Total de sapos: {frogs}");

        
        Console.WriteLine($"Percentual de coelhos: {((double)rabbits / totalAnimals) * 100:F2} %");
        Console.WriteLine($"Percentual de ratos: {((double)rats / totalAnimals) * 100:F2} %");
        Console.WriteLine($"Percentual de sapos: {((double)frogs / totalAnimals) * 100:F2} %");
    }
}
