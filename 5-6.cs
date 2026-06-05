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
Console.WriteLine($"La palabra tiene {palabra.Length} letras.");

// 1 D

string contrasena = "secreta";
int intentos = 0;
while (intentos < 5)
{
    Console.Write("Adiviná la contraseña: ");
    string intento = Console.ReadLine();
    intentos++;
    if (intento == contrasena)
    {
        Console.WriteLine("¡Correcto!");
        break;
    }
    else
    {
        Console.WriteLine($"Incorrecto. Te quedan {5 - intentos} intentos.");
    }
}
if (intentos == 5)
    Console.WriteLine("Agotaste los intentos.");   

// 1 E

int maximo = int.MinValue;
for (int i = 0; i < 10; i++)
{
    Console.Write($"Ingresa el número {i + 1}: ");
    int num = int.Parse(Console.ReadLine());
    if (num > maximo)
        maximo = num;
}
Console.WriteLine($"El número más alto fue: {maximo}");

// 1 F

Console.Write("Ingresa tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombre.ToLower()));

// 1 G

for (int i = 1; i <= 10; i++)
    Console.WriteLine($"7 x {i} = {7 * i}");

// 1 H

for (int i = 10; i >= 1; i--)
    Console.WriteLine(i);
Console.WriteLine("¡Lanzamiento!");

// 1 I

Console.Write("Ingresa un número: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n % 2 == 0 ? "par" : "impar");

// 1 J

Console.Write("Ingresa una frase: ");
string frase = Console.ReadLine().ToLower();
int vocales = 0;
foreach (char c in frase)
    if ("aeiouáéíóú".Contains(c))
        vocales++;
Console.WriteLine($"La frase tiene {vocales} vocales.");

// 1 K

Console.Write("Ingresa un número: ");
int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= 12; i++)
    Console.WriteLine($"{num} x {i} = {num * i}");

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
Console.WriteLine($"Superaste 100 con {cantidad} números. Total: {total}");

// 1 M

Console.Write("Ingresa una palabra: ");
string palabra = Console.ReadLine();
foreach (char c in palabra)
    Console.WriteLine(c);

// 1 N

Console.Write("Ingresa tu edad: ");
int edad = int.Parse(Console.ReadLine());
bool votar = edad >= 18;
bool manejar = edad >= 17;
if (votar && manejar)
    Console.WriteLine("Podés votar y manejar.");
else if (votar)
    Console.WriteLine("Podés votar, pero no manejar.");
else if (manejar)
    Console.WriteLine("Podés manejar, pero no votar.");
else
    Console.WriteLine("No podés votar ni manejar.");

// 1 O

for (int i = 50; i >= 0; i -= 5)
    Console.WriteLine(i);

// 1 P

string clave = "";
while (true)
{
    Console.Write("Ingresa una contraseña: ");
    string c1 = Console.ReadLine();
    Console.Write("Repetila: ");
    string c2 = Console.ReadLine();
    if (c1 == c2)
    {
        Console.WriteLine("Acceso permitido.");
        break;
    }
    else
    {
        Console.WriteLine("No coinciden. Intenta de nuevo.");
    }
}

// 1 Q

while (true)
{
    Console.Write("Ingresa un nombre: ");
    string nombre = Console.ReadLine();
    if (nombre.Length > 10)
    {
        Console.WriteLine("Nombre demasiado largo. Programa terminado.");
        break;
    }
}

// 1 R
Console.Write("Ingresa una oración: ");
string oracion = Console.ReadLine().ToLower();
int contA = 0;
foreach (char c in oracion)
    if (c == 'a')
        contA++;
Console.WriteLine($"La oración tiene {contA} letras 'a'.");



// MENÚ BLOQUE 1

static void Bloque1a()
{
    for (int i = 1; i <= 100; i++)
        if (i % 3 == 0)
            Console.WriteLine(i);
}

static void Bloque1b()
{
    Console.Write("Ingresa tu edad: ");
    int edad = int.Parse(Console.ReadLine());
    if (edad < 18) Console.WriteLine("Sos menor de edad.");
    else if (edad == 18) Console.WriteLine("Tenés justo 18.");
    else Console.WriteLine("Sos mayor de edad.");
}

static void Bloque1c()
{
    Console.Write("Ingresa una palabra: ");
    string palabra = Console.ReadLine();
    Console.WriteLine($"La palabra tiene {palabra.Length} letras.");
}

static void Bloque1d()
{
    string contrasena = "secreta";
    int intentos = 0;
    while (intentos < 5)
    {
        Console.Write("Adiviná la contraseña: ");
        string intento = Console.ReadLine();
        intentos++;
        if (intento == contrasena) { Console.WriteLine("¡Correcto!"); break; }
        else Console.WriteLine($"Incorrecto. Te quedan {5 - intentos} intentos.");
    }
    if (intentos == 5) Console.WriteLine("Agotaste los intentos.");
}

static void Bloque1e()
{
    int maximo = int.MinValue;
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Número {i + 1}: ");
        int n = int.Parse(Console.ReadLine());
        if (n > maximo) maximo = n;
    }
    Console.WriteLine($"El más alto fue: {maximo}");
}

