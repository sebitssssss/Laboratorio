// Ejercicio 1

namespace ConsoleApp1

{

    internal class Program

    {

        struct alumno

        {

            public string nombre;

            public int edad;

            public double nota;

        }

        static void Main(string[] args)

        {

            alumno[] alumnos = new alumno[5];


            double mayor = -99999;

            string nombre = "aa";


            for (int i = 0; i < 5; i++)

            {

                Console.WriteLine("Nombre del alumno: "+ i);

                alumnos[i].nombre = Console.ReadLine();

                Console.WriteLine("edad del alumno: " + i);

                alumnos[i].edad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Nota del alumno: " + i);

                alumnos[i].nota = Convert.ToDouble(Console.ReadLine());

            }

            for (int i = 0; i < 5; i++)

            {

                if (alumnos[i].nota > mayor)

                {

                    mayor = alumnos[i].nota;

                    nombre = alumnos[i].nombre;

                }

            }

            Console.WriteLine($"Nombre del alumno con mas nota: {nombre} {mayor}");

        }

    }

}


// Ejercicio 2

using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ConsoleApp1

{

    internal class Program

    {

        struct producto

        {

            public int codigo;

            public string nombre;

            public double precio;

        }

        static void Main(string[] args)

        {

            producto[] productos = new producto[10];


            double mayor = -99999;

            double menor = 99999;

            double promedio = 0;

            string nombre1 = "";

            string nombre2 = "";

            double suma = 0;


            for (int i = 0; i < 3; i++)

            {

                Console.WriteLine("Nombre del producto: "+ i);

                productos[i].nombre = Console.ReadLine();

                Console.WriteLine("codigo del producto: " + i);

                productos[i].codigo = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("precio del producto: " + i);

                productos[i].precio = Convert.ToDouble(Console.ReadLine());

            }

            for (int i = 0; i < 3; i++)

            {

                Console.WriteLine($"{productos[i].nombre}");


                suma += productos[i].precio;

                promedio = suma / 3;


                if (productos[i].precio > mayor)

                {

                    mayor = productos[i].precio;

                    nombre1 = productos[i].nombre;

                }


                if (productos[i].precio < menor)

                {

                    menor = productos[i].precio;

                    nombre2 = productos[i].nombre;

                }

            }

            Console.WriteLine($"Nombre del producto mas caro: {nombre1} {mayor}");

            Console.WriteLine($"Nombre del producto mas barato: {nombre2} {menor}");

            Console.WriteLine($"El promedio de los productos es: {promedio}");

        }

    }

}


// Ejercicio 3

namespace ConsoleApp1

{

    internal class Program

    {

        struct alumno

        {

            public string nombre;

            public int edad;

            public double nota;

        }

        static void Main(string[] args)

        {

            alumno[] alumnos = new alumno[5];


            for (int i = 0; i < 5; i++)

            {

                Console.WriteLine("Nombre del alumno: " + i);

                alumnos[i].nombre = Console.ReadLine();

                Console.WriteLine("edad del alumno: " + i);

                alumnos[i].edad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Nota del alumno: " + i);

                alumnos[i].nota = Convert.ToDouble(Console.ReadLine());

            }

            for (int i = 0; i < 5; i++)

            {

                for (int j = 0; j < 5; j++)

                {

                    if (alumnos[i].nota < alumnos[j].nota)

                    {

                        double aux = alumnos[i].nota;

                        alumnos[i].nota = alumnos[j].nota;

                        alumnos[j].nota = aux;

                    }

                }

            }

            for (int i = 0; i < 5; i++)

            {

                Console.WriteLine($"{alumnos[i].nombre} {alumnos[i].nota}");

            }


        }

    }

}

// Ejercicio 4

namespace ConsoleApp1

{

    internal class Program

    {

        struct alumno

        {

            public int edad;

            public string nombre;

            public double nota;

        }

        static void Main(string[] args)

        {

            alumno[] alumnos = new alumno[10];


            double mayor = -99999;

            double menor = 99999;

            double promedio = 0;

            string nombre1 = "";

            string nombre2 = "";

            double suma = 0;

            string opcion = "";




            do

            {

                for (int i = 0; i < 10; i++)

                {

                    opcion = Console.ReadLine();

                    Console.WriteLine("Nombre del alumno: " + i);

                    alumnos[i].nombre = Console.ReadLine();

                    Console.WriteLine("edad del alumno: " + i);

                    alumnos[i].edad = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("nota del alumno: " + i);

                    alumnos[i].nota = Convert.ToDouble(Console.ReadLine());

                }

            } while (opcion != "FIN");

            for (int i = 0; i < 10; i++)

            {

                Console.WriteLine($"{alumnos[i].nombre}");


                suma += alumnos[i].nota;

                promedio = suma / 10;


                if (alumnos[i].nota > mayor)

                {

                    mayor = alumnos[i].nota;

                    nombre1 = alumnos[i].nombre;

                }


                if (alumnos[i].nota < menor)

                {

                    menor = alumnos[i].nota;

                    nombre2 = alumnos[i].nombre;

                }

            }

            for (int i = 0; i < 10; i++)

            {

                Console.WriteLine(alumnos[i].nombre);

            }

            Console.WriteLine($"Nombre del alumno con mayor nota: {nombre1} {mayor}");

            Console.WriteLine($"Nombre del alumno con menor nota: {nombre2} {menor}");

            Console.WriteLine($"El promedio de las notas es: {promedio}");

        }

    }

}
