// Ejercicio 1

namespace ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int alta = 0;
            int baja = 999;
            float prom = 0;
            int num;
            bool encontrado = false;
            int dia = 0;
            Console.WriteLine("Ingrese una temperatura para cada día de la última semana: ");
            int[] array = new int[7];
            for (i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (i = 0; i < 7; i++)
            {
                if (array[i] > alta)
                {
                    alta = array[i];
                }
                if (array[i] < baja)
                {
                    baja = array[i];
                }
            }
            for (i = 0; i < 7; i++)
            {
                prom += array[i];
            }
            Console.WriteLine("Temperaturas de toda la semana: ");

            for (i = 0; i < 7; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Temperatura más alta: ");
            Console.WriteLine(alta);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Temperatura más baja: ");
            Console.WriteLine(baja);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Temperatura promedio: ");
            Console.WriteLine(prom / 7);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Temperaturas de toda la semana al revés: ");
            for (i = 6; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Ingrese una temperatura específica para ser buscada: ");
            num = Convert.ToInt16(Console.ReadLine());
            for (i = 0; i < 7; i++)
            {
                if (array[i] == num)
                {
                    dia = i;
                    encontrado = true;
                }
            }
            if (encontrado == true)
            {
                Console.WriteLine($"La temperatura fue encontrada, sucedió el día {dia + 1}");
            }
            else
            {
                Console.WriteLine("La temperatura no fue encontrada");
            }
        }
    }
}


// Ejercicio 2 Incompleto


namespace ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            int i;
            int alta = 0;
            int baja = 999;
            float prom = 0;
            bool encontrado = false;
            string alum;
            int dia = 0;
            Console.WriteLine("Ingrese la cantidad de alumnos los cuales serán registrados: ");
            cant = Convert.ToInt16(Console.ReadLine());
            string[] nombre = new string[cant];
            double[] nota = new double[cant];
            for (i = 0; i < cant; i++)
            {
                Console.WriteLine($"Ingrese el nombre de el alumno {i + 1}: ");
                nombre[i] = Console.ReadLine();
                Console.WriteLine($"Ingrese la nota de el alumno {i + 1}");
                nota[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (i = 0; i < 7; i++)
            {
                if (nota[i] > alta)
                {
                    alta = Convert.ToInt16(nota[i]);
                }
                if (nota[i] < baja)
                {
                    baja = Convert.ToInt16(nota[i]);
                }
            }
            Console.WriteLine("Listado completo de alumnos: ");
            for (i = 0; i < cant; i++)
            {
                Console.WriteLine($"Alumno {i + 1}: {nombre[i]}    Nota: {nota[i]}");
            }
            for (i = 0; i < cant; i++)
            {
                prom += Convert.ToInt16(nota[i]);
            }
            Console.WriteLine($"El promedio de las notas de lso alumnos");
            Console.WriteLine("Ingrese un alumno específico para ser buscado: ");
            alum = (Console.ReadLine());
            for (i = 0; i < 7; i++)
            {
                if (nombre[i] == alum)
                {
                    dia = Convert.ToInt16(nota[i]);
                    encontrado = true;
                }
            }
            if (encontrado == true)
            {
                Console.WriteLine($"El alumno fue encontrado, su nota fue {dia}");
            }
            else
            {
                Console.WriteLine("El alumno no fue encontrado");
            }
        }
    }
}