static void Bloque1f()
{
    Console.Write("Ingresa tu nombre: ");
    string nombre = Console.ReadLine();
    Console.WriteLine(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombre.ToLower()));
}

static void Bloque1g()
{
    for (int i = 1; i <= 10; i++)
        Console.WriteLine($"7 x {i} = {7 * i}");
}

static void Bloque1h()
{
    for (int i = 10; i >= 1; i--)
        Console.WriteLine(i);
    Console.WriteLine("¡Lanzamiento!");
}

static void Bloque1i()
{
    Console.Write("Ingresa un número: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(n % 2 == 0 ? "par" : "impar");
}

static void Bloque1j()
{
    Console.Write("Ingresa una frase: ");
    string frase = Console.ReadLine().ToLower();
    int vocales = 0;
    foreach (char c in frase)
        if ("aeiouáéíóú".Contains(c)) vocales++;
    Console.WriteLine($"Vocales: {vocales}");
}

static void Bloque1k()
{
    Console.Write("Ingresa un número: ");
    int num = int.Parse(Console.ReadLine());
    for (int i = 1; i <= 12; i++)
        Console.WriteLine($"{num} x {i} = {num * i}");
}

static void Bloque1l()
{
    int total = 0, cantidad = 0;
    while (total <= 100)
    {
        Console.Write("Ingresa un número: ");
        total += int.Parse(Console.ReadLine());
        cantidad++;
    }
    Console.WriteLine($"Superaste 100 con {cantidad} números. Total: {total}");
}

static void Bloque1m()
{
    Console.Write("Ingresa una palabra: ");
    foreach (char c in Console.ReadLine())
        Console.WriteLine(c);
}

static void Bloque1n()
{
    Console.Write("Ingresa tu edad: ");
    int edad = int.Parse(Console.ReadLine());
    bool votar = edad >= 18, manejar = edad >= 17;
    if (votar && manejar) Console.WriteLine("Podés votar y manejar.");
    else if (votar) Console.WriteLine("Podés votar, pero no manejar.");
    else if (manejar) Console.WriteLine("Podés manejar, pero no votar.");
    else Console.WriteLine("No podés votar ni manejar.");
}

static void Bloque1o()
{
    for (int i = 50; i >= 0; i -= 5)
        Console.WriteLine(i);
}

static void Bloque1p()
{
    while (true)
    {
        Console.Write("Ingresa una contraseña: ");
        string c1 = Console.ReadLine();
        Console.Write("Repetila: ");
        string c2 = Console.ReadLine();
        if (c1 == c2) { Console.WriteLine("Acceso permitido."); break; }
        else Console.WriteLine("No coinciden. Intenta de nuevo.");
    }
}

static void Bloque1q()
{
    while (true)
    {
        Console.Write("Ingresa un nombre: ");
        string nombre = Console.ReadLine();
        if (nombre.Length > 10) { Console.WriteLine("Nombre demasiado largo. Fin."); break; }
    }
}

static void Bloque1r()
{
    Console.Write("Ingresa una oración: ");
    string oracion = Console.ReadLine().ToLower();
    int contA = 0;
    foreach (char c in oracion)
        if (c == 'a') contA++;
    Console.WriteLine($"Letras 'a': {contA}");
}

static void MenuBloque1()
{
    while (true)
    {
        Console.WriteLine("\n--- BLOQUE 1 ---");
        Console.WriteLine("a) Múltiplos de 3\nb) Mayoría de edad\nc) Longitud de palabra\nd) Adivinar contraseña");
        Console.WriteLine("e) Número más alto\nf) Saludo con mayúsculas\ng) Tabla del 7\nh) Cuenta regresiva");
        Console.WriteLine("i) Par o impar\nj) Contar vocales\nk) Tabla de multiplicar\nl) Acumulador hasta 100");
        Console.WriteLine("m) Letras por línea\nn) Votar/manejar\no) Descendente de 5 en 5\np) Confirmar contraseña");
        Console.WriteLine("q) Nombres cortos\nr) Contar letra a\n0) Volver");
        Console.Write("Opción: ");
        string op = Console.ReadLine();
        switch (op)
        {
            case "a": Bloque1a(); break;
            case "b": Bloque1b(); break;
            case "c": Bloque1c(); break;
            case "d": Bloque1d(); break;
            case "e": Bloque1e(); break;
            case "f": Bloque1f(); break;
            case "g": Bloque1g(); break;
            case "h": Bloque1h(); break;
            case "i": Bloque1i(); break;
            case "j": Bloque1j(); break;
            case "k": Bloque1k(); break;
            case "l": Bloque1l(); break;
            case "m": Bloque1m(); break;
            case "n": Bloque1n(); break;
            case "o": Bloque1o(); break;
            case "p": Bloque1p(); break;
            case "q": Bloque1q(); break;
            case "r": Bloque1r(); break;
            case "0": return;
            default: Console.WriteLine("Opción inválida."); break;
        }
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
    else if (intento < secreto) Console.WriteLine("El número es mayor.");
    else Console.WriteLine("El número es menor.");
}

// 2 B

Console.Write("Ingresa un número: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Divisores: ");
for (int i = 1; i <= n; i++)
    if (n % i == 0) Console.Write(i + " ");
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

Console.WriteLine("Operaciones: 1) Suma  2) Resta  3) Multiplicación  4) División");
Console.Write("Elegí una operación: ");
int op = int.Parse(Console.ReadLine());
Console.Write("Número 1: ");
double n1 = double.Parse(Console.ReadLine());
Console.Write("Número 2: ");
double n2 = double.Parse(Console.ReadLine());
switch (op)
{
    case 1: Console.WriteLine($"Resultado: {n1 + n2}"); break;
    case 2: Console.WriteLine($"Resultado: {n1 - n2}"); break;
    case 3: Console.WriteLine($"Resultado: {n1 * n2}"); break;
    case 4:
        if (n2 != 0) Console.WriteLine($"Resultado: {n1 / n2}");
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
Console.WriteLine($"Factorial de {n}: {factorial}");

// 2 F

List<string> turnos = new List<string>();
while (true)
{
    Console.Write("Ingresa un nombre (o 'fin' para terminar): ");
    string nombre = Console.ReadLine();
    if (nombre.ToLower() == "fin") break;
    turnos.Add(nombre);
}
for (int i = 0; i < turnos.Count; i++)
    Console.WriteLine($"Turno {i + 1}: {turnos[i]}");

// 2 G

int pares = 0;
for (int i = 1; i <= 100; i++)
    if (i % 2 == 0) pares++;
Console.WriteLine($"Números pares entre 1 y 100: {pares}");

// 2 H

while (true)
{
    Console.Write("Ingresa temperatura en Celsius (o 'salir'): ");
    string entrada = Console.ReadLine();
    if (entrada.ToLower() == "salir") break;
    double celsius = double.Parse(entrada);
    double fahrenheit = celsius * 9 / 5 + 32;
    Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
}

// 2 I

Console.Write("Ingresa un número: ");
int n = int.Parse(Console.ReadLine());
bool esPrimo = n > 1;
for (int i = 2; i <= Math.Sqrt(n); i++)
    if (n % i == 0) { esPrimo = false; break; }
Console.WriteLine(esPrimo ? $"{n} es primo." : $"{n} no es primo.");

// 2 J

List<string> nombres = new List<string>();
while (true)
{
    Console.Write("Ingresa un nombre (o 'fin'): ");
    string nombre = Console.ReadLine();
    if (nombre.ToLower() == "fin") break;
    nombres.Add(nombre);
}
foreach (string nombre in nombres)
    Console.WriteLine($"¡Hola, {nombre}!");

// 2 K

List<string> ingresados = new List<string>();
while (true)
{
    Console.Write("Ingresa un nombre: ");
    string nombre = Console.ReadLine();
    if (ingresados.Contains(nombre))
    {
        Console.WriteLine($"'{nombre}' ya fue ingresado. Ingresaste {ingresados.Count} nombres antes del duplicado.");
        break;
    }
    ingresados.Add(nombre);
}

// 2 L

for (int i = 100; i <= 200; i++)
    if (i % 7 == 0 && i % 10 == 3)
        Console.WriteLine(i);

// 2 M

int total = 0, cantidad = 0;
while (total <= 1000)
{
    Console.Write("Ingresa un precio: ");
    double precio = double.Parse(Console.ReadLine());
    total += (int)precio;
    cantidad++;
}
Console.WriteLine($"Se cargaron {cantidad} productos. Total: ${total}");

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

Console.WriteLine($"Formulario completado: {nombre}, {edad}, {mail}");

// 2 O

Console.Write("Ingresa un número: ");
string numero = Console.ReadLine();
Console.Write("Dígitos: ");
foreach (char c in numero)
    if (char.IsDigit(c)) Console.Write(c + " ");
Console.WriteLine();

// 2 P

Random rnd = new Random();
string[] opciones = { "piedra", "papel", "tijera" };
int victoriasJugador = 0, victoriasPC = 0;
for (int ronda = 1; ronda <= 3; ronda++)
{
    Console.Write($"Ronda {ronda} - Elegí (piedra/papel/tijera): ");
    string jugador = Console.ReadLine().ToLower();
    string pc = opciones[rnd.Next(3)];
    Console.WriteLine($"La PC eligió: {pc}");
    if (jugador == pc) Console.WriteLine("Empate.");
    else if ((jugador == "piedra" && pc == "tijera") ||
             (jugador == "papel" && pc == "piedra") ||
             (jugador == "tijera" && pc == "papel"))
    { Console.WriteLine("¡Ganaste!"); victoriasJugador++; }
    else { Console.WriteLine("Ganó la PC."); victoriasPC++; }
}
Console.WriteLine($"\nResultado final - Vos: {victoriasJugador} | PC: {victoriasPC}");
if (victoriasJugador > victoriasPC) Console.WriteLine("¡Ganaste la partida!");
else if (victoriasPC > victoriasJugador) Console.WriteLine("Ganó la PC la partida.");
else Console.WriteLine("Partida empatada.");

// 2 Q

Random rnd = new Random();
int mayores = 0;
for (int i = 0; i < 10; i++)
{
    int n = rnd.Next(1, 101);
    Console.Write(n + " ");
    if (n > 50) mayores++;
}
Console.WriteLine($"\nNúmeros mayores a 50: {mayores}");

// 2 R

string mejorNombre = "";
double mejorNota = double.MinValue;
double sumaNotas = 0;
for (int i = 0; i < 5; i++)
{
    Console.Write($"Nombre {i + 1}: ");
    string nombre = Console.ReadLine();
    Console.Write($"Nota de {nombre}: ");
    double nota = double.Parse(Console.ReadLine());
    sumaNotas += nota;
    if (nota > mejorNota) { mejorNota = nota; mejorNombre = nombre; }
}
Console.WriteLine($"Promedio general: {sumaNotas / 5:F2}");
Console.WriteLine($"Mejor nota: {mejorNombre} con {mejorNota}");

// 2 S

for (char c = 'Z'; c >= 'A'; c--)
    Console.Write(c + " ");
Console.WriteLine();



// MENÚ BLOQUE 2

static void Bloque2a()
{
    Random rnd = new Random();
    int secreto = rnd.Next(1, 11);
    while (true)
    {
        Console.Write("Adiviná el número (1-10): ");
        int intento = int.Parse(Console.ReadLine());
        if (intento == secreto) { Console.WriteLine("¡Adivinaste!"); break; }
        else if (intento < secreto) Console.WriteLine("El número es mayor.");
        else Console.WriteLine("El número es menor.");
    }
}

static void Bloque2b()
{
    Console.Write("Ingresa un número: ");
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++)
        if (n % i == 0) Console.Write(i + " ");
    Console.WriteLine();
}

static void Bloque2c()
{
    int a = 0, b = 1;
    Console.Write(a + " " + b);
    for (int i = 2; i < 20; i++)
    {
        int sig = a + b; Console.Write(" " + sig); a = b; b = sig;
    }
    Console.WriteLine();
}

static void Bloque2d()
{
    Console.WriteLine("1) Suma  2) Resta  3) Multiplicación  4) División");
    Console.Write("Operación: ");
    int op = int.Parse(Console.ReadLine());
    Console.Write("Número 1: ");
    double n1 = double.Parse(Console.ReadLine());
    Console.Write("Número 2: ");
    double n2 = double.Parse(Console.ReadLine());
    switch (op)
    {
        case 1: Console.WriteLine(n1 + n2); break;
        case 2: Console.WriteLine(n1 - n2); break;
        case 3: Console.WriteLine(n1 * n2); break;
        case 4: Console.WriteLine(n2 != 0 ? $"{n1 / n2}" : "División por cero."); break;
        default: Console.WriteLine("Inválido."); break;
    }
}

static void Bloque2e()
{
    Console.Write("Ingresa un número: ");
    int n = int.Parse(Console.ReadLine());
    long f = 1;
    for (int i = 2; i <= n; i++) f *= i;
    Console.WriteLine($"Factorial: {f}");
}

static void Bloque2f()
{
    var turnos = new List<string>();
    while (true)
    {
        Console.Write("Nombre (o 'fin'): ");
        string nombre = Console.ReadLine();
        if (nombre.ToLower() == "fin") break;
        turnos.Add(nombre);
    }
    for (int i = 0; i < turnos.Count; i++)
        Console.WriteLine($"Turno {i + 1}: {turnos[i]}");
}

static void Bloque2g()
{
    int pares = 0;
    for (int i = 1; i <= 100; i++)
        if (i % 2 == 0) pares++;
    Console.WriteLine($"Pares: {pares}");
}

static void Bloque2h()
{
    while (true)
    {
        Console.Write("Celsius (o 'salir'): ");
        string e = Console.ReadLine();
        if (e.ToLower() == "salir") break;
        double c = double.Parse(e);
        Console.WriteLine($"{c}°C = {c * 9 / 5 + 32}°F");
    }
}

static void Bloque2i()
{
    Console.Write("Ingresa un número: ");
    int n = int.Parse(Console.ReadLine());
    bool primo = n > 1;
    for (int i = 2; i <= Math.Sqrt(n); i++)
        if (n % i == 0) { primo = false; break; }
    Console.WriteLine(primo ? $"{n} es primo." : $"{n} no es primo.");
}

static void Bloque2j()
{
    var nombres = new List<string>();
    while (true)
    {
        Console.Write("Nombre (o 'fin'): ");
        string nombre = Console.ReadLine();
        if (nombre.ToLower() == "fin") break;
        nombres.Add(nombre);
    }
    foreach (string nombre in nombres)
        Console.WriteLine($"¡Hola, {nombre}!");
}

static void Bloque2k()
{
    var ingresados = new List<string>();
    while (true)
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        if (ingresados.Contains(nombre))
        {
            Console.WriteLine($"Duplicado. Ingresaste {ingresados.Count} nombres antes.");
            break;
        }
        ingresados.Add(nombre);
    }
}

static void Bloque2l()
{
    for (int i = 100; i <= 200; i++)
        if (i % 7 == 0 && i % 10 == 3)
            Console.WriteLine(i);
}

static void Bloque2m()
{
    int total = 0, cantidad = 0;
    while (total <= 1000)
    {
        Console.Write("Precio: ");
        total += (int)double.Parse(Console.ReadLine());
        cantidad++;
    }
    Console.WriteLine($"Productos: {cantidad} | Total: ${total}");
}

static void Bloque2n()
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
        Console.WriteLine("Debe contener '@'.");
    }
    Console.WriteLine($"Registrado: {nombre}, {edad}, {mail}");
}

