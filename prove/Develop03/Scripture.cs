using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference; // La referencia del versículo (por ejemplo, "Proverbios 3:5-6")
    private List<Word> _words; // Lista de objetos Word que representan cada palabra en el texto

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        //Dividir el texto en palabras y crear objetos Word
        foreach (string wordText in text.Split(' '))
        {
            _words.Add(new Word(wordText));
        }
    }

    //Metodo para ocultar palabras aleatoriamente
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;

        //Bucle para ocultar palabras aleatoriamente
        while (wordsHidden < numberToHide)
        {
            int index = random.Next(_words.Count); //Seleccionar un índice aleatorio de la lista
            if (!_words[index].IsHidden()) //Verificar si la palabra ya está oculta
            {
                _words[index].Hide(); //Ocultar la palabra
                wordsHidden++;
            }
        }
    }

    //Metodo para obtener el texto con las palabras ocultas
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n"; // Obtener la referencia de la escritura
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " "; // Obtener el texto de cada palabra (visible u oculta)
        }
        return displayText.Trim(); // Eliminar espacios en blanco adicionales al final
    }

    //Metodo para verificar si todas las palabras estan ocultas
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) //Si alguna palabra no esta oculta, retornar false
            {
                return false;
            }
        }
        return true; // Si todas estan ocultas, retornar true
    }
}
