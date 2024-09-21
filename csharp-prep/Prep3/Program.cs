using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int numMagico = int.Parse(Console.ReadLine());
        int guess = -1;

        while (guess != numMagico)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < numMagico)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > numMagico)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
