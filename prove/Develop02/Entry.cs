using System;

public class Entry
{  //Propiedades: Date, PromptText, EntryText
    public string Date { get; private set; } //Almacena la fecha en que se creo la entrada 
    public string PromptText { get; private set; } //Almaneca la pregunta del PromptGenerator
    public string EntryText { get; private set; }// Almacena la respuesta que escribiste a la pregunta 

//Contructor :
    public Entry(string date, string promptText, string entryText)
    {           //recibe la fecha la preguntas y la respuesta, y las asigna a las propiedades 
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"{Date} - {PromptText}: {EntryText}");
    }
}
//Programs.cs : es el corazon del programa que interactua con el usuario para escribir ver y guardar/cargar el diario
// Entry.cs : Define una entrada del diario con fecha, pregunta y respuesta
//Journal.cs: Guarda, muestra, carga y gestiona las entradas. 
//promptGenerator.cs: te da una pregunta al azar 