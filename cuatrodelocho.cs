1)
namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] resistencias = new double[5];
            double resistenciaTotal = 0;
            Console.WriteLine("Ingrese el valor de 5 resistencias");
            for (int i = 0; i < 5; i++)
            {
                resistencias[i] = Convert.ToDouble(Console.ReadLine());
                resistenciaTotal += resistencias[i];
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Resistencia {i+1}: {resistencias[i]}");
            }
            Console.WriteLine($"La resistencia total es: {resistenciaTotal}");
        }
    }
}



2)
namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[5];
            double valorPromedio = 0;
            double max = -999999;
            Console.WriteLine("Ingrese el valor de 5 resistencias");
            for (int i = 0; i < 5; i++)
            {
                numeros[i] = Convert.ToDouble(Console.ReadLine());
                valorPromedio += numeros[i];
                if (numeros[i] > max)
                {
                    max = numeros[i];
                }
            }
            Console.WriteLine($"El valor promedio es: {valorPromedio / 5}");
            Console.WriteLine($"El valor mas alto es: {max}");
        }
    }
}



3)
namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, num1, num2, min = 0;

            Console.WriteLine("Ingrese dos numeros enteros");
            num1 = Convert.ToInt16(Console.ReadLine());
            num2 = Convert.ToInt16(Console.ReadLine());

            if (num1 - num2 > 1)
            {
                num = num1 - num2;
                min = num2;
            }
            else if (num2 - num1 > 1)
            {
                num = num2 - num1;
                min = num1;
            }
            else
            {
                Console.WriteLine("No tiene intermedios");
            }

            int[] numerosIntermedios = new int[num];

            for (int i = min + 1; i < num + min; i++)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}




4)
namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[30];
            double promedio = 0;

            Console.WriteLine("Ingrese las notas de los 30 alumnos");


            for(int i = 0; i < 30; i++)
            {
                notas[i] = Convert.ToDouble(Console.ReadLine());
                promedio += notas[i];
            }

            Console.WriteLine($"El promedio del curso es: {promedio / 30}");
        }
    }
}



5)
namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxUnidad = -999999;
            int maxVendedor = 0;
            int countVendedor;
            int unidadesTotales = 0;

            for (int i = 0; i < 20; i++)
            {
                countVendedor = 0;
                Console.WriteLine($"Ingrese las unidades vendidas del empleado {i + 1}");
                for (int j = 0; j < 15; j++)
                {
                    int unidad = Convert.ToInt16(Console.ReadLine());
                    countVendedor += unidad;
                    unidadesTotales += unidad;
                }
                if (countVendedor > maxUnidad)
                {
                    maxUnidad = countVendedor;
                    maxVendedor = i;
                }
            }
            Console.WriteLine($"El total de unidades vendidas es: {unidadesTotales}");
            Console.WriteLine($"El vendedor con mayor venta diaria es el vendedor numero: {maxVendedor + 1}");
        }
    }
}



6)
namespace 6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Escriba el sueldo de la perosna {i+1}");
                pers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (pers[i] > 2000)
                {
                    Console.WriteLine($"La persona {i + 1} gana mas de 2000");
                }
                else 
                {
                    Console.WriteLine($"La persona {i+1} gana menos de 2000");
                }
            }
        }
    }
}





7)
namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[15];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Escriba la nota del alumno: {i+1}");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 15; i++)
            {
                if (notas[i] > 8)
                {
                    Console.WriteLine($"El alumno {i+1} esta en la posicion {i}");
                }
            }
        }
    }
}



8)
namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anteUltimo = 0;
            int anterior = 1;

            Console.WriteLine(anteUltimo);
            Console.WriteLine(anterior);

            for (int i = 2; i < 11; i++)
            {
                int actual = anteUltimo + anterior;
                Console.WriteLine(actual);
                anteUltimo = anterior;
                anterior = actual;
            }
        }
    }
}

9)
namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int longitud;
            bool ascendente = true;
            bool descendente = true;
            Console.WriteLine("Ingrese la longitud de la lista");
            longitud = Convert.ToInt16(Console.ReadLine());
            if (longitud > 1)
            {
                int[] lista = new int[longitud];
                for (int i = 0; i < longitud; i++)
                {
                    lista[i] = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine($"Suma entre el primer y ultimo numero: {lista[0] + lista[longitud - 1]}");
                for (int i = 0; i < longitud - 1; i++)
                {
                    if (lista[i] < lista[i + 1]) { descendente = false; }
                    if (lista[i] > lista[i + 1]) { ascendente = false; }
                }
                if (descendente == false && ascendente == false) { Console.WriteLine("La lista esta desordenada."); }
                if (ascendente == true) { Console.WriteLine("La lista esta ordenada de manera ascendente."); }
                if (descendente == true) { Console.WriteLine("La lista esta ordenada de manera descendente."); }
            }
            else
            {
                if (longitud == 1)
                {
                    int num;
                    num = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("La lista esta ordenada de manera ascendente.");
                    Console.WriteLine("La lista esta ordenada de manera descendente.");
                    Console.WriteLine("La lista esta ordenada de manera desordenada.");
                    Console.WriteLine($"Suma entre el primer y ultimo numero: {num + num}");
                }
                else
                {
                    Console.WriteLine("Ingrese una longitud valida");
                }
            }
        }
    }
}

