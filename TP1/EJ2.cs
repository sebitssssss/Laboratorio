using System;

class Ejercicio2
{
    static void Main()
    {
        Console.Write("Indicar un número de tres cifras: ");
        int numero = int.Parse(Console.ReadLine());

        int cifracentral = (numero / 10) % 10;

        Console.WriteLine($"La cifra central es: {cifracentral}");
    }
}