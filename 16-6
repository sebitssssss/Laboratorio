namespace asdasd
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
     
            while (opcion != "0")
            {
                Console.WriteLine();
                Console.WriteLine(" | MENU DE EJERCICIOS |");
                Console.WriteLine("1.  Longitud de una cadena");
                Console.WriteLine("2.  Conversión de texto");
                Console.WriteLine("3.  Contador de vocales");
                Console.WriteLine("4.  Primera y última letra");
                Console.WriteLine("5.  División segura");
                Console.WriteLine("6.  Acceso a posiciones de una cadena");
                Console.WriteLine("7.  Búsqueda de palabras");
                Console.WriteLine("8.  Suma de números separados por comas");
                Console.WriteLine("9.  Invertir texto");
                Console.WriteLine("10. Validación de contraseña");
                Console.WriteLine("11. Validación de rango");
                Console.WriteLine("12. Uso de NullReferenceException");
                Console.WriteLine("13. Overflow aritmético");
                Console.WriteLine("14. Analizador de texto");
                Console.WriteLine("0.  Salir");
                Console.WriteLine();
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();
                Console.WriteLine();
     
                switch (opcion)
                {
                    case "1":
                        Ejercicio1();
                        break;
                    case "2":
                        Ejercicio2();
                        break;
                    case "3":
                        Ejercicio3();
                        break;
                    case "4":
                        Ejercicio4();
                        break;
                    case "5":
                        Ejercicio5();
                        break;
                    case "6":
                        Ejercicio6();
                        break;
                    case "7":
                        Ejercicio7();
                        break;
                    case "8":
                        Ejercicio8();
                        break;
                    case "9":
                        Ejercicio9();
                        break;
                    case "10":
                        Ejercicio10();
                        break;
                    case "11":
                        Ejercicio11();
                        break;
                    case "12":
                        Ejercicio12();
                        break;
                    case "13":
                        Ejercicio13();
                        break;
                    case "14":
                        Ejercicio14();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }
     
        // Ejercicio 1
        static void Ejercicio1()
        {
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine($"La frase contiene {frase.Length} caracteres.");
        }
     
        // Ejercicio 2
        static void Ejercicio2()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();
            Console.WriteLine($"Mayúsculas: {palabra.ToUpper()}");
            Console.WriteLine($"Minúsculas: {palabra.ToLower()}");
            Console.WriteLine($"Cantidad de caracteres: {palabra.Length}");
        }
     
        // Ejercicio 3
        static void Ejercicio3()
        {
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();
            string vocales = "aeiouAEIOU";
            int contador = 0;
     
            foreach (char c in frase)
            {
                if (vocales.IndexOf(c) != -1)
                {
                    contador++;
                }
            }
     
            Console.WriteLine($"La frase contiene {contador} vocales.");
        }
     
        // Ejercicio 4
        static void Ejercicio4()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();
     
            try
            {
                char primera = palabra[0];
                char ultima = palabra[palabra.Length - 1];
                Console.WriteLine($"Primera letra: {primera}");
                Console.WriteLine($"Última letra: {ultima}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: la cadena ingresada está vacía.");
            }
        }
     
        // Ejercicio 5
        static void Ejercicio5()
        {
            try
            {
                Console.Write("Ingrese el primer número: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                int resultado = numero1 / numero2;
                Console.WriteLine($"El resultado de la división es: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: debe ingresar valores numéricos enteros.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: no se puede dividir por cero.");
            }
        }
     
        // Ejercicio 6
        static void Ejercicio6()
        {
            try
            {
                Console.Write("Ingrese una palabra: ");
                string palabra = Console.ReadLine();
                Console.Write("Ingrese una posición: ");
                int posicion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"El carácter en la posición {posicion} es: {palabra[posicion]}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: debe ingresar un número entero válido.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: la posición ingresada está fuera de rango.");
            }
        }
     
        // Ejercicio 7
        static void Ejercicio7()
        {
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();
            Console.Write("Ingrese una palabra a buscar: ");
            string palabra = Console.ReadLine();
     
            if (frase.Contains(palabra))
            {
                Console.WriteLine("La palabra se encuentra dentro de la frase.");
            }
            else
            {
                Console.WriteLine("La palabra no se encuentra dentro de la frase.");
            }
        }
     
        // Ejercicio 8
        static void Ejercicio8()
        {
            Console.Write("Ingrese números separados por comas: ");
            string entrada = Console.ReadLine();
            string[] numeros = entrada.Split(',');
            int suma = 0;
     
            try
            {
                foreach (string numero in numeros)
                {
                    suma += Convert.ToInt32(numero);
                }
     
                Console.WriteLine($"La suma total es: {suma}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: uno de los valores ingresados no es un número válido.");
            }
        }
     
        // Ejercicio 9
        static void Ejercicio9()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();
            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            string invertida = new string(caracteres);
            Console.WriteLine($"Palabra invertida: {invertida}");
        }
     
        // Ejercicio 10
        static void Ejercicio10()
        {
            try
            {
                Console.Write("Ingrese una contraseña: ");
                string contrasena = Console.ReadLine();
                bool tieneNumero = false;
     
                foreach (char c in contrasena)
                {
                    if (char.IsDigit(c))
                    {
                        tieneNumero = true;
                        break;
                    }
                }
     
                if (contrasena.Length < 8 || !tieneNumero)
                {
                    throw new ArgumentException("La contraseña debe tener al menos 8 caracteres y contener al menos un número.");
                }
     
                Console.WriteLine("La contraseña es válida.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
     
        // Ejercicio 11
        static void Ejercicio11()
        {
            try
            {
                Console.Write("Ingrese una edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());
     
                if (edad < 1 || edad > 120)
                {
                    throw new ArgumentOutOfRangeException("edad", "La edad debe estar entre 1 y 120.");
                }
     
                Console.WriteLine($"La edad ingresada es válida: {edad}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: debe ingresar un número entero válido.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
     
        // Ejercicio 12
        static void Ejercicio12()
        {
            try
            {
                string texto = null;
                int longitud = texto.Length;
                Console.WriteLine($"Longitud: {longitud}");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error: se intentó acceder a una variable no inicializada (referencia nula).");
            }
        }
     
        // Ejercicio 13
        static void Ejercicio13()
        {
            try
            {
                Console.Write("Ingrese el primer número: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());
     
                checked
                {
                    int suma = numero1 + numero2;
                    Console.WriteLine($"La suma es: {suma}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: debe ingresar valores numéricos enteros.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: se produjo un desbordamiento aritmético (overflow).");
            }
        }
     
        // Ejercicio 14
        static void Ejercicio14()
        {
            try
            {
                Console.Write("Ingrese una frase: ");
                string frase = Console.ReadLine();
     
                if (string.IsNullOrEmpty(frase))
                {
                    throw new ArgumentException("La frase no puede estar vacía.");
                }
     
                string vocales = "aeiouAEIOU";
                int cantidadVocales = 0;
     
                foreach (char c in frase)
                {
                    if (vocales.IndexOf(c) != -1)
                    {
                        cantidadVocales++;
                    }
                }
     
                string[] palabras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
     
                Console.WriteLine($"Cantidad de caracteres: {frase.Length}");
                Console.WriteLine($"Cantidad de palabras: {palabras.Length}");
                Console.WriteLine($"Cantidad de vocales: {cantidadVocales}");
     
                Console.Write("Ingrese una posición: ");
                int posicion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"El carácter en la posición {posicion} es: {frase[posicion]}");
     
                Console.Write("Ingrese un número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                int resultado = 100 / numero;
                Console.WriteLine($"100 dividido por {numero} es: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: debe ingresar un valor numérico válido.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: la posición ingresada está fuera de rango.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: no se puede dividir por cero.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}     
