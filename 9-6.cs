// BLOQUE 1

// 1 A
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
        Console.WriteLine(i);
}

// 1 B
Console.Write("Ingresa tu edad: ");
int edad = int.Parse(Console.ReadLine());
if (edad < 18)
    Console.WriteLine("Sos menor de edad.");
else if (edad == 18)
    Console.WriteLine("Tenés justo 18.");
else
    Console.WriteLine("Sos mayor de edad.");

// 1 C
Console.Write("Ingresa una palabra: ");
string palabra = Console.ReadLine();
Console.WriteLine("La palabra tiene " + palabra.Length + " letras.");

// 1 D
string contrasena = "secreta";
int intentos = 0;
while (intentos < 5)
{
    Console.Write("Ingresa la contraseña: ");
    string intento = Console.ReadLine();
    intentos++;
    if (intento == contrasena)
    {
        Console.WriteLine("Contraseña correcta.");
        break;
    }
    else
    {
        Console.WriteLine("Incorrecto. Te quedan " + (5 - intentos) + " intentos.");
    }
}
if (intentos == 5)
    Console.WriteLine("Agotaste los intentos.");

// 1 E
int maximo = int.MinValue;
for (int i = 0; i < 10; i++)
{
    Console.Write("Ingresa el número " + (i + 1) + ": ");
    int num = int.Parse(Console.ReadLine());
    if (num > maximo)
        maximo = num;
}
Console.WriteLine("El número más alto fue: " + maximo);

// 1 F
Console.Write("Ingresa tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Hola, " + System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombre.ToLower()) + "!");

// 1 G
for (int i = 1; i <= 10; i++)
    Console.WriteLine("7 x " + i + " = " + (7 * i));

// 1 H
for (int i = 10; i >= 1; i--)
    Console.WriteLine(i);
Console.WriteLine("oa");

// 1 I
Console.Write("Ingresa un número: ");
int n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
    Console.WriteLine("par");
else
    Console.WriteLine("impar");

// 1 J
Console.Write("Ingresa una frase: ");
string frase = Console.ReadLine().ToLower();
int vocales = 0;
foreach (char c in frase)
    if ("aeiouáéíóú".Contains(c))
        vocales++;
Console.WriteLine("La frase tiene " + vocales + " vocales.");

// 1 K
Console.Write("Ingresa un número: ");
int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= 12; i++)
    Console.WriteLine(num + " x " + i + " = " + (num * i));

// 1 L
int total = 0;
int cantidad = 0;
while (total <= 100)
{
    Console.Write("Ingresa un número: ");
    int n = int.Parse(Console.ReadLine());
    total += n;
    cantidad++;
}
Console.WriteLine("Ingresaste " + cantidad + " números. Total acumulado: " + total);

// 1 M
Console.Write("Ingresa una palabra: ");
string palabra = Console.ReadLine();
foreach (char c in palabra)
    Console.WriteLine(c);

// 1 N
Console.Write("Ingresa tu edad: ");
int edad = int.Parse(Console.ReadLine());
bool puedeManejar = edad >= 18;
bool puedeVotar = edad >= 16;
if (puedeVotar && puedeManejar)
    Console.WriteLine("Podés votar y manejar.");
else if (puedeVotar)
    Console.WriteLine("Podés votar pero no manejar.");
else if (puedeManejar)
    Console.WriteLine("Podés manejar pero no votar.");
else
    Console.WriteLine("No podés votar ni manejar.");

// 1 O
for (int i = 50; i >= 0; i -= 5)
    Console.WriteLine(i);

// 1 P
string contrasena = "";
while (true)
{
    Console.Write("Ingresa una contraseña: ");
    string c1 = Console.ReadLine();
    Console.Write("Repetila: ");
    string c2 = Console.ReadLine();
    if (c1 == c2)
    {
        contrasena = c1;
        Console.WriteLine("Acceso permitido.");
        break;
    }
    else
        Console.WriteLine("No coinciden. Intentá de nuevo.");
}

