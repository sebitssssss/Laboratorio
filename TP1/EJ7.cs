using System;

class Ejercicio7
{
    static void Main()
    {
        Console.Write("Ingrese el valor de una hora de trabajo: ");
        decimal valorHora = decimal.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de horas trabajadas: ");
        decimal horasTrabajadas = decimal.Parse(Console.ReadLine());

        decimal sueldoBruto = valorHora * horasTrabajadas;

        Console.WriteLine($"Sueldo bruto: ${sueldoBruto:F2}");
    }
}