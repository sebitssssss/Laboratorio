using System;

class Ejercicio5
{
    static void Main()
    {
        Console.Write("Indicar una fecha como un entero de 6 dígitos (DDMMAA): ");
        int fecha = int.Parse(Console.ReadLine());

        int anio = fecha % 100;
        int mes = (fecha / 100) % 100;

        Console.WriteLine($"Mes: {mes:D2}");
        Console.WriteLine($"Año: {anio:D2}");
    }
}