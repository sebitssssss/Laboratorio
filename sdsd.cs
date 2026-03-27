1)
namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas;
            int columnas;
            bool condition;
            bool condition2;
            
            Console.WriteLine("Ingrese un numero impar de filas entre 3 y 7");
            filas = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese un numero impar de columnas entre 15 y 25");
            columnas = Convert.ToInt16(Console.ReadLine());
            condition = filas%2 != 0 && 3 <= filas && filas <= 7;
            condition2 = columnas%2 != 0 && 15 <= columnas && columnas <= 25;

            if (condition && condition2)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Ingresaste algun numero invalido");
            }
        }
    }
}


2)
namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas;
            int columnas;
            int mitad_filas;
            int mitad_columnas;
            bool condition;
            bool condition2;
            
            Console.WriteLine("Ingrese un numero impar de filas entre 3 y 7");
            filas = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese un numero impar de columnas entre 15 y 25");
            columnas = Convert.ToInt16(Console.ReadLine());
            condition = filas%2 != 0 && 3 <= filas && filas <= 7;
            condition2 = columnas%2 != 0 && 15 <= columnas && columnas <= 25;
            mitad_filas = (filas / 2);
            mitad_columnas = (columnas / 2);

            if (condition && condition2)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (i == mitad_filas && j == mitad_columnas)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Ingresaste algun numero invalido");
            }
        }
    }
}


3)
namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas;
            int columnas;
            int mitad_filas;
            int mitad_columnas;
            bool condition;
            bool condition2;
            
            Console.WriteLine("Ingrese un numero impar de filas entre 3 y 7");
            filas = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese un numero impar de columnas entre 15 y 25");
            columnas = Convert.ToInt16(Console.ReadLine());

            mitad_filas = filas / 2;
            mitad_columnas = columnas / 2;
            condition = filas%2 != 0 && 3 <= filas && filas <= 7;
            condition2 = columnas%2 != 0 && 15 <= columnas && columnas <= 25;
            if (condition && condition2)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if ((i == 0 || i == mitad_filas || i == filas - 1) && (j == 0 || j == columnas - 1))
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            if (i == mitad_filas && j == mitad_columnas)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Ingresaste algun numero invalido");
            }
        }
    }
}
