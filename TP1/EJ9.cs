using System;

class Ejercicio9
{
    static void Main()
    {
        Console.Write("Ingrese hora del primer instante (hh mm ss): ");
        string[] t1 = Console.ReadLine().Split(' ');
        int h1 = int.Parse(t1[0]);
        int m1 = int.Parse(t1[1]);
        int s1 = int.Parse(t1[2]);

        Console.Write("Ingrese hora del segundo instante (hh mm ss): ");
        string[] t2 = Console.ReadLine().Split(' ');
        int h2 = int.Parse(t2[0]);
        int m2 = int.Parse(t2[1]);
        int s2 = int.Parse(t2[2]);

        int totalSegundos1 = h1 * 3600 + m1 * 60 + s1;
        int totalSegundos2 = h2 * 3600 + m2 * 60 + s2;
        int intervalo = Math.Abs(totalSegundos2 - totalSegundos1);

        Console.WriteLine($"Intervalo entre los dos instantes: {intervalo} segundos");
    }
}