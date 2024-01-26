/*using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crea una lista de números enteros
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Llama a la función para calcular la suma de los números pares
        int sumaPares = SumaNumerosPares(numeros);

        Console.WriteLine("La suma de los números pares es: " + sumaPares);
    }

    static int SumaNumerosPares(List<int> numeros)
    {
        int suma = 0;

        // Itera a través de la lista de números
        foreach (int numero in numeros)
        {
            // Verifica si el número es par
            if (numero % 2 == 0)
            {
                Console.WriteLine("Número par es: " + numero);
                // Si es par, agrégalo a la suma
                suma += numero;
            }
        }

        return suma;
    }
}*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {


        // Crea una lista de números enteros
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Llama a la función para calcular la suma de los números pares
        int sumaPares = SumaNumerosPares(numeros);

        Console.WriteLine("La suma de los números pares es: " + sumaPares);
    }

    static int SumaNumerosPares(List<int> numeros)
    {
        int suma = 0;
        int indice = 0;

        // Utiliza un bucle do-while para recorrer la lista de números
        do
        {
            int numero = numeros[indice];

            // Verifica si el número es par
            if (numero % 2 == 0)
            {
                Console.WriteLine("Número par es: " + numero);
                // Si es par, agrégalo a la suma
                suma += numero;
            }

            // Incrementa el índice
            indice++;

        } while (indice < numeros.Count);

        return suma;
    }
}

