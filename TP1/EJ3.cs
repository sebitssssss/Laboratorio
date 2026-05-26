using System;

class Ejercicio3
{
    static void Main()
    {
        Console.Write("Indicar precio de lista: ");
        decimal precioLista = decimal.Parse(Console.ReadLine());

        decimal descuento = precioLista * 0.18m;
        decimal precioConDescuento = precioLista - descuento;

        Console.WriteLine($"Precio de lista:      ${precioLista:F2}");
        Console.WriteLine($"Descuento:            18% sobre el precio de lista");
        Console.WriteLine($"Precio con descuento: ${precioConDescuento:F2}");
    }
}