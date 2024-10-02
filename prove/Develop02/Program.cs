using System;

class Program
{
    //metodo main: aqui es donde el programa interactura con el usuario 
    static void Main(string[] args)
    { //Crea un OBJETO de Journal y uno de PromptGenerator 
        Journal journal = new Journal(); 
        PromptGenerator promptGenerator = new PromptGenerator();
//Ciclo while (true)
        while (true)
        {
    //Muestras el menu con opciones         
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    Entry entry = new Entry(date, prompt, response);
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

//Programs.cs : es el corazon del programa que interactua con el usuario para escribir ver y guardar/cargar el diario
// Entry.cs : Define una entrada del diario con fecha, pregunta y respuesta
//Journal.cs: Guarda, muestra, carga y gestiona las entradas. 
//promptGenerator.cs: te da una pregunta al azar 