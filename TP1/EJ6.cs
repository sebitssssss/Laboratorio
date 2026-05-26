using System;

class Ejercicio6
{
    static void Main()
    {
        Console.Write("Ingrese el lado del cuadrado: ");
        double lado = double.Parse(Console.ReadLine());

        double perimetro = 4 * lado;
        double superficie = lado * lado;

        Console.WriteLine($"Perímetro:   {perimetro}");
        Console.WriteLine($"Superficie:  {superficie}");
    }
}