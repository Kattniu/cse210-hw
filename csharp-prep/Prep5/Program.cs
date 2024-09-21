
using System;

class Program
{
    static void Main(string[] args)
    {
        hiUser();
        string name = userInput("Please, Enter your name: ");
        int number = userNum("Please, enter your favorite number: ");

        int result = calcularsqr(number);
        verOutput(name, result);
    }
    static void hiUser()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string userInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
    static int userNum(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }
    static int calcularsqr(int num)
    {
        return num * num;
    }
    static void verOutput(string userName, int squaredNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNum}");
    }
}
