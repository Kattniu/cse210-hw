using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void Start()
    {
        Console.WriteLine("Listing Activity: This exercise will help you reflect on the good things in your life.");
        SetDuration();

        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);
        PauseWithCountdown(5); // Pausa de 5 segundos para pensar

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item (or press Enter to finish): ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            items.Add(input);
        }

        Console.WriteLine($"You have entered {items.Count} items.");
        ShowCompletionMessage("Listing");
    }
}
