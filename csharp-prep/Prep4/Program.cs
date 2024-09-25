using System;
using System.Collections.Generic; // Para usar colecciones genericas como listas 

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); //creamos una lista que contendra int(enteros)
        int numeroU = -1;

        while (numeroU != 0) //mientras numeroU sea diverso != a 0 seguira el bucle
        {
            Console.Write("Enter a list of numbers, type 0 when finished ");
            numeroU = int.Parse(Console.ReadLine()); // aqui convertimos el numero que entra como texto a un int (entero)

            if (numeroU != 0) //si el numero es != a 0 se agregaran los numero a numbers
            {                 // osea a la lista que creamos 
                numbers.Add(numeroU);
            }
        }

//SUMAMOSTODOS LOS NUMEROS, despues de haber recibido numero del usuario y guardados en mi lista(numbers):
        //RECORDAR: "Foreach" permite iterar sobre cada elemento, aqui en la lista numbers

        int sum = 0; // esta avriable sirve para acumular o guardar la suma de todos los numeros que el usuario este dando 
        foreach (int number in numbers)
        {
            sum += number; // cada ciclo e bucle, "number" toma un numero que esta dentro de numbers 
        }       //ejemplo: sum(0) + number(2(el numero tomado de numbers))= num:2 | ahora num es = 2 y asi hasta sumarlo con los otros numeros 
        Console.WriteLine($"The sum is: {sum}"); //imprimimos la suma total

        
//CALCULAMOS EL PROMEDIO, dividiendo la suma total por el numero de elementos en la lista (numbers.Count)
      //".count" cuenta | osea contara cuantos elementos hay dentro de numbers 
        float average = ((float)sum) / numbers.Count; 
        Console.WriteLine($"The average is: {average}");

//CALCULAMOS EL NUMERO MAS GRANDE, esto imprimira el numero mas grande 
        int max = numbers[0]; //declara una variable llamada "max" de tipo entero"int"
                              //Aqui inicia con el primer numero de la lista numbers[0]
        foreach (int number in numbers) //itera sobra CADA elemento de la lista
        {  //Imagina que tener los valores [2, 28, 29]
            if (number > max) //en la Primera Iteracion number= 28|
                          // sera asi if(28>28) es false asi que no se actualiza max
                          //en la Segunta Iteracion number=2
                          // sera asi if(2>28) es falsa,no se actualiza max
            {             //en la Tercera iteracion number=29
                max = number; //if (29>28) es True y se actuliza max (29)
            }
        }
        Console.WriteLine($"The largest number is {max}");
    }
}
