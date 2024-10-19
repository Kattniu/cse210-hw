using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public void Start()
    {
        Console.WriteLine("Reflection Activity: This exercise will help you reflect on moments in your life where you have shown strength.");
        SetDuration();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Random random = new Random();

        while (DateTime.Now < endTime)
        {
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);
            PauseWithSpinner(3); // Pausa de 3 segundos

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                PauseWithSpinner(4); // Pausa de 4 segundos
                if (DateTime.Now >= endTime) break; // Si el tiempo se acabó, salimos
            }
        }

        ShowCompletionMessage("Reflection");
    }
}