// 1 Q
while (true)
{
    Console.Write("Ingresa un nombre: ");
    string nombre = Console.ReadLine();
    if (nombre.Length > 10)
    {
        Console.WriteLine("Nombre demasiado largo. Fin del programa.");
        break;
    }
}

// 1 R
Console.Write("Ingresa una oración: ");
string oracion = Console.ReadLine().ToLower();
int contadorA = 0;
foreach (char c in oracion)
    if (c == 'a')
        contadorA++;
Console.WriteLine("La oración tiene " + contadorA + " letras 'a'.");

// MENÚ BLOQUE 1
using System;
using System.Globalization;

class Bloque1
{
    static void Main()
    {
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n=== MENÚ BLOQUE 1 ===");
            Console.WriteLine("a. Múltiplos de 3 del 1 al 100");
            Console.WriteLine("b. Mayor/menor de edad");
            Console.WriteLine("c. Longitud de palabra");
            Console.WriteLine("d. Adivinar contraseña");
            Console.WriteLine("e. Mayor de 10 números");
            Console.WriteLine("f. Saludar con mayúsculas");
            Console.WriteLine("g. Tabla del 7");
            Console.WriteLine("h. Cuenta regresiva");
            Console.WriteLine("i. Par o impar");
            Console.WriteLine("j. Contar vocales");
            Console.WriteLine("k. Tabla de multiplicar");
            Console.WriteLine("l. Acumular hasta 100");
            Console.WriteLine("m. Letras en líneas");
            Console.WriteLine("n. Votar y manejar");
            Console.WriteLine("o. Descendente de 5 en 5");
            Console.WriteLine("p. Confirmar contraseña");
            Console.WriteLine("q. Nombres hasta 10 caracteres");
            Console.WriteLine("r. Contar letras 'a'");
            Console.WriteLine("x. Salir");
            Console.Write("Elegí una opción: ");
            string op = Console.ReadLine().ToLower();

            switch (op)
            {
                case "a": Ej1a(); break;
                case "b": Ej1b(); break;
                case "c": Ej1c(); break;
                case "d": Ej1d(); break;
                case "e": Ej1e(); break;
                case "f": Ej1f(); break;
                case "g": Ej1g(); break;
                case "h": Ej1h(); break;
                case "i": Ej1i(); break;
                case "j": Ej1j(); break;
                case "k": Ej1k(); break;
                case "l": Ej1l(); break;
                case "m": Ej1m(); break;
                case "n": Ej1n(); break;
                case "o": Ej1o(); break;
                case "p": Ej1p(); break;
                case "q": Ej1q(); break;
                case "r": Ej1r(); break;
                case "x": salir = true; break;
                default: Console.WriteLine("Opción inválida."); break;
            }
        }
    }

    static void Ej1a()
    {
        for (int i = 1; i <= 100; i++)
            if (i % 3 == 0)
                Console.WriteLine(i);
    }

    static void Ej1b()
    {
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());
        if (edad < 18) Console.WriteLine("Sos menor de edad.");
        else if (edad == 18) Console.WriteLine("Tenés justo 18.");
        else Console.WriteLine("Sos mayor de edad.");
    }

    static void Ej1c()
    {
        Console.Write("Ingresa una palabra: ");
        string p = Console.ReadLine();
        Console.WriteLine("Tiene " + p.Length + " letras.");
    }

    static void Ej1d()
    {
        string contrasena = "secreta";
        int intentos = 0;
        while (intentos < 5)
        {
            Console.Write("Ingresa la contraseña: ");
            string intento = Console.ReadLine();
            intentos++;
            if (intento == contrasena) { Console.WriteLine("Contraseña correcta."); return; }
            else Console.WriteLine("Incorrecto. Te quedan " + (5 - intentos) + " intentos.");
        }
        Console.WriteLine("Agotaste los intentos.");
    }

    static void Ej1e()
    {
        int maximo = int.MinValue;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            int n = int.Parse(Console.ReadLine());
            if (n > maximo) maximo = n;
        }
        Console.WriteLine("El más alto fue: " + maximo);
    }

    static void Ej1f()
    {
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombre.ToLower()) + "!");
    }

    static void Ej1g()
    {
        for (int i = 1; i <= 10; i++)
            Console.WriteLine("7 x " + i + " = " + (7 * i));
    }

    static void Ej1h()
    {
        for (int i = 10; i >= 1; i--)
            Console.WriteLine(i);
        Console.WriteLine("oa");
    }

    static void Ej1i()
    {
        Console.Write("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 2 == 0 ? "par" : "impar");
    }

    static void Ej1j()
    {
        Console.Write("Ingresa una frase: ");
        string frase = Console.ReadLine().ToLower();
        int v = 0;
        foreach (char c in frase)
            if ("aeiouáéíóú".Contains(c)) v++;
        Console.WriteLine("Vocales: " + v);
    }

    static void Ej1k()
    {
        Console.Write("Ingresa un número: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 12; i++)
            Console.WriteLine(num + " x " + i + " = " + (num * i));
    }

    static void Ej1l()
    {
        int total = 0, cantidad = 0;
        while (total <= 100)
        {
            Console.Write("Ingresa un número: ");
            int n = int.Parse(Console.ReadLine());
            total += n;
            cantidad++;
        }
        Console.WriteLine("Ingresaste " + cantidad + " números. Total: " + total);
    }

    static void Ej1m()
    {
        Console.Write("Ingresa una palabra: ");
        string p = Console.ReadLine();
        foreach (char c in p)
            Console.WriteLine(c);
    }

    static void Ej1n()
    {
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());
        bool manejar = edad >= 18;
        bool votar = edad >= 16;
        if (votar && manejar) Console.WriteLine("Podés votar y manejar.");
        else if (votar) Console.WriteLine("Podés votar pero no manejar.");
        else if (manejar) Console.WriteLine("Podés manejar pero no votar.");
        else Console.WriteLine("No podés votar ni manejar.");
    }

    static void Ej1o()
    {
        for (int i = 50; i >= 0; i -= 5)
            Console.WriteLine(i);
    }

    static void Ej1p()
    {
        while (true)
        {
            Console.Write("Ingresa una contraseña: ");
            string c1 = Console.ReadLine();
            Console.Write("Repetila: ");
            string c2 = Console.ReadLine();
            if (c1 == c2) { Console.WriteLine("Acceso permitido."); break; }
            else Console.WriteLine("No coinciden. Intentá de nuevo.");
        }
    }

    static void Ej1q()
    {
        while (true)
        {
            Console.Write("Ingresa un nombre: ");
            string nombre = Console.ReadLine();
            if (nombre.Length > 10) { Console.WriteLine("Nombre demasiado largo. Fin."); break; }
        }
    }

    static void Ej1r()
    {
        Console.Write("Ingresa una oración: ");
        string oracion = Console.ReadLine().ToLower();
        int count = 0;
        foreach (char c in oracion)
            if (c == 'a') count++;
        Console.WriteLine("Letras 'a': " + count);
    }
}


