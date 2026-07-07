// EJERCICIOS DE SWITCH

// EJ 1 SWITCH

namespace asd
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese un número del 1 al 7: ");
            int dia = Convert.ToInt32(Console.ReadLine());
    
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Día inválido.");
                    break;
            }
        }
    }
}

// EJ 2 SWITCH

namespace asd
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese un número del 1 al 12: ");
            int mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Mes inválido.");
                    break;
            }
        }
    }
 }

// EJ 3 SWITCH

namespace asd
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Primer número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1-Sumar");
            Console.WriteLine("2-Restar");
            Console.WriteLine("3-Multiplicar");
            Console.WriteLine("4-Dividir");

            Console.Write("Opción: ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Resultado: " + (n1 + n2));
                    break;

                case 2:
                    Console.WriteLine("Resultado: " + (n1 - n2));
                    break;

                case 3:
                    Console.WriteLine("Resultado: " + (n1 * n2));
                    break;

                case 4:
                    if (n2 != 0)
                        Console.WriteLine("Resultado: " + (n1 / n2));
                    else
                        Console.WriteLine("No se puede dividir por cero.");
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }
        }
    }
}

// EJ 4 SWITCH

namespace asd
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese los metros: ");
            double metros = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1-Centímetros");
            Console.WriteLine("2-Milímetros");
            Console.WriteLine("3-Kilómetros");
            Console.WriteLine("4-Pulgadas");

            Console.Write("Opción: ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Resultado: " + (metros * 100) + " cm");
                    break;

                case 2:
                    Console.WriteLine("Resultado: " + (metros * 1000) + " mm");
                    break;

                case 3:
                    Console.WriteLine("Resultado: " + (metros / 1000) + " km");
                    break;

                case 4:
                    Console.WriteLine("Resultado: " + (metros * 39.37) + " pulgadas");
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }
        }
    }
}

// EJ 5 SWITCH

namespace asd
{
    internal class Program
    {
        static void Main()
        {
            double saldo = 100000;

            Console.WriteLine("===== CAJERO =====");
            Console.WriteLine("1-Consultar saldo");
            Console.WriteLine("2-Depositar");
            Console.WriteLine("3-Extraer");
            Console.WriteLine("4-Salir");

            Console.Write("Opción: ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Saldo actual: $" + saldo);
                    break;

                case 2:
                    Console.Write("Monto a depositar: ");
                    double deposito = Convert.ToDouble(Console.ReadLine());
                    saldo += deposito;
                    Console.WriteLine("Saldo actual: $" + saldo);
                    break;

                case 3:
                    Console.Write("Monto a retirar: ");
                    double retiro = Convert.ToDouble(Console.ReadLine());

                    if (retiro <= saldo)
                    {
                        saldo -= retiro;
                        Console.WriteLine("Extracción realizada.");
                        Console.WriteLine("Saldo disponible: $" + saldo);
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }
        }
    }
}


// EJERCICIOS DE WHILE


// EJ 1 WHILE

namespace asd
{
    internal class Program
    {
        static void Main()
        {
            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine($"{i}");
                i += 1;
            }

        }
    }
}

// EJ 2 WHILE

namespace asd
{
    internal class Program
    {
        static void Main()
        {
            int i = 10;

            while (i >= 1)
            {
                Console.WriteLine($"{i}");
                i -= 1;
            }

        }
    }
}

// EJ 3 WHILE

namespace asd
{
    internal class Program
    {
        static void Main()
        {
            int n = 999;
            int i = 0;
            int tot = 0;

            Console.WriteLine("Ingrese un número positivo: ");
            n = Convert.ToInt16(Console.ReadLine());
            while (i < n)
            {
                i += 1;
                tot += i;
                Console.WriteLine($"{tot}");
            }
            Console.WriteLine($"Suma de todos los números: {tot}");
        }
    }
}

// EJ 4 WHILE

namespace asd
{
    class Program
    {
        static void Main()
        {
            int n = 999;
            int i = 0;
            int tot = 0;
            int prom;
            int nota;

            Console.WriteLine("Ingrese la cantidad de alumnos: ");
            n = Convert.ToInt16(Console.ReadLine());
            while (i < n)
            {
                i += 1;
                Console.WriteLine($"Nota del alumno {i}: ");
                nota = Convert.ToInt16(Console.ReadLine());
                tot += nota;
            }
            prom = tot / n;
            Console.WriteLine($"Suma de todos los números: {tot}");
            Console.WriteLine($"Promedio de todos los números: {prom}");
        }
    }
}

