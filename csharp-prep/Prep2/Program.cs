using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?  "); //int.tryParce() convierte lo que el el usuario ingrese en un numero entero(int) 
        if (int.TryParse(Console.ReadLine(), out int gradeP)) // int.TryParse() : devuelve true si la conversion es valida y false si no lo ,,es
        {                                                    //out int gradeP si la conversion esta ok, guarda el numero en la variable gradeP

            // "?" condicion si es True (verdadera)
            string letter = gradeP >= 90 ? "A" :// ":" condicion si es False, significa pasar a la siguiente condicion 
                            gradeP >= 80 ? "B" : //si el porcentaje es mayor > o =igual a 80 sera : "B" , pero si es falsa 
                            gradeP >= 70 ? "C" : //pasa a la siguiente parte.
                            gradeP >= 60 ? "D" : "F"; // si el porcentaje (gradeP) es >=60 sera "D", de lo contrario sera "F"

            Console.WriteLine(gradeP >= 70 ? "You passed!" : "Better luck next time!");
            Console.WriteLine($"Your grade is: {letter}");


            string signo = ""; // creo una variable tipo string y pues esta vacia 
            if (letter != "F") // aqui se establece una condicion solo se calculara un signo + o - si la calificacion NO ES "F"
            {               // osea si letter es "F" el bloque if sera omitido 
                int ultDig = gradeP % 10; // el operador modulo %, devuelve el resto de la division entre gradeP y 10.
                signo = ultDig >= 7 ? "+" : ultDig < 3 ? "-" : ""; //si el ultimo digito (ultiDig)es mayor o igual a 7 se usara "+" o "-" 
                                                                   //si es menor que 3 y no es ninguna de ella pues no se pondra nada " "
                if (letter == "A" && signo == "+") signo = "";
                // si la letra es "A" y el signo "+" pues no se pondra el signo "+" si es A TU CALIFICACION ES SOLO A 
            }




            Console.WriteLine($"Your final grade is: {letter}{signo}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number :) ");
        }
    }
}
