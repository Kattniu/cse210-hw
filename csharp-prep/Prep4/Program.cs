using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numeroU = -1;

        while (numeroU != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished ");
            numeroU = int.Parse(Console.ReadLine());

            if (numeroU != 0)
            {
                numbers.Add(numeroU);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is {max}");
    }
}
