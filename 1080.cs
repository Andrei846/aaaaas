using System;

class Program
{
    static void Main()
    {

        int highestValue = 0;
        int position = 0;


        for (int i = 1; i <= 100; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());


            if (currentNumber > highestValue)
            {
                highestValue = currentNumber;
                position = i;
            }
        }


        Console.WriteLine($"{highestValue}");
        Console.WriteLine($"{position}");
    }
}

