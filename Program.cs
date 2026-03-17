namespace gta6;

internal class Program
{
    static void Main(string[] args)
    {
        int fila = 0;
        int columna = 0;
        string asterisco = "*";
        bool condicion;
        bool condicion2;
        bool condicion3;
        bool condicion4;
        Console.WriteLine("Ingrese un número impar entre 3-7 para las filas: ");
        fila = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ingrese un número impar entre 15-25 para las columnas: ");
        columna = Convert.ToInt16(Console.ReadLine());
        condicion = fila % 2 != 0 && fila >= 3 && fila <= 7;
        condicion2 = columna % 2 != 0 && columna >= 15 && columna <= 25;
        condicion3 = fila > 0;
        condicion4 = columna > 0;
        if (condicion)
        {
            if (condicion2)
            {
                if (condicion3)
                {
                    if (condicion4)
                    {
                        for (int i = 0; i < fila; i++)
                        {
                            for (int z = 0; z < columna; z++)
                            {
                                Console.Write(asterisco);
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese valores correctos.");
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese valores correctos.");
                }
            }
            else
            {
                Console.WriteLine("Ingrese valores correctos.");
            }
        }
        else
        {
            Console.WriteLine("Ingrese valores correctos.");
        }
        Console.ReadKey();
    }
}