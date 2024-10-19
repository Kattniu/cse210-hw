using System;
using System.Threading;

public class BreathingActivity : Activity
{
    // Usar 'new' para ocultar el método de la clase base
    public new void PauseWithCountdown(int seconds)
    {
        // Implementación específica si es necesario
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000); // Pausa de 1 segundo
        }
        Console.WriteLine(); // Salto de línea después del conteo
    }

    public void Start()
    {
        Console.WriteLine("Breathing Activity: This activity will help you relax by guiding you through breathing slowly.");
        SetDuration();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Inhale...");
            PauseWithCountdown(4); // Pausa de 4 segundos
            Console.WriteLine("Exhale...");
            PauseWithCountdown(4); // Pausa de 4 segundos
        }

        ShowCompletionMessage("Breathing");
    }
}