// BLOQUE 2

// 2 A
Random rnd = new Random();
int secreto = rnd.Next(1, 11);
while (true)
{
    Console.Write("Adiviná el número (1-10): ");
    int intento = int.Parse(Console.ReadLine());
    if (intento == secreto) { Console.WriteLine("¡Adivinaste!"); break; }
    else if (intento < secreto) Console.WriteLine("Es mayor.");
    else Console.WriteLine("Es menor.");
}

// 2 B
Console.Write("Ingresa un número: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Divisores: ");
for (int i = 1; i <= num; i++)
    if (num % i == 0)
        Console.Write(i + " ");
Console.WriteLine();

// 2 C
int a = 0, b = 1;
Console.Write(a + " " + b);
for (int i = 2; i < 20; i++)
{
    int siguiente = a + b;
    Console.Write(" " + siguiente);
    a = b;
    b = siguiente;
}
Console.WriteLine();

// 2 D
Console.Write("Operación (+, -, *, /): ");
string op = Console.ReadLine();
Console.Write("Primer número: ");
double n1 = double.Parse(Console.ReadLine());
Console.Write("Segundo número: ");
double n2 = double.Parse(Console.ReadLine());
switch (op)
{
    case "+": Console.WriteLine("Resultado: " + (n1 + n2)); break;
    case "-": Console.WriteLine("Resultado: " + (n1 - n2)); break;
    case "*": Console.WriteLine("Resultado: " + (n1 * n2)); break;
    case "/":
        if (n2 != 0) Console.WriteLine("Resultado: " + (n1 / n2));
        else Console.WriteLine("No se puede dividir por cero.");
        break;
    default: Console.WriteLine("Operación inválida."); break;
}

