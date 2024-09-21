using System;

class Program
{
    static void Main(string[] args)
    {
        // requisito 1: Preguntar al usuario por su porcentaje de calificación.
        Console.Write("What is your grade percentage?  ");
        string input = Console.ReadLine();
        int gradePercentage;

        // Validar si la entrada es un numero
        bool isValidNumber = int.TryParse(input, out gradePercentage);

        if (isValidNumber)
        {
            // requisito 2: Determinar la letra de la calificacion 
            string letter = ""; // una variable para almacenar la letra de calificacion

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

            // requisito 3: Determinar si el usuario aprobo y 
            //mostrar el mensaje correspondiente
            if (gradePercentage >= 70)
            {
                Console.WriteLine(" Congratulation!:) You passed!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
            // Requisito Principal 4: Imprimir la letra de calificación
            Console.WriteLine($"your grade is: {letter}");
            // Desafío Adicional: Determinar el signo "+" o "-" para la calificación
            string sign = "";
            int lastDigit = gradePercentage % 10;
            // anadir signo solo si la calificación no es F y no es A+
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

                //no existe la calificación A+
                if (letter == "A" && sign == "+")
                {
                    sign = ""; // A+ no es válido, eliminamos el "+".
                }
            }

            // Manejar el caso de F (No existe F+ o F-)
            if (letter == "F")
            {
                sign = ""; // No existe F+ o F-, solo F
            }

            Console.WriteLine($"Your final grade is: {letter}{sign}");
        }
        else
        {
            Console.WriteLine("Invalid entry. Please enter a valid number.");
        }
    }
}
