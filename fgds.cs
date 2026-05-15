// Punto 1

namespace Laboratorio
{
    internal class Program
    {
        struct Alumno
        {
            public string nombre;
            public int edad;
            public double nota;
        }


        static void Main(string[] args)
        {
            Alumno[] alumnos = new Alumno[3];


            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine($"Alumno {i + 1}");
                Console.Write("Nombre: ");
                alumnos[i].nombre = Console.ReadLine();


                Console.Write("Edad: ");
                alumnos[i].edad = int.Parse(Console.ReadLine() ?? "0");


                Console.Write("Nota: ");
                alumnos[i].nota = double.Parse(Console.ReadLine() ?? "0");


                Console.WriteLine();
            }


            Console.WriteLine("Lista de alumnos:");
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine($"Alumno {i + 1}");
                Console.WriteLine($"Nombre: {alumnos[i].nombre}");
                Console.WriteLine($"Edad:   {alumnos[i].edad}");
                Console.WriteLine($"Nota:   {alumnos[i].nota}");
                Console.WriteLine();
            }


            int indiceMejor = 0;
            for (int i = 1; i < alumnos.Length; i++)
            {
                if (alumnos[i].nota > alumnos[indiceMejor].nota)
                {
                    indiceMejor = i;
                }
            }


            Console.WriteLine($"Alumno con mejor nota: {alumnos[indiceMejor].nombre}");
        }
    }
}


// Punto 2

namespace Laboratorio
{
    internal class Program
    {
        struct Producto
        {
            public string nombre;
            public double precio;
            public int stock;
        }


        static void Main(string[] args)
        {
            Producto[] productos = new Producto[5];
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"Producto {i + 1}");


                Console.Write("Nombre: ");
                productos[i].nombre = Console.ReadLine();


                Console.Write("Precio: ");
                productos[i].precio = double.Parse(Console.ReadLine() ?? "0");


                Console.Write("Stock: ");
                productos[i].stock = int.Parse(Console.ReadLine() ?? "0");


                Console.WriteLine();
            }


            Console.WriteLine("=== Lista de productos ===");


            int indiceMasCaro = 0;
            double valorTotalTodos = 0;


            for (int i = 0; i < productos.Length; i++)
            {
                double valorTotalProducto = productos[i].precio * productos[i].stock;
                valorTotalTodos += valorTotalProducto;


                Console.WriteLine($"Producto: {productos[i].nombre}");
                Console.WriteLine($"Precio: {productos[i].precio}");
                Console.WriteLine($"Stock: {productos[i].stock}");
                Console.WriteLine($"Valor total: {valorTotalProducto}");
                Console.WriteLine();


                if (productos[i].precio > productos[indiceMasCaro].precio)
                {
                    indiceMasCaro = i;
                }
            }


            Console.WriteLine($"Producto más caro: {productos[indiceMasCaro].nombre} (Precio: {productos[indiceMasCaro].precio})");
            Console.WriteLine($"Valor total de TODOS los productos: {valorTotalTodos}");
        }
    }
}


// Punto 3

namespace Laboratorio
{
    internal class Program
    {
        struct Punto
        {
            public int x;
            public int y;
        }


        static void Main(string[] args)
        {
            Punto[] puntos = new Punto[4];


            for (int i = 0; i < puntos.Length; i++)
            {
                Console.WriteLine($"Punto {i + 1}");


                Console.Write("Ingrese X: ");
                puntos[i].x = int.Parse(Console.ReadLine() ?? "0");


                Console.Write("Ingrese Y: ");
                puntos[i].y = int.Parse(Console.ReadLine() ?? "0");


                Console.WriteLine();
            }


            Console.WriteLine("Puntos ingresados: ");


            for (int i = 0; i < puntos.Length; i++)
            {
                Console.WriteLine($"Punto {i + 1}: ({puntos[i].x},{puntos[i].y})");


                if (puntos[i].x == 0 && puntos[i].y == 0)
                {
                    Console.WriteLine("Está en el origen");
                }
                else if (puntos[i].y == 0)
                {
                    Console.WriteLine("Está sobre el eje X");
                }
                else if (puntos[i].x == 0)
                {
                    Console.WriteLine("Está sobre el eje Y");
                }
                else
                {
                    Console.WriteLine("No está ni sobre los ejes ni en el origen");
                }


                Console.WriteLine();
            }
        }
    }
}
