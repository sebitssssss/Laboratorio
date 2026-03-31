// Ejercicio 1:

namespace ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Ingrese 10 numeros:");

            int[] array = new int[10];

            for (i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Array sin permutar: ");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i]);

            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Array permutado: ");
            for (i = 9; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
                
            }
        }
    }
}

// Ejercicio 2:

namespace ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int temp;
            int temp1 = -999999999;
            int temp2 = 1000000000;
            int pos1 = 0;
            int pos2 = 0;
            Console.WriteLine("Ingrese 10 numeros:");

            int[] array = new int[10];

            for (i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("--------------------------------------");
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine(array[j]);
            }
            for (j = 0; j < 10; j++)
            {
                temp = array[j];
                if (temp > temp1)
                {
                    temp1 = temp;
                    pos1 = j + 1;
                }
            }
            for (j = 9; j >= 0; j--)
            {
                temp = array[j];
                if (temp < temp2)
                {
                    temp2 = temp;
                    pos2 = j + 1;
                }
            }
            Console.WriteLine($"El numero mas alto del array es: {temp1}, y está en la posición: {pos1}");
            Console.WriteLine($"El numero mas bajo del array es: {temp2}, y está en la posición: {pos2}");
        }
    }
}

// Ejercicio 3:

namespace ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            float temp = 0;
            float promedio;
            Console.WriteLine("Ingrese 10 numeros:");


            int[] array = new int[10];


            for (i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                temp = temp + array[i];
            }
            promedio = temp / 10;
            Console.WriteLine($"El promedio del array es: {promedio} ");
        }
    }
}

// Ejercicio 4:

namespace ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 8 numeros:");

            int[] array = new int[8];
            int[] arrayp = new int[8];
            int[] arrayi = new int[8];
            for (int i = 0; i < 8; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 0; i < 8; i++)
            {
                if (array[i] % 2 == 0)
                {
                    arrayp[i] = array[i];
                }
                else
                {
                    arrayi[i] = array[i];
                }
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Número {i+1} de el array de números pares: ");
                Console.WriteLine($"{arrayp[i]}");
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Número {i+1} de el array de números impares: ");
                Console.WriteLine($"{arrayi[i]}");
            }
        }
    }
}

// Ejercicio 5

namespace ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Ingrese 10 numeros:");

            int[] array = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[10];
            int contador = 0;
            for (i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                array3[i] = array[i];
            }
            for (i = 0; i < 10; i++)
            {
                bool repetido = false;
                for (int j = 0; j < contador; j++)
                {
                    if (array3[i] == array2[j])
                    {
                        repetido = true;
                    }
                }
                if (repetido == false)
                {
                    array2[contador] = array3[i];
                    contador++;
                }
            }
            Console.WriteLine("Array sin numeros repetidos:");
            for (i = 0; i < contador; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }
    }
}

// Ejercicio 6

namespace ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int temp;
            int i;
            int[] array = new int[8];
            int[] rotado = new int[8];
            Console.WriteLine("Ingrese 8 numeros enteros");
            for (i = 0; i < 8; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ingrese un numero N");
            numero = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
            for (i = 0; i < 8; i++)
            {
                int j;
                temp = numero % 8;
                j = (i + temp) % 8;
                rotado[j] = array[i];
            }
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine(rotado[i]);
            }
            Console.WriteLine("-----------------------------------------");
        }
    }
}
