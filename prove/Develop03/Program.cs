using System;

class Program
{
    static void Main(string[] args)
    {
        // Creamos la referencia, aqui estamos instanciando un onjeto de la clase refence
        //le estamos pasando el libro cap y los versiculos. 
        Reference scriptureReference = new Reference("Proverbios", 3, 5, 6);

        //Crear la escritura con el texto, ponemos el texto completo de la escritura y lo pasamos al constructor 
        // de la clase scripture, este constructor recibe dos argumentos: la referencia(el objeto "reference") y el texto completo del versiculo
        string scriptureText = "Confía en el Señor con todo tu corazón y no te apoyes en tu propia prudencia; reconocelo en todos tus caminos, y él enderezará tus sendas.";
        Scripture scripture = new Scripture(scriptureReference, scriptureText);

        // Mostrar la escritura completa al principio, 
        Console.Clear(); // Limpiar la pantalla
        Console.WriteLine(scripture.GetDisplayText());

        //Iniciar el ciclo de memorización
        while (!scripture.IsCompletelyHidden()) // Mientras no todas las palabras estén ocultas
        {
            Console.WriteLine("\nPresiona ENTER para ocultar algunas palabras o escribe 'quit' para salir:");
            string userInput = Console.ReadLine(); // Leer lo que escribe el usuario

            if (userInput.ToLower() == "quit")
            {
                break; // Si el usuario escribe "quit", salir del bucle y terminar el programa
            }

            //Ocultar palabras aleatoriamente
            scripture.HideRandomWords(3); // Oculta 3 palabras aleatoriamente

            //Limpiar la pantalla y mostrar la escritura con palabras ocultas
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }

        //Final del programa
        Console.WriteLine("¡Has memorizado toda la escritura!");
    }
}
