using System;
using System.Collections.Generic;

public class PromptGenerator
{
    //Generar una pregunta aleatoria para escribir una entrada en el  diario
    private List<string> _prompts;//es una lista de cadenas que contiene varias preguntas(prompts)
//constructor:
    public PromptGenerator() //Al crearse un objeto de esta clase, llena la lista _prompts con preguntas predefinidas.
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
             "What was the best part of my day?",
             "How did I see the Lord's hand in my life today?",
            "What was the most intense emotion I felt today?",
            "If I could repeat one thing from today, what would it be?"
        };
    }

    public string GetRandomPrompt() //Crea un objeto Random para generar un número aleatorio.
    { //Selecciona un índice al azar basado en el tamaño de la lista _prompts.
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index]; //Devuelve una pregunta aleatoria usando ese índice.
    }
}
//Programs.cs : es el corazon del programa que interactua con el usuario para escribir ver y guardar/cargar el diario
// Entry.cs : Define una entrada del diario con fecha, pregunta y respuesta
//Journal.cs: Guarda, muestra, carga y gestiona las entradas. 
//promptGenerator.cs: te da una pregunta al azar 