// 2 E
Console.Write("Ingresa un número: ");
int n = int.Parse(Console.ReadLine());
long factorial = 1;
for (int i = 2; i <= n; i++)
    factorial *= i;
Console.WriteLine("Factorial: " + factorial);

// 2 F
int turno = 1;
List<string> nombres = new List<string>();
while (true)
{
    Console.Write("Ingresa un nombre (o 'fin' para terminar): ");
    string nombre = Console.ReadLine();
    if (nombre.ToLower() == "fin") break;
    nombres.Add(nombre);
}
Console.WriteLine("\n=== Turnos ===");
for (int i = 0; i < nombres.Count; i++)
    Console.WriteLine("Turno " + (i + 1) + ": " + nombres[i]);

// 2 G
int pares = 0;
for (int i = 1; i <= 100; i++)
    if (i % 2 == 0) pares++;
Console.WriteLine("Números pares entre 1 y 100: " + pares);

// 2 H
while (true)
{
    Console.Write("Ingresa temperatura en Celsius (o 'salir'): ");
    string entrada = Console.ReadLine();
    if (entrada.ToLower() == "salir") break;
    double celsius = double.Parse(entrada);
    double fahrenheit = celsius * 9 / 5 + 32;
    Console.WriteLine(celsius + "°C = " + fahrenheit + "°F");
}

// 2 I
Console.Write("Ingresa un número: ");
int num = int.Parse(Console.ReadLine());
bool esPrimo = num > 1;
for (int i = 2; i <= Math.Sqrt(num); i++)
    if (num % i == 0) { esPrimo = false; break; }
Console.WriteLine(num + (esPrimo ? " es primo." : " no es primo."));

// 2 J
List<string> nombres = new List<string>();
while (true)
{
    Console.Write("Ingresa un nombre (o 'fin'): ");
    string nombre = Console.ReadLine();
    if (nombre.ToLower() == "fin") break;
    nombres.Add(nombre);
}
foreach (string n in nombres)
    Console.WriteLine("¡Hola, " + n + "!");

// 2 K
List<string> nombres = new List<string>();
while (true)
{
    Console.Write("Ingresa un nombre: ");
    string nombre = Console.ReadLine();
    if (nombres.Contains(nombre))
    {
        Console.WriteLine("Nombre repetido. Ingresaste " + nombres.Count + " nombres antes del duplicado.");
        break;
    }
    nombres.Add(nombre);
}

// 2 L
for (int i = 100; i <= 200; i++)
    if (i % 7 == 0 && i % 10 == 3)
        Console.WriteLine(i);

// 2 M
double total = 0;
int cantidad = 0;
while (total <= 1000)
{
    Console.Write("Ingresa el precio del producto: $");
    double precio = double.Parse(Console.ReadLine());
    total += precio;
    cantidad++;
}
Console.WriteLine("Se cargaron " + cantidad + " productos. Total: $" + total);

// 2 N
Console.Write("Nombre: ");
string nombre = Console.ReadLine();

int edad;
while (true)
{
    Console.Write("Edad: ");
    if (int.TryParse(Console.ReadLine(), out edad)) break;
    Console.WriteLine("La edad debe ser un número.");
}

string mail;
while (true)
{
    Console.Write("Mail: ");
    mail = Console.ReadLine();
    if (mail.Contains("@")) break;
    Console.WriteLine("El mail debe contener '@'.");
}

Console.WriteLine("Formulario completado: " + nombre + ", " + edad + ", " + mail);

// 2 O
Console.Write("Ingresa un número: ");
string num = Console.ReadLine();
Console.Write("Dígitos: ");
foreach (char c in num)
    if (char.IsDigit(c))
        Console.Write(c + " ");
