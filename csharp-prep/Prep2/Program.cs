using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade percentage?  ");
        string input = Console.ReadLine();
        int gradePercentage;
        bool isValidNumber = int.TryParse(input, out gradePercentage);

        if (isValidNumber)
        {
            string letter = "";

            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
            }
            else if (gradePercentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
            if (gradePercentage >= 70)
            {
                Console.WriteLine(" Congratulation!:) You passed!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
            Console.WriteLine($"Your grade is: {letter}");
            string sign = "";
            int lastDigit = gradePercentage % 10;
            if (letter != "F")
            {
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
                if (letter == "A" && sign == "+")
                {
                    sign = "";
                }
            }

            if (letter == "F")
            {
                sign = "";
            }

            Console.WriteLine($"Your final grade is: {letter}{sign}");
        }
        else
        {
            Console.WriteLine("Invalid entry. Please enter a valid number.");
        }
    }
}
