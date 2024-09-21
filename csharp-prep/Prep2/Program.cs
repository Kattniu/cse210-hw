using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?  ");
        if (int.TryParse(Console.ReadLine(), out int gradeP))
        {
            string letter = gradeP >= 90 ? "A" :
                            gradeP >= 80 ? "B" :
                            gradeP >= 70 ? "C" :
                            gradeP >= 60 ? "D" : "F";

            Console.WriteLine(gradeP >= 70 ? "You passed!" : "Better luck next time!");
            Console.WriteLine($"Your grade is: {letter}");

            string signo = "";
            if (letter != "F")
            {
                int ultDig = gradeP % 10; // si el ultimo digito (ultiDig)es mayor o igual a 7 se usara +
                signo = ultDig >= 7 ? "+" : ultDig < 3 ? "-" : "";
                if (letter == "A" && signo == "+") signo = "";
            }

            Console.WriteLine($"Your final grade is: {letter}{signo}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number :) ");
        }
    }
}
