using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;
//propiedad Entries: es una lista de objetos Entry, que contiene todas las entradas del diario
    
 //Contructor:   
    public Journal() // inicializa la lista _entries
    {
        _entries = new List<Entry>();
    }

//metodo addentry: Agrega una nueva entrada(entry)a lista _entries 
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

//Metodo displayall recorre todas las engtras en _entries y llama al metodo display() de cafa una patra mosytrarlas 
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
//Metodo savetofile: crea o sobrescrine un archivo de texto con el nombre filename 
// para cada entrada de _entries, guarda su fecha, pregunta y respuesta separadas por | 
    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
            }
        }
    }
//metodo loadfromfile 
//borra las entradas actuales en _entries. Carga las entradas desde el archivo, leyendo linea por linea 
//Divide cada linea por | y crea nuevas entradas con esos datos 
//por ejemplo si guadas las entradas en un archivo se verian algo asi..
//2024-10-01|What was the best part of my day?|Spent time with my family.

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    var entry = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(entry);
                }
            }
        }
    }
}
//Programs.cs : es el corazon del programa que interactua con el usuario para escribir ver y guardar/cargar el diario
// Entry.cs : Define una entrada del diario con fecha, pregunta y respuesta
//Journal.cs: Guarda, muestra, carga y gestiona las entradas. 
//promptGenerator.cs: te da una pregunta al azar 