// EJ 5 WHILE

namespace asd
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("===== MENÚ =====");
            Console.WriteLine("Saludar");
            Console.WriteLine("Mostrar la fecha");
            Console.WriteLine("Mostrar un mensaje");
            Console.WriteLine("Salir");

            Console.Write("Opción: ");
            int op = Convert.ToInt32(Console.ReadLine());

            while (op >= 0 && op < 4)           
            {
                if (op == 1)
                {
                    Console.WriteLine("¡Hola!");
                    break;
                }
                if (op == 2)
                {
                    Console.Write("7/7/2026");
                    break;
                }
                if (op == 3)
                {
                    Console.WriteLine("Bienvenido al programa.");
                    break;
                }
                if (op == 0)
                {
                    break;
                }
            }
        }
    }
}


// EJERCICIOS DE DO-WHILE


// EJ 1 DO-WHILE

namespace asd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }
    }
}

// EJ 2 DO-WHILE

namespace asd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            do
            {
                Console.Write("Ingrese un nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("¿Desea ingresar otro nombre? (S/N): ");
                respuesta = Console.ReadLine();
            } while (respuesta.ToUpper() == "S");
        }
    }
}

// EJ 3 DO-WHILE

namespace asd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int cantidad = 0;
            string respuesta;

            do
            {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());
                suma += numero;
                cantidad++;

                Console.Write("¿Desea ingresar otro número? (S/N): ");
                respuesta = Console.ReadLine();
            } while (respuesta.ToUpper() == "S");

            Console.WriteLine("Cantidad de números: " + cantidad);
            Console.WriteLine("Suma total: " + suma);
        }
    }
}

// EJ 4 DO-WHILE

namespace asd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("===== CALCULADORA =====");
                Console.WriteLine("1 - Sumar");
                Console.WriteLine("2 - Restar");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("0 - Salir");

                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion >= 1 && opcion <= 4)
                {
                    Console.Write("Ingrese el primer número: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());
                    double resultado = 0;

                    switch (opcion)
                    {
                        case 1:
                            resultado = num1 + num2;
                            Console.WriteLine("Resultado: " + resultado);
                            break;
                        case 2:
                            resultado = num1 - num2;
                            Console.WriteLine("Resultado: " + resultado);
                            break;
                        case 3:
                            resultado = num1 * num2;
                            Console.WriteLine("Resultado: " + resultado);
                            break;
                        case 4:
                            if (num2 != 0)
                            {
                                resultado = num1 / num2;
                                Console.WriteLine("Resultado: " + resultado);
                            }
                            else
                            {
                                Console.WriteLine("Error: no se puede dividir por cero.");
                            }
                            break;
                    }
                }
                else if (opcion != 0)
                {
                    Console.WriteLine("Opción inválida.");
                }
            } while (opcion != 0);
        }
    }
}

// EJ 5 DO-WHILE

namespace asd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();
            List<int> edades = new List<int>();
            List<double> notas = new List<double>();
            string respuesta;

            do
            {
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                nombres.Add(nombre);

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                edades.Add(edad);

                Console.Write("Nota: ");
                double nota = double.Parse(Console.ReadLine());
                notas.Add(nota);

                Console.Write("¿Desea ingresar otro alumno? (S/N): ");
                respuesta = Console.ReadLine();
            } while (respuesta.ToUpper() == "S");

            int cantidad = notas.Count;
            double suma = 0;
            double notaMasAlta = notas[0];
            double notaMasBaja = notas[0];

            for (int i = 0; i < cantidad; i++)
            {
                suma += notas[i];

                if (notas[i] > notaMasAlta)
                {
                    notaMasAlta = notas[i];
                }

                if (notas[i] < notaMasBaja)
                {
                    notaMasBaja = notas[i];
                }
            }

            double promedio = suma / cantidad;

            Console.WriteLine("Cantidad de alumnos: " + cantidad);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Nota más alta: " + notaMasAlta);
            Console.WriteLine("Nota más baja: " + notaMasBaja);
        }
    }
}