10)

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int prod = 1;
            int bajo = 0;
            int prom;
            int i;
            int[] lista = new int[10];

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"Escriba el elemento {i + 1} del vector: ");
                lista[i] = Convert.ToInt16(Console.ReadLine());
                total += lista[i];
                prod *= lista[i];
            }
            prom = total / 10;

            for (i = 0; i < 10; i++)
            {
                if (lista[i] < prom)
                {
                    bajo += 1;
                }
            }
            
            Console.WriteLine($"Total de la suma: {total}");
            Console.WriteLine($"Total del producto: {prod}");
            Console.WriteLine($"Promedio de todos los elementos: {prom}");
            Console.WriteLine($"Elementos bajo el promedio: {bajo}");
        }
    }
}
13)
namespace ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 6 numeros del vector");
            int[] vector = new int[6];
            for (int i = 0; i < 6; i++)
            {
                vector[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Lista de pares:");
            for (int i = 0; i < 6; i++)
            {
                if (vector[i] % 2 == 0) { Console.WriteLine(vector[i]); }
            }
        }
    }
}

14)
namespace ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 6 numeros del vector");
            int[] vector = new int[6];
            for (int i = 0; i < 6; i++)
            {
                vector[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Lista de posiciones de los numeros pares:");
            for (int i = 0; i < 6; i++)
            {
                if (vector[i] % 2 == 0) { Console.WriteLine(i); }
            }
        }
    }
}





15)
namespace ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[10];
            int[] vector2 = new int[10];
            int[] union = new int[10];

            Console.WriteLine("Ingrese 10 numeros en el primer vector");
            for (int i = 0; i < 10; i++)
            {
                vector1[i] = Convert.ToInt16(Console.ReadLine());
                if (i%2 == 0) { union[i] = vector1[i]; }
            }
            Console.WriteLine("Ingrese 10 numeros en el segundo vector");
            for (int i = 0; i < 10; i++)
            {
                vector2[i] = Convert.ToInt16(Console.ReadLine());
                if (i % 2 != 0) { union[i] = vector2[i]; }
            }
            Console.WriteLine("Vector con elementos de las posiciones pares del primer vector y elementos de las posiciones impares del segundo vector");
            for (int i = 0; i < 10; i+=2)
            {
                Console.WriteLine(union[i]);
            }
            for (int i = 1; i < 10; i += 2)
            {
                Console.WriteLine(union[i]);
            }
        }
    }
}

17)
namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese N: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            int[] invertido = new int[n];
            for (int i = 0; i < n; i++)
            {
                invertido[i] = vector[n - 1 - i];
            }

            foreach (int elem in invertido)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
    }
}

18)
namespace Ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Elemento {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            bool iguales = true;
            bool creciente = true;
            bool decreciente = true;

            for (int i = 1; i < 10; i++)
            {
                if (vector[i] != vector[i - 1]) iguales = false;
                if (vector[i] <= vector[i - 1]) creciente = false;
                if (vector[i] >= vector[i - 1]) decreciente = false;
            }

            if (iguales) Console.WriteLine(1);
            else if (creciente) Console.WriteLine(2);
            else if (decreciente) Console.WriteLine(3);
            else Console.WriteLine(4);
        }
    }
}

19)
namespace Ejercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] anios = new int[15];

            for (int i = 0; i < 15; i++)
            {
                Console.Write($"Año {i}: ");
                anios[i] = int.Parse(Console.ReadLine());
            }

            List<int> bisiestos = new List<int>();

            foreach (int anio in anios)
            {
                if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
                    bisiestos.Add(anio);
            }

            foreach (int anio in bisiestos)
            {
                Console.Write(anio + " ");
            }
            Console.WriteLine();
        }
    }
}

namespace Ejercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese cantidad de productos: ");
            int n = int.Parse(Console.ReadLine());

            string[] codigos = new string[n];
            double[] precios = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Código producto {i}: ");
                codigos[i] = Console.ReadLine();
                Console.Write($"Precio producto {i}: ");
                precios[i] = double.Parse(Console.ReadLine());
            }

            int[] indices = new int[n];
            for (int i = 0; i < n; i++)
            {
                indices[i] = i;
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (precios[indices[j]] > precios[indices[j + 1]])
                    {
                        int temp = indices[j];
                        indices[j] = indices[j + 1];
                        indices[j + 1] = temp;
                    }
                }
            }

            foreach (int idx in indices)
            {
                Console.WriteLine($"{codigos[idx]} ({idx}) - {precios[idx]}");
            }

            for (int i = 0; i < n; i++)
            {
                precios[i] = precios[i] * 1.15;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{codigos[i]} ({i}) - {precios[i]}");
            }
        }
    }
}
