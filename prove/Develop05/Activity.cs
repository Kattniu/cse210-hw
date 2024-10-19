using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected int duration;

    public void SetDuration()
    {
        Console.Write("How many seconds do you want for this activity?");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to start...");
        PauseWithSpinner(3); // Pausa de 3 segundos con spinner
    }

    protected void ShowCompletionMessage(string activityName)
    {
        Console.WriteLine("¡Great job!");
        PauseWithSpinner(2); // Pausa de 2 segundos
        Console.WriteLine($"You have completed the activity: {activityName} for {duration} seconds.");



        PauseWithSpinner(3); // Pausa de 3 segundos
    }

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("."); // Muestra un punto como animación
            Thread.Sleep(1000); // Pausa de 1 segundo
        }
        Console.WriteLine();
    }
    protected void PauseWithCountdown(int seconds)
{
    for (int i = seconds; i > 0; i--)
    {
        Console.Write(i + " ");
        Thread.Sleep(1000); // Pausa de 1 segundo
    }
    Console.WriteLine(); // Salto de línea después del conteo
}

}
