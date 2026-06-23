// EJERCICIOS ARREGLOS

// 1
namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] peliculas = new string[5];
            cargar(peliculas);
            mostrar(peliculas);

            void cargar(string[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Ingresa el nombre de la película " + (i + 1) + ": ");
                    arr[i] = Console.ReadLine();
                }
            }

            void mostrar(string[] arr)
            {
                foreach (string pelicula in arr)
                    Console.WriteLine(pelicula);
            }
        }
    }
}

// 2
namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];
            cargar(numeros);
            contarParesImpares(numeros);

            void cargar(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Ingresa el número " + (i + 1) + ": ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }

            void contarParesImpares(int[] arr)
            {
                int pares = 0, impares = 0;
                foreach (int n in arr)
                    if (n % 2 == 0) pares++;
                    else impares++;
                Console.WriteLine("Pares: " + pares);
                Console.WriteLine("Impares: " + impares);
            }
        }
    }
}

// 3
namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ciudades = { "Madrid", "Buenos Aires", "Bogotá", "Lima", "Santiago" };
            Console.Write("Ingresa el nombre de una ciudad: ");
            string busqueda = Console.ReadLine();
            buscar(ciudades, busqueda);

            void buscar(string[] arr, string valor)
            {
                bool encontrada = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].ToLower() == valor.ToLower())
                    {
                        Console.WriteLine("Ciudad encontrada en el índice " + i + ".");
                        encontrada = true;
                        break;
                    }
                }
                if (!encontrada)
                    Console.WriteLine("Ciudad no encontrada.");
            }
        }
    }
}

// 4
namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[5];
            cargar(notas);
            evaluar(notas);

            void cargar(double[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Ingresa la nota " + (i + 1) + ": ");
                    arr[i] = double.Parse(Console.ReadLine());
                }
            }

            void evaluar(double[] arr)
            {
                double suma = 0;
                foreach (double nota in arr)
                    suma += nota;
                double promedio = suma / arr.Length;
                Console.WriteLine("Promedio: " + promedio);
                if (promedio >= 6)
                    Console.WriteLine("Aprobado.");
                else
                    Console.WriteLine("Reprobado.");
            }
        }
    }
}

// 5
namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 10, 20, 30, 40, 50, 0 };
            Console.Write("Ingresa el número a insertar en la posición 2: ");
            int nuevoNum = int.Parse(Console.ReadLine());
            insertar(arreglo, nuevoNum, 2);
            mostrar(arreglo);

            void insertar(int[] arr, int valor, int posicion)
            {
                for (int i = arr.Length - 1; i > posicion; i--)
                    arr[i] = arr[i - 1];
                arr[posicion] = valor;
            }

            void mostrar(int[] arr)
            {
                foreach (int n in arr)
                    Console.Write(n + " ");
                Console.WriteLine();
            }
        }
    }
}

// 6
namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colores = { "Rojo", "Verde", "Azul", "Amarillo", "Negro" };
            Console.Write("Ingresa el índice del color a eliminar (0-4): ");
            int indice = int.Parse(Console.ReadLine());
            eliminar(colores, indice);
            mostrar(colores);

            void eliminar(string[] arr, int pos)
            {
                for (int i = pos; i < arr.Length - 1; i++)
                    arr[i] = arr[i + 1];
                arr[arr.Length - 1] = "";
            }

            void mostrar(string[] arr)
            {
                foreach (string color in arr)
                    Console.Write("[" + color + "] ");
                Console.WriteLine();
            }
        }
    }
}

// 7
namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] subvector = extraerSegmento(numeros, 3, 8);
            mostrar(subvector);

            int[] extraerSegmento(int[] arr, int desde, int hasta)
            {
                return arr[desde..hasta];
            }

            void mostrar(int[] arr)
            {
                foreach (int n in arr)
                    Console.Write(n + " ");
                Console.WriteLine();
            }
        }
    }
}

// 8
namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[8];
            cargar(numeros);
            buscarMayor(numeros);

            void cargar(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Ingresa el número " + (i + 1) + ": ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }

            void buscarMayor(int[] arr)
            {
                int mayor = arr[0];
                int posMayor = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > mayor)
                    {
                        mayor = arr[i];
                        posMayor = i;
                    }
                }
                Console.WriteLine("El número más grande es " + mayor + " y está en el índice " + posMayor + ".");
            }
        }
    }
}

// 9
namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = new string[5];
            cargar(palabras);
            string resultado = filtrar(palabras);
            Console.WriteLine("Palabras con más de 4 letras: " + resultado.Trim());

            void cargar(string[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Ingresa la palabra " + (i + 1) + ": ");
                    arr[i] = Console.ReadLine();
                }
            }

            string filtrar(string[] arr)
            {
                string resultado = "";
                foreach (string palabra in arr)
                    if (palabra.Length > 4)
                        resultado += palabra + " ";
                return resultado;
            }
        }
    }
}

// 10
namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5];
            bool cargado = false;
            int opcion;

            do
            {
                Console.WriteLine("\n=== MENÚ ===");
                Console.WriteLine("1. Cargar el vector");
                Console.WriteLine("2. Mostrar el vector");
                Console.WriteLine("3. Buscar un número");
                Console.WriteLine("4. Sumar todos los elementos");
                Console.WriteLine("5. Salir");
                Console.Write("Elegí una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        cargar(vector);
                        cargado = true;
                        Console.WriteLine("Vector cargado.");
                        break;
                    case 2:
                        if (!cargado) { Console.WriteLine("Primero cargá el vector."); break; }
                        mostrar(vector);
                        break;
                    case 3:
                        if (!cargado) { Console.WriteLine("Primero cargá el vector."); break; }
                        Console.Write("Ingresa el número a buscar: ");
                        int buscar = int.Parse(Console.ReadLine());
                        buscarNumero(vector, buscar);
                        break;
                    case 4:
                        if (!cargado) { Console.WriteLine("Primero cargá el vector."); break; }
                        Console.WriteLine("Suma total: " + sumar(vector));
                        break;
                    case 5:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (opcion != 5);

            void cargar(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Ingresa el número " + (i + 1) + ": ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }

            void mostrar(int[] arr)
            {
                Console.Write("Vector: ");
                foreach (int n in arr)
                    Console.Write(n + " ");
                Console.WriteLine();
            }

            void buscarNumero(int[] arr, int valor)
            {
                bool encontrado = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == valor)
                    {
                        Console.WriteLine("Número encontrado en el índice " + i + ".");
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                    Console.WriteLine("Número no encontrado.");
            }

            int sumar(int[] arr)
            {
                int suma = 0;
                foreach (int n in arr)
                    suma += n;
                return suma;
            }
        }
    }
}