Console.WriteLine();

// 2 P
Random rnd = new Random();
string[] opciones = { "piedra", "papel", "tijera" };
int victoriasJugador = 0, victoriasPC = 0;
for (int ronda = 1; ronda <= 3; ronda++)
{
    Console.Write("Ronda " + ronda + " - Elegí (piedra, papel, tijera): ");
    string jugador = Console.ReadLine().ToLower();
    string pc = opciones[rnd.Next(3)];
    Console.WriteLine("La PC eligió: " + pc);
    if (jugador == pc) Console.WriteLine("Empate.");
    else if ((jugador == "piedra" && pc == "tijera") ||
             (jugador == "papel" && pc == "piedra") ||
             (jugador == "tijera" && pc == "papel"))
    { Console.WriteLine("Ganaste la ronda."); victoriasJugador++; }
    else { Console.WriteLine("Ganó la PC."); victoriasPC++; }
}
Console.WriteLine("\nResultado final - Vos: " + victoriasJugador + " | PC: " + victoriasPC);
if (victoriasJugador > victoriasPC) Console.WriteLine("¡Ganaste!");
else if (victoriasPC > victoriasJugador) Console.WriteLine("Ganó la PC.");
else Console.WriteLine("Empate general.");

// 2 Q
Random rnd = new Random();
int mayoresDe50 = 0;
Console.Write("Números generados: ");
for (int i = 0; i < 10; i++)
{
    int n = rnd.Next(1, 101);
    Console.Write(n + " ");
    if (n > 50) mayoresDe50++;
}
Console.WriteLine("\nMayores a 50: " + mayoresDe50);

// 2 R
string mejorNombre = "";
double mejorNota = double.MinValue;
double sumaNotas = 0;
for (int i = 0; i < 5; i++)
{
    Console.Write("Nombre del alumno " + (i + 1) + ": ");
    string nombre = Console.ReadLine();
    Console.Write("Nota: ");
    double nota = double.Parse(Console.ReadLine());
    sumaNotas += nota;
    if (nota > mejorNota) { mejorNota = nota; mejorNombre = nombre; }
}
Console.WriteLine("Promedio general: " + (sumaNotas / 5));
Console.WriteLine("Mejor nota: " + mejorNombre + " con " + mejorNota);

// 2 S
for (char c = 'Z'; c >= 'A'; c--)
    Console.Write(c + " ");
Console.WriteLine();

// MENÚ BLOQUE 2
using System;
using System.Collections.Generic;

class Bloque2
{
    static Random rnd = new Random();

