namespace Clase10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena1;
            string cadena2;
            int longitud;
            int ascii;
            int numero;

            Console.WriteLine("Ingrese una cadena de minimo 15 caracteres: ");
            cadena1 = Console.ReadLine();
            while (cadena1.Length < 15)
            {
                Console.WriteLine("Ingrese la cantidad correcta");
                cadena1 = Console.ReadLine();
            }
            longitud = cadena1.Length;

            Console.WriteLine("Ingrese un caracter");
            cadena2 = Console.ReadLine();
            while (cadena2.Length != 1)
            {
                Console.WriteLine("Ingrese la cantidad correcta");
                cadena2 = Console.ReadLine();
            }

            Console.WriteLine("Ingrese un numero entre 3 y 5");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero < 3 || numero > 5)
            {
                Console.WriteLine("Ingrese correctamente");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(cadena1 + cadena2 + numero);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"{cadena1.ToUpper()} {cadena1.ToLower()}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(cadena1.Substring(0, numero));
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(cadena1.Substring(longitud - numero, numero));
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"{cadena1.Substring(3, 1)} {cadena1.Substring(9, 1)} {cadena1.Substring(longitud - 1, 1)}");
            Console.WriteLine("----------------------------------------------------");

            string[] inverso = new string[longitud];
            for (int i = 0; i < longitud; i++)
            {
                inverso[i] = cadena1.Substring(i, 1);
            }
            for (int i = longitud - 1; i >= 0; i--)
            {
                Console.Write(inverso[i]);
            }
            Console.Write(" ");
            for (int i = 0; i < numero * 2; i++)
            {
                Console.Write(cadena1.Substring(1, 1));
            }
            
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"La posicion de la primera ocurrencia entre la primera cadena y la segunda es: {cadena1.IndexOf(cadena2+1)}");
            Console.WriteLine("----------------------------------------------------");
            ascii = (int)cadena1[0];
            Console.WriteLine($"Numero ASCII: {ascii}");
        }
    }
}
