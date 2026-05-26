using System;

class Ejercicio4
{
    static void Main()
    {
        Console.Write("Indicar un número de dos cifras: ");
        int numero = int.Parse(Console.ReadLine());

        int unidades = numero % 10;
        int decenas = numero / 10;
        int permutado = unidades * 10 + decenas;

        Console.WriteLine($"Valor:           {numero,2} (ej: 57)");
        Console.WriteLine($"Valor permutado: {permutado,2} (ej: 75)");
    }
}