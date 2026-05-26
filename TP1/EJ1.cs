using System;

class Ejercicio1
{
    static void Main()
    {
        Console.Write("Ingrese un número de dos cifras: ");
        int numero = int.Parse(Console.ReadLine());

        int unidades = numero % 10;
        int decenas = numero / 10;

        Console.WriteLine($"Unidades: {unidades}");
        Console.WriteLine($"Decenas: {decenas}");
    }
}