    static void Main()
    {
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n=== MENÚ BLOQUE 2 ===");
            Console.WriteLine("a. Adivinar número");
            Console.WriteLine("b. Divisores de un número");
            Console.WriteLine("c. Fibonacci");
            Console.WriteLine("d. Calculadora");
            Console.WriteLine("e. Factorial");
            Console.WriteLine("f. Sistema de turnos");
            Console.WriteLine("g. Pares entre 1 y 100");
            Console.WriteLine("h. Conversor Celsius a Fahrenheit");
            Console.WriteLine("i. Número primo");
            Console.WriteLine("j. Saludar lista de nombres");
            Console.WriteLine("k. Detectar nombre repetido");
            Console.WriteLine("l. Múltiplos de 7 que terminan en 3");
            Console.WriteLine("m. Productos hasta $1000");
            Console.WriteLine("n. Formulario con validación");
            Console.WriteLine("o. Dígitos por separado");
            Console.WriteLine("p. Piedra, papel o tijera");
            Console.WriteLine("q. Números aleatorios mayores a 50");
            Console.WriteLine("r. Promedio y mejor nota");
            Console.WriteLine("s. Abecedario inverso");
            Console.WriteLine("x. Salir");
            Console.Write("Elegí una opción: ");
            string op = Console.ReadLine().ToLower();

            switch (op)
            {
                case "a": Ej2a(); break;
                case "b": Ej2b(); break;
                case "c": Ej2c(); break;
                case "d": Ej2d(); break;
                case "e": Ej2e(); break;
                case "f": Ej2f(); break;
                case "g": Ej2g(); break;
                case "h": Ej2h(); break;
                case "i": Ej2i(); break;
                case "j": Ej2j(); break;
                case "k": Ej2k(); break;
                case "l": Ej2l(); break;
                case "m": Ej2m(); break;
                case "n": Ej2n(); break;
                case "o": Ej2o(); break;
                case "p": Ej2p(); break;
                case "q": Ej2q(); break;
                case "r": Ej2r(); break;
                case "s": Ej2s(); break;
                case "x": salir = true; break;
                default: Console.WriteLine("Opción inválida."); break;
            }
        }
    }

    static void Ej2a()
    {
        int secreto = rnd.Next(1, 11);
        while (true)
        {
            Console.Write("Adiviná el número (1-10): ");
            int intento = int.Parse(Console.ReadLine());
            if (intento == secreto) { Console.WriteLine("¡Adivinaste!"); break; }
            else if (intento < secreto) Console.WriteLine("Es mayor.");
            else Console.WriteLine("Es menor.");
        }
    }

    static void Ej2b()
    {
        Console.Write("Ingresa un número: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Divisores: ");
        for (int i = 1; i <= num; i++)
            if (num % i == 0) Console.Write(i + " ");
        Console.WriteLine();
    }

    static void Ej2c()
    {
        int a = 0, b = 1;
        Console.Write(a + " " + b);
        for (int i = 2; i < 20; i++)
        {
            int sig = a + b;
            Console.Write(" " + sig);
            a = b; b = sig;
        }
        Console.WriteLine();
    }

    static void Ej2d()
    {
        Console.Write("Operación (+, -, *, /): ");
        string op = Console.ReadLine();
        Console.Write("Primer número: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Segundo número: ");
        double n2 = double.Parse(Console.ReadLine());
        switch (op)
        {
            case "+": Console.WriteLine("Resultado: " + (n1 + n2)); break;
            case "-": Console.WriteLine("Resultado: " + (n1 - n2)); break;
            case "*": Console.WriteLine("Resultado: " + (n1 * n2)); break;
            case "/":
                if (n2 != 0) Console.WriteLine("Resultado: " + (n1 / n2));
                else Console.WriteLine("No se puede dividir por cero.");
                break;
            default: Console.WriteLine("Operación inválida."); break;
        }
    }

    static void Ej2e()
    {
        Console.Write("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());
        long factorial = 1;
        for (int i = 2; i <= n; i++) factorial *= i;
        Console.WriteLine("Factorial: " + factorial);
    }

    static void Ej2f()
    {
        List<string> nombres = new List<string>();
        while (true)
        {
            Console.Write("Ingresa un nombre (o 'fin'): ");
            string nombre = Console.ReadLine();
            if (nombre.ToLower() == "fin") break;
            nombres.Add(nombre);
        }
        for (int i = 0; i < nombres.Count; i++)
            Console.WriteLine("Turno " + (i + 1) + ": " + nombres[i]);
    }

    static void Ej2g()
    {
        int pares = 0;
        for (int i = 1; i <= 100; i++)
            if (i % 2 == 0) pares++;
        Console.WriteLine("Pares entre 1 y 100: " + pares);
    }

    static void Ej2h()
    {
        while (true)
        {
            Console.Write("Celsius (o 'salir'): ");
            string entrada = Console.ReadLine();
            if (entrada.ToLower() == "salir") break;
            double c = double.Parse(entrada);
            Console.WriteLine(c + "°C = " + (c * 9 / 5 + 32) + "°F");
        }
    }

    static void Ej2i()
    {
        Console.Write("Ingresa un número: ");
        int num = int.Parse(Console.ReadLine());
        bool primo = num > 1;
        for (int i = 2; i <= Math.Sqrt(num); i++)
            if (num % i == 0) { primo = false; break; }
        Console.WriteLine(num + (primo ? " es primo." : " no es primo."));
    }

    static void Ej2j()
    {
        List<string> nombres = new List<string>();
        while (true)
        {
            Console.Write("Nombre (o 'fin'): ");
            string nombre = Console.ReadLine();
            if (nombre.ToLower() == "fin") break;
            nombres.Add(nombre);
        }
        foreach (string n in nombres)
            Console.WriteLine("¡Hola, " + n + "!");
    }

    static void Ej2k()
    {
        List<string> nombres = new List<string>();
        while (true)
        {
            Console.Write("Ingresa un nombre: ");
            string nombre = Console.ReadLine();
            if (nombres.Contains(nombre))
            {
                Console.WriteLine("Repetido. Ingresaste " + nombres.Count + " nombres antes.");
                break;
            }
            nombres.Add(nombre);
        }
    }

    static void Ej2l()
    {
        for (int i = 100; i <= 200; i++)
            if (i % 7 == 0 && i % 10 == 3)
                Console.WriteLine(i);
    }

    static void Ej2m()
    {
        double total = 0;
        int cantidad = 0;
        while (total <= 1000)
        {
            Console.Write("Precio: $");
            double precio = double.Parse(Console.ReadLine());
            total += precio;
            cantidad++;
        }
        Console.WriteLine("Productos cargados: " + cantidad + ". Total: $" + total);
    }

    static void Ej2n()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        int edad;
        while (true)
        {
            Console.Write("Edad: ");
            if (int.TryParse(Console.ReadLine(), out edad)) break;
            Console.WriteLine("Debe ser un número.");
        }
        string mail;
        while (true)
        {
            Console.Write("Mail: ");
            mail = Console.ReadLine();
            if (mail.Contains("@")) break;
            Console.WriteLine("El mail debe tener '@'.");
        }
        Console.WriteLine("Datos: " + nombre + ", " + edad + ", " + mail);
    }

    static void Ej2o()
    {
        Console.Write("Ingresa un número: ");
        string num = Console.ReadLine();
        foreach (char c in num)
            if (char.IsDigit(c)) Console.Write(c + " ");
        Console.WriteLine();
    }

    static void Ej2p()
    {
        string[] opciones = { "piedra", "papel", "tijera" };
        int vJ = 0, vPC = 0;
        for (int r = 1; r <= 3; r++)
        {
            Console.Write("Ronda " + r + " (piedra, papel, tijera): ");
            string jugador = Console.ReadLine().ToLower();
            string pc = opciones[rnd.Next(3)];
            Console.WriteLine("PC eligió: " + pc);
            if (jugador == pc) Console.WriteLine("Empate.");
            else if ((jugador == "piedra" && pc == "tijera") ||
                     (jugador == "papel" && pc == "piedra") ||
                     (jugador == "tijera" && pc == "papel"))
            { Console.WriteLine("Ganaste."); vJ++; }
            else { Console.WriteLine("Ganó la PC."); vPC++; }
        }
        Console.WriteLine("Vos: " + vJ + " | PC: " + vPC);
        if (vJ > vPC) Console.WriteLine("¡Ganaste!");
        else if (vPC > vJ) Console.WriteLine("Ganó la PC.");
        else Console.WriteLine("Empate.");
    }

    static void Ej2q()
    {
        int mayores = 0;
        Console.Write("Números: ");
        for (int i = 0; i < 10; i++)
        {
            int n = rnd.Next(1, 101);
            Console.Write(n + " ");
            if (n > 50) mayores++;
        }
        Console.WriteLine("\nMayores a 50: " + mayores);
    }

    static void Ej2r()
    {
        string mejorNombre = "";
        double mejorNota = double.MinValue, suma = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nombre " + (i + 1) + ": ");
            string nombre = Console.ReadLine();
            Console.Write("Nota: ");
            double nota = double.Parse(Console.ReadLine());
            suma += nota;
            if (nota > mejorNota) { mejorNota = nota; mejorNombre = nombre; }
        }
        Console.WriteLine("Promedio: " + (suma / 5));
        Console.WriteLine("Mejor nota: " + mejorNombre + " - " + mejorNota);
    }

    static void Ej2s()
    {
        for (char c = 'Z'; c >= 'A'; c--)
            Console.Write(c + " ");
        Console.WriteLine();
    }
}