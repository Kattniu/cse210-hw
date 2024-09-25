using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? "); //aqui el num introducido se convierte en tipo string (que sera el numero que tendra que adivinar)
        int numMagico = int.Parse(Console.ReadLine());  // y aqui se cambia de tipo string a int almacenandolo en la variable numMagico
        // Random randomGenerator = new Random();
        // int magicNumber = randomGenerator.Next(1, 101); pues aqui el programa en vez de pedir al usuario un numero con 
             //Random, crea un numero aleatorio del 1 al 100
        
        int guess = -1; // es un numero arbitrario que nunca sera igual al numero magico al prinicpio 
                        // esto pues garantiza que el ciclo while siempre comience ya que la condicion(guess != numMagico) sera siempre True
        while (guess != numMagico)
        {
            Console.Write("What is your guess? "); // aqui el usuario ingresa su intento de adivinar el numero 
            guess = int.Parse(Console.ReadLine()); //aqui otra vez lo comvertimos en int(numero entero) y lo asignamos a la varuable guees 

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
