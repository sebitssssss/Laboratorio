namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1 = 0;
            int lado2 = 0;
            int lado3 = 0;
            bool condicion;
            bool condicion2;
            bool condicion3;
            Console.WriteLine("Ingresa el valor del primer lado del triángulo: ");
            lado1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingresa el valor del segundo lado del triángulo:");
            lado2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingresa el valor del tercer lado del triángulo:");
            lado3 = Convert.ToInt16(Console.ReadLine());
            condicion = lado1 > 0;
            condicion2 = lado2 > 0;
            condicion3 = lado3 > 0;
            if (condicion)
            {
                if (condicion2)
                {
                    if (condicion3)
                    {
                        if (lado1 == lado2)
                        {
                            if (lado2 == lado3)
                            {
                                Console.WriteLine("El triángulo es equilátero.");
                            }
                            else
                            {
                                Console.WriteLine("El triángulo es isósceles.");
                            }
                        }
                        else
                        {
                            if (lado2 == lado3)
                            {
                                Console.WriteLine("El triángulo es isósceles.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese 3 valores correctos.");
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese 3 valores correctos.");
                }
            }
            else
            {
                Console.WriteLine("Ingrese 3 valores correctos.");
            }
        }
    }
}
