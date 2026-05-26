using System;

class Ejercicio8
{
    static void Main()
    {
        Console.Write("Ingrese la temperatura en Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5.0 / 9.0;

        Console.WriteLine($"Temperatura en Celsius: {celsius:F2}°C");
    }
}