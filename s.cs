namespace Laboratorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Ingrese el tamaño n de la matriz (entre 3 y 5): ");
                string entradaN = Console.ReadLine();

                if (int.TryParse(entradaN, out n) && n >= 3 && n <= 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Debe ser un número entero entre 3 y 5.");
                }
            }

            double[,] matriz = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    while (true)
                    {
                        Console.Write($"Ingrese el valor para la posición [{i}, {j}]: ");
                        string entrada = Console.ReadLine();

                        if (double.TryParse(entrada, out double valor))
                        {
                            matriz[i, j] = valor;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido. Ingrese un número (puede tener decimales).");
                        }
                    }
                }
            }

            Console.WriteLine("\nSuma de cada fila:");
            for (int i = 0; i < n; i++)
            {
                double sumaFila = 0;
                for (int j = 0; j < n; j++)
                {
                    sumaFila += matriz[i, j];
                }
                Console.WriteLine($"Fila {i}: {sumaFila}");
            }

            Console.WriteLine("\nSuma de cada columna:");
            for (int j = 0; j < n; j++)
            {
                double sumaColumna = 0;
                for (int i = 0; i < n; i++)
                {
                    sumaColumna += matriz[i, j];
                }
                Console.WriteLine($"Columna {j}: {sumaColumna}");
            }

            double sumaDiagonalPrincipal = 0;
            double sumaDiagonalSecundaria = 0;

            for (int i = 0; i < n; i++)
            {
                sumaDiagonalPrincipal += matriz[i, i];           // diagonal principal
                sumaDiagonalSecundaria += matriz[i, n - 1 - i];  // diagonal secundaria
            }

            Console.WriteLine("\nSuma de diagonales:");
            Console.WriteLine($"Diagonal principal: {sumaDiagonalPrincipal}");
            Console.WriteLine($"Diagonal secundaria: {sumaDiagonalSecundaria}");

            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