static void Bloque2o()
{
    Console.Write("Número: ");
    foreach (char c in Console.ReadLine())
        if (char.IsDigit(c)) Console.Write(c + " ");
    Console.WriteLine();
}

static void Bloque2p()
{
    Random rnd = new Random();
    string[] opciones = { "piedra", "papel", "tijera" };
    int vJ = 0, vPC = 0;
    for (int r = 1; r <= 3; r++)
    {
        Console.Write($"Ronda {r} (piedra/papel/tijera): ");
        string j = Console.ReadLine().ToLower();
        string pc = opciones[rnd.Next(3)];
        Console.WriteLine($"PC eligió: {pc}");
        if (j == pc) Console.WriteLine("Empate.");
        else if ((j == "piedra" && pc == "tijera") || (j == "papel" && pc == "piedra") || (j == "tijera" && pc == "papel"))
        { Console.WriteLine("¡Ganaste!"); vJ++; }
        else { Console.WriteLine("Ganó la PC."); vPC++; }
    }
    Console.WriteLine($"Vos: {vJ} | PC: {vPC}");
    if (vJ > vPC) Console.WriteLine("¡Ganaste la partida!");
    else if (vPC > vJ) Console.WriteLine("Ganó la PC.");
    else Console.WriteLine("Empate.");
}

static void Bloque2q()
{
    Random rnd = new Random();
    int mayores = 0;
    for (int i = 0; i < 10; i++)
    {
        int n = rnd.Next(1, 101);
        Console.Write(n + " ");
        if (n > 50) mayores++;
    }
    Console.WriteLine($"\nMayores a 50: {mayores}");
}

static void Bloque2r()
{
    string mejor = ""; double mejorNota = double.MinValue, suma = 0;
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"Nombre {i + 1}: ");
        string nombre = Console.ReadLine();
        Console.Write("Nota: ");
        double nota = double.Parse(Console.ReadLine());
        suma += nota;
        if (nota > mejorNota) { mejorNota = nota; mejor = nombre; }
    }
    Console.WriteLine($"Promedio: {suma / 5:F2} | Mejor: {mejor} ({mejorNota})");
}

static void Bloque2s()
{
    for (char c = 'Z'; c >= 'A'; c--)
        Console.Write(c + " ");
    Console.WriteLine();
}

static void MenuBloque2()
{
    while (true)
    {
        Console.WriteLine("\n--- BLOQUE 2 ---");
        Console.WriteLine("a) Adivinar número\nb) Divisores\nc) Fibonacci\nd) Calculadora");
        Console.WriteLine("e) Factorial\nf) Sistema de turnos\ng) Pares 1-100\nh) Celsius a Fahrenheit");
        Console.WriteLine("i) Número primo\nj) Lista de saludos\nk) Detectar duplicado\nl) Múltiplos de 7 terminan en 3");
        Console.WriteLine("m) Precios hasta $1000\nn) Formulario validado\no) Dígitos separados\np) Piedra papel tijera");
        Console.WriteLine("q) Números aleatorios\nr) Promedio y mejor nota\ns) Abecedario inverso\n0) Volver");
        Console.Write("Opción: ");
        string op = Console.ReadLine();
        switch (op)
        {
            case "a": Bloque2a(); break;
            case "b": Bloque2b(); break;
            case "c": Bloque2c(); break;
            case "d": Bloque2d(); break;
            case "e": Bloque2e(); break;
            case "f": Bloque2f(); break;
            case "g": Bloque2g(); break;
            case "h": Bloque2h(); break;
            case "i": Bloque2i(); break;
            case "j": Bloque2j(); break;
            case "k": Bloque2k(); break;
            case "l": Bloque2l(); break;
            case "m": Bloque2m(); break;
            case "n": Bloque2n(); break;
            case "o": Bloque2o(); break;
            case "p": Bloque2p(); break;
            case "q": Bloque2q(); break;
            case "r": Bloque2r(); break;
            case "s": Bloque2s(); break;
            case "0": return;
            default: Console.WriteLine("Opción inválida."); break;
        }
    }
}



// MENÚ

while (true)
{
    Console.WriteLine(" MENÚ PRINCIPAL: ");
    Console.WriteLine("1) Bloque 1");
    Console.WriteLine("2) Bloque 2");
    Console.WriteLine("0) Salir");
    Console.Write("Opción: ");
    string op = Console.ReadLine();
    switch (op)
    {
        case "1": MenuBloque1(); break;
        case "2": MenuBloque2(); break;
        case "0": return;
        default: Console.WriteLine("Opción inválida."); break;
    }
}
