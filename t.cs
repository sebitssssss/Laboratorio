
namespace t
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            do
            {
                Console.WriteLine("==============");
                Console.WriteLine("   | Menu |   ");
                Console.WriteLine("==============");
                Console.WriteLine("1 - Calcular Perimetro");
                Console.WriteLine("2 - Calcular Porcentaje");
                Console.WriteLine("3 - Calcular Presion Objeto");
                Console.WriteLine("4 - Calcular resistencias serie");
                Console.WriteLine("5 - 8va parte numero");
                Console.WriteLine("6 - Descubrir mayor 2 numeros");
                Console.WriteLine("7 - Calcular Promocion");
                Console.WriteLine("8 - Empleados categoria");
                Console.WriteLine("9 - Empleados hijos");
                Console.WriteLine("10 - IMC");
                Console.WriteLine("11 - Paises");
                Console.WriteLine("12 - Numeros");
                Console.WriteLine("13 - Tiempo");
                Console.WriteLine("14 - Ascendente");
                Console.WriteLine("15 - 0 al 9");
                Console.WriteLine("16 - 15 números");
                Console.WriteLine("17 - Intermedio");
                Console.WriteLine("18 - Factorial");
                Console.WriteLine("19 - Potencia por multiplicaciones sucesivas");
                Console.WriteLine("20 - Promedio alumnos por materia");
                Console.WriteLine("21 - Ventas por vendedor");
                Console.WriteLine("22 - Negativos, positivos y ceros");
                Console.WriteLine("23 - Sueldos mayores/menores a $2000");
                Console.WriteLine("24 - Alumnos con nota mayor a 8");
                Console.WriteLine("25 - Validar fecha");
                Console.WriteLine("26 - Producto mas vendido y mayor importe");
                Console.WriteLine("27 - Promedios alumnos con TP");
                Console.WriteLine("28 - Estadisticas de personas por DNI");
                Console.WriteLine("29 - Factorial validado");

                opcion = Convert.ToInt16(Console.ReadLine());


                if (opcion == 1)
                {
                    Ej1();
                }

                if (opcion == 2)
                {
                    Ej2();
                }

                if (opcion == 3)
                {
                    Ej3();
                }

                if (opcion == 4)
                {
                    Ej4();
                }

                if (opcion == 5)
                {
                    Ej5();
                }

                if (opcion == 6)
                {
                    Ej6();
                }

                if (opcion == 7)
                {
                    Ej7();
                }

                if (opcion == 8)
                {
                    Ej8();
                }

                if (opcion == 9)
                {
                    Ej9();
                }

                if (opcion == 10)
                {
                    Ej10();
                }

                if (opcion == 11)
                {
                    Ej11();
                }

                if (opcion == 12)
                {
                    Ej12();
                }

                if (opcion == 13)
                {
                    Ej13();
                }

                if (opcion == 14)
                {
                    Ej14();
                }

                if (opcion == 15)
                {
                    Ej15();
                }

                if (opcion == 16)
                {
                    Ej16();
                }

                if (opcion == 17)
                {
                    Ej17();
                }

                if (opcion == 18)
                {
                    Ej18();
                }

                if (opcion == 19)
                {
                    Ej19();
                }

                if (opcion == 20)
                {
                    Ej20();
                }

                if (opcion == 21)
                {
                    Ej21();
                }

                if (opcion == 22)
                {
                    Ej22();
                }

                if (opcion == 23)
                {
                    Ej23();
                }

                if (opcion == 24)
                {
                    Ej24();
                }

                if (opcion == 25)
                {
                    Ej25();
                }

                if (opcion == 26)
                {
                    Ej26();
                }

                if (opcion == 27)
                {
                    Ej27();
                }

                if (opcion == 28)
                {
                    Ej28();
                }

                if (opcion == 29)
                {
                    Ej29();
                }
            }
            while (opcion != 0 && opcion < 47);




        }

        static void Ej1()
        {
            Console.Clear();

            double numA;
            double numB;
            char op;

            Console.WriteLine("Elija");
            Console.WriteLine("A | Area");
            Console.WriteLine("B | Perimetro");
            op = Convert.ToChar(Console.ReadLine());

            if (op == 'A' || op == 'a')
            {
                Console.WriteLine("Ingresa el valor de el primer lado");
                numA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ahora ingrese el valor de segundo lado");
                numB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("================");
                Console.WriteLine($"El resultado es {numA * numB}");
                Console.WriteLine("================");

            }
            if (op == 'B' || op == 'b')
            {
                Console.WriteLine("Ingresa el valor del primer lado");
                numA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el valor del segundo lado");
                numB = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("================");
                Console.WriteLine($"El resultado es {2 * numA + 2 * numB}");
                Console.WriteLine("================");


            }
            else
            { Console.WriteLine("Ingrese UNA OPCION VALIDA"); }
        }

        static void Ej2()
        {

            Console.Clear();

            int mujeres;
            int hombres;
            float total;

            Console.WriteLine("Ingrese la cantidad de hombres");
            hombres = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Ingrese la cantidad de mujeres");
            mujeres = Convert.ToInt16(Console.ReadLine());

            total = mujeres + hombres;
            float porcentajeM = (mujeres * 100) / total;
            float porcentajeH = (hombres * 100) / total;

            Console.WriteLine($"Hubieron {total} cantidad de aplicados y fueron {porcentajeH}% hombres y {porcentajeM}% mujeres");

        }

        static void Ej3()
        {
            Console.Clear();
            double fuerza;
            double area;

            Console.WriteLine("Ingrese la supeficie del objeto:");
            area = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la fuerza en la equacion:");
            fuerza = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"La presion de el objeto es de {fuerza / area}");
        }

        static void Ej4()
        {
            Console.Clear();
            double res;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingresa el valor de la resistencia numero {i}");
                res = +Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"El valor de las resistencias en serie es de {res} ohms");

            }

        }

        static void Ej5()
        {
            Console.Clear();
            int num;
            Console.WriteLine("Ingrese un valor entero");
            num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"La octava parte de {num} es {num / 8}");
        }

        static void Ej6()
        {
            Console.Clear();
            double num1;
            double num2;

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"El primer numero ({num1}) es mas alto que el segundo ({num2})");
            }
            else if (num2 > num1)
            {

                Console.WriteLine($"El segundo numero ({num2}) es mas alto que el primero ({num1})");
            }
            else if (num2 == num1)
            {

                Console.WriteLine($"Los dos numeros son iguales");
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido");
            }
        }

        static void Ej7()
        {
            Console.Clear();

            int opcion;
            double impuesto;
            int horas;

            Console.WriteLine("Ingrese su cantidad de horas");
            horas = Convert.ToInt16(Console.ReadLine());

            if (horas >= 20)
            {
                Console.WriteLine("Ingrese su categoria");
                Console.WriteLine("[1] +70 Años");
                Console.WriteLine("[2] +60 Años");
                Console.WriteLine("[3] +50 Años");
                opcion = Convert.ToInt16(Console.ReadLine());

                double bruto = horas * 50;

                impuesto = (bruto * 33) / 100;

                if (opcion == 1)
                {
                    Console.WriteLine("================");
                    Console.WriteLine($"El precio sin impuestos/descuentos seria {bruto}");
                    Console.WriteLine($"El precio final seria {(bruto + impuesto) - ((bruto * 50) / 100)}");
                    Console.WriteLine("================");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("================");
                    Console.WriteLine($"El precio sin impuestos/descuentos seria {bruto}");
                    Console.WriteLine($"El precio final seria {(bruto + impuesto) - ((bruto * 30) / 100)}");
                    Console.WriteLine("================");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("================");
                    Console.WriteLine($"El precio sin impuestos/descuentos seria {bruto}");
                    Console.WriteLine($"El precio final seria {(bruto + impuesto) - ((bruto * 20) / 100)}");
                    Console.WriteLine("================");
                }
            }
            else
            {
                Console.WriteLine("El descuento es para minimo 20hs");
            }


        }

        static void Ej8()
        {
            Console.Clear();
            int categoria;
            double horas;

            Console.WriteLine("Ingrese su categoria de empleado:");
            Console.WriteLine("[1] A");
            Console.WriteLine("[2] B");
            Console.WriteLine("[3] C");

            categoria = Convert.ToInt16(Console.ReadLine());

            if (categoria == 1)
            {
                Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
                horas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("================");
                Console.WriteLine($"El sueldo final seria {horas * 200}");
            }
            else if (categoria == 2)
            {
                Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
                horas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("================");
                Console.WriteLine($"El sueldo final seria {horas * 180}");
            }
            else if (categoria == 3)
            {
                Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
                horas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("================");
                Console.WriteLine($"El sueldo final seria {horas * 150}");
            }
            else
            {
                Console.WriteLine("NO PERTENECE A NINGUNA CATEGORIA, VALOR DE LAS HORAS $0");
            }

        }

        static void Ej9()
        {
            Console.Clear();
            int categoria;
            int hijos;
            double bruto;
            double final;

            Console.WriteLine("Ingrese su sueldo en bruto");
            bruto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su cantidad de hijos");
            hijos = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese su categoria");
            Console.WriteLine("[1] A");
            Console.WriteLine("[2] B");
            Console.WriteLine("[3] C");
            categoria = Convert.ToInt16(Console.ReadLine());

            if (categoria == 1)
            {
                final = bruto + ((bruto * 10) / 100);

                if (hijos > 4)
                {
                    final += 1100;
                }
                else if (hijos < 4 && hijos > 0)
                {
                    final += (hijos * 300);
                }

                Console.WriteLine($"El sueldo final seria {final}");



            }
            else if (categoria == 2)
            {
                final = bruto + ((bruto * 20) / 100);

                if (hijos > 4)
                {
                    final += 1100;
                }
                else if (hijos < 4 && hijos > 0)
                {
                    final += (hijos * 300);
                }

                Console.WriteLine($"El sueldo final seria {final}");

            }
            else if (categoria == 3)
            {

                final = bruto;

                if (hijos > 4)
                {
                    final += 1100;
                }
                else if (hijos < 4 && hijos > 0)
                {
                    final += (hijos * 300);
                }

                Console.WriteLine($"El sueldo final seria {final}");
            }
        }

        static void Ej10()
        {
            double peso;
            double altura;

            Console.WriteLine("Ingrese su altura en Metros");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese su peso en KG");
            peso = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);
            if (imc < 20)
            { Console.WriteLine($"Su imc es de {imc} Eso significa que tiene bajo peso"); }
            else if (imc > 20 && imc < 25)
            { Console.WriteLine($"Su imc es de {imc} Eso significa que tiene un peso ideal"); }
            else if (imc > 25)
            { Console.WriteLine($"Su imc es de {imc} Eso significa que tiene sobre peso"); }

        }

        static void Ej11()
        {
            string[] nombre = new string[3];
            int[] poblacion = new int[3];
            float[] superficie = new float[3];
            int i = 0;
            float resultado = 0;
            string nombrer = "";

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el nombre de un país: ");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la superficie del país: ");
                superficie[i] = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Ingrese la poblacion del país: ");
                poblacion[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (i = 0; i < 3; i++)
            {
                if (resultado < poblacion[i] / superficie[i])
                {
                    resultado = poblacion[i] / superficie[i];
                    nombrer = nombre[i];
                }
            }
            Console.WriteLine($"El país más denso poblacionalmente es: {nombrer}, y su densidad es {resultado}");
        }
        static void Ej12()
        {
            int[] numeros = new int[3];
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese el número {i}: ");
                numeros[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (i = 0; i < 3; i++)
            {
                if (numeros[i] != numeros[i + 1])
                {
                    if (numeros[i] != numeros[1 + 2])
                    {
                        if (numeros[i + 1] != numeros[i + 2])
                        {
                            Console.WriteLine("Todos los números son distintos");
                        }
                        else
                        {
                            Console.WriteLine($"El número {i + 1} y {i + 2} son iguales, el número {i} es diferente");
                        }
                    }
                    Console.WriteLine($"El número {i} y {i + 2} son iguales, el número {i + 1} es diferente");
                }
                else if (numeros[i] != numeros[i + 2])
                {
                    Console.WriteLine($"El número {i} y {i + 1} son iguales, el número {i + 2} es diferente");
                }
                else
                {
                    Console.WriteLine("Todos los números son iguales");
                }
            }
        }
        static void Ej13()
        {
            int horas;
            int minutos;
            int segundos;
            int uf = 0;
            int resultado = 0;

            Console.WriteLine("Ingrese el número de horas: ");
            horas = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese el número de minutos: ");
            minutos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese el número de segundos: ");
            segundos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la unidad final: ");
            uf = Convert.ToInt16(Console.ReadLine());

            if (uf == 1)
            {
                resultado += horas * 3600;
                resultado += minutos * 60;
                resultado += segundos;
                Console.WriteLine($"Tiempo final: {resultado} segundos");
            }
            if (uf == 2)
            {
                resultado += horas * 60;
                resultado += minutos;
                resultado += segundos / 60;
                Console.WriteLine($"Tiempo final: {resultado} minutos");
            }
            else if (uf == 3)
            {
                resultado += horas;
                resultado += minutos / 60;
                resultado += segundos / 3600;
                Console.WriteLine($"Tiempo final: {resultado} horas");
            }
        }
        static void Ej14()
        {
            int[] numeros = new int[3];
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}: ");
                numeros[i] = Convert.ToInt16(Console.ReadLine());
            }

            if (numeros[i] < numeros[i + 1])
            {
                if (numeros[i + 1] < numeros[i + 2])
                {
                    Console.WriteLine("Los números están ordenados de forma ascendente");
                }
                else
                {
                    Console.WriteLine("Los números no están ordenados de forma ascendente");
                }
            }
            else
            {
                Console.WriteLine("Los números no están ordenados de forma ascendente");
            }
        }
        static void Ej15()
        {
            Console.WriteLine("0");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
        }
        static void Ej16()
        {
            int[] numeros = new int[15];
            int i = 0;
            int final = 0;
            int prom = 0;
            int mayor = 0;

            for (i = 0; i < 15; i++)
            {
                Console.WriteLine($"Ingrese el número {i}: ");
                numeros[i] = Convert.ToInt16(Console.ReadLine());
                final += numeros[i];
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
            }
            prom = final / 15;
            Console.WriteLine($"Promedio: {prom}");
            Console.WriteLine($"Mayor: {mayor}");
        }
        static void Ej17()
        {
            int n1 = 0;
            int n2 = 0;

            Console.WriteLine("Escriba el primer número: ");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escriba el segundo número: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            if (n1 > n2)
            {
                for (n1 = n1; n1 <= n2 - 1; n1++)
                {
                    Console.WriteLine($"{n1 + 1}");
                }
            }
            else if (n2 > n1)
            {
                for (n2 = n2; n2 <= n1 - 1; n2++)
                {
                    Console.WriteLine($"{n2 + 1}");
                }
            }
            else
            {
                Console.WriteLine("Ambos números son iguales");
            }
        }
        static void Ej18()
        {
            int n = 0;
            int i;
            int res = 1;
            Console.WriteLine("Ingrese un número: ");
            n = Convert.ToInt16(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                res *= i;
            }
            Console.WriteLine($"Factorial de tu número: {res}");
        }

        static void Ej19()
        {
            Console.Clear();
            double basenum;
            int exponente;
            double resultado = 1;

            Console.WriteLine("Ingrese la base: ");
            basenum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente: ");
            exponente = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < exponente; i++)
            {
                resultado *= basenum;
            }

            Console.WriteLine("================");
            Console.WriteLine($"El resultado de {basenum} elevado a {exponente} es {resultado}");
            Console.WriteLine("================");
        }

        static void Ej20()
        {
            Console.Clear();
            int[,] notas = new int[30, 10];
            double[] promedioAlumno = new double[30];
            double sumaTotal = 0;

            for (int alumno = 0; alumno < 30; alumno++)
            {
                double sumaAlumno = 0;

                for (int materia = 0; materia < 10; materia++)
                {
                    Console.WriteLine($"Ingrese la nota de la materia {materia + 1} del alumno {alumno + 1}: ");
                    notas[alumno, materia] = Convert.ToInt16(Console.ReadLine());
                    sumaAlumno += notas[alumno, materia];
                }

                promedioAlumno[alumno] = sumaAlumno / 10;
                sumaTotal += sumaAlumno;
            }

            double promedioCurso = sumaTotal / (30 * 10);

            Console.WriteLine("================");
            for (int alumno = 0; alumno < 30; alumno++)
            {
                Console.WriteLine($"El promedio del alumno {alumno + 1} es {promedioAlumno[alumno]}");
            }
            Console.WriteLine($"El promedio general del curso es {promedioCurso}");
            Console.WriteLine("================");
        }

        static void Ej21()
        {
            Console.Clear();
            int[,] ventas = new int[20, 15];
            int[] totalVendedor = new int[20];
            int totalGeneral = 0;
            int mayorVentaDiaria = 0;
            int vendedorMayor = 0;
            int diaMayor = 0;

            for (int vendedor = 0; vendedor < 20; vendedor++)
            {
                for (int dia = 0; dia < 15; dia++)
                {
                    Console.WriteLine($"Ingrese las unidades vendidas por el vendedor {vendedor + 1} en el día {dia + 1}: ");
                    ventas[vendedor, dia] = Convert.ToInt16(Console.ReadLine());
                    totalVendedor[vendedor] += ventas[vendedor, dia];
                    totalGeneral += ventas[vendedor, dia];

                    if (ventas[vendedor, dia] > mayorVentaDiaria)
                    {
                        mayorVentaDiaria = ventas[vendedor, dia];
                        vendedorMayor = vendedor + 1;
                        diaMayor = dia + 1;
                    }
                }
            }

            Console.WriteLine("================");
            for (int vendedor = 0; vendedor < 20; vendedor++)
            {
                Console.WriteLine($"El vendedor {vendedor + 1} vendió un total de {totalVendedor[vendedor]} unidades");
            }
            Console.WriteLine($"El total general vendido fue de {totalGeneral} unidades");
            Console.WriteLine($"El vendedor con mayor venta diaria fue el vendedor {vendedorMayor} con {mayorVentaDiaria} unidades en el día {diaMayor}");
            Console.WriteLine("================");
        }

        static void Ej22()
        {
            Console.Clear();
            int[] numeros = new int[10];
            int negativos = 0;
            int positivos = 0;
            int ceros = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}: ");
                numeros[i] = Convert.ToInt16(Console.ReadLine());

                if (numeros[i] < 0)
                {
                    negativos++;
                }
                else if (numeros[i] > 0)
                {
                    positivos++;
                }
                else
                {
                    ceros++;
                }
            }

            Console.WriteLine("================");
            Console.WriteLine($"Cantidad de negativos: {negativos}");
            Console.WriteLine($"Cantidad de positivos: {positivos}");
            Console.WriteLine($"Cantidad de ceros: {ceros}");
            Console.WriteLine("================");
        }

        static void Ej23()
        {
            Console.Clear();
            double[] sueldos = new double[20];
            int masDe2000 = 0;
            int menosDe2000 = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Ingrese el sueldo de la persona {i + 1}: ");
                sueldos[i] = Convert.ToDouble(Console.ReadLine());

                if (sueldos[i] > 2000)
                {
                    masDe2000++;
                }
                else if (sueldos[i] < 2000)
                {
                    menosDe2000++;
                }
            }

            Console.WriteLine("================");
            Console.WriteLine($"Cantidad de personas que ganan más de $2000: {masDe2000}");
            Console.WriteLine($"Cantidad de personas que ganan menos de $2000: {menosDe2000}");
            Console.WriteLine("================");
        }

        static void Ej24()
        {
            Console.Clear();
            string[] nombres = new string[15];
            double[] notas = new double[15];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Ingrese el nombre del alumno {i + 1}: ");
                nombres[i] = Console.ReadLine();
                Console.WriteLine($"Ingrese la nota del alumno {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("================");
            Console.WriteLine("Alumnos con nota mayor a 8:");
            for (int i = 0; i < 15; i++)
            {
                if (notas[i] > 8)
                {
                    Console.WriteLine(nombres[i]);
                }
            }
            Console.WriteLine("================");
        }

        static void Ej25()
        {
            Console.Clear();
            int dia;
            int mes;
            int anio;
            bool valida = true;
            int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Ingrese el día: ");
            dia = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese el mes: ");
            mes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese el año: ");
            anio = Convert.ToInt16(Console.ReadLine());

            if (mes < 1 || mes > 12)
            {
                valida = false;
            }
            else
            {
                int diasMax = diasPorMes[mes - 1];

                if (mes == 2 && (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0)))
                {
                    diasMax = 29;
                }

                if (dia < 1 || dia > diasMax)
                {
                    valida = false;
                }
            }

            Console.WriteLine("================");
            if (valida)
            {
                Console.WriteLine("La fecha es válida");
            }
            else
            {
                Console.WriteLine("La fecha no es válida");
            }
            Console.WriteLine("================");
        }

        static void Ej26()
        {
            Console.Clear();
            int numeroFactura;
            int cantidad;
            double precioUnitario;
            int numeroProducto;

            int[] cantidadPorProducto = new int[1000];
            double mayorImporte = 0;
            int facturaMayorImporte = 0;

            do
            {
                Console.WriteLine("Ingrese el número de factura (999 para finalizar): ");
                numeroFactura = Convert.ToInt16(Console.ReadLine());

                if (numeroFactura == 999)
                {
                    break;
                }

                Console.WriteLine("Ingrese la cantidad: ");
                cantidad = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Ingrese el precio unitario: ");
                precioUnitario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el número de producto: ");
                numeroProducto = Convert.ToInt16(Console.ReadLine());

                cantidadPorProducto[numeroProducto] += cantidad;

                double importe = cantidad * precioUnitario;
                if (importe > mayorImporte)
                {
                    mayorImporte = importe;
                    facturaMayorImporte = numeroFactura;
                }

            } while (numeroFactura != 999);

            int productoMasVendido = 0;
            int mayorCantidad = 0;
            for (int i = 0; i < cantidadPorProducto.Length; i++)
            {
                if (cantidadPorProducto[i] > mayorCantidad)
                {
                    mayorCantidad = cantidadPorProducto[i];
                    productoMasVendido = i;
                }
            }

            Console.WriteLine("================");
            Console.WriteLine($"El producto más vendido es el número {productoMasVendido} con {mayorCantidad} unidades");
            Console.WriteLine($"El mayor importe vendido fue de {mayorImporte} en la factura número {facturaMayorImporte}");
            Console.WriteLine("================");
        }

        static void Ej27()
        {
            Console.Clear();
            double[] notaTP = new double[50];
            double[] promedioAlumno = new double[50];
            int[] cantidadNotas = new int[50];
            double sumaPromedios = 0;
            int alumnoMayorPromedio = 0;
            double mayorPromedio = 0;
            int alumnosConPocasNotas = 0;
            int alumnosTPAprobado = 0;

            for (int alumno = 0; alumno < 50; alumno++)
            {
                Console.WriteLine($"Ingrese la nota del trabajo práctico del alumno {alumno + 1}: ");
                notaTP[alumno] = Convert.ToDouble(Console.ReadLine());

                double suma = notaTP[alumno];
                int cantidad = 1;
                double nota;

                do
                {
                    Console.WriteLine($"Ingrese una nota de actividad del alumno {alumno + 1} (un número negativo para finalizar): ");
                    nota = Convert.ToDouble(Console.ReadLine());

                    if (nota >= 0)
                    {
                        suma += nota;
                        cantidad++;
                    }

                } while (nota >= 0);

                promedioAlumno[alumno] = suma / cantidad;
                cantidadNotas[alumno] = cantidad;
                sumaPromedios += promedioAlumno[alumno];

                if (promedioAlumno[alumno] > mayorPromedio)
                {
                    mayorPromedio = promedioAlumno[alumno];
                    alumnoMayorPromedio = alumno + 1;
                }

                if (cantidadNotas[alumno] <= 2)
                {
                    alumnosConPocasNotas++;
                }

                if (notaTP[alumno] >= 6)
                {
                    alumnosTPAprobado++;
                }
            }

            double promedioCurso = sumaPromedios / 50;

            Console.WriteLine("================");
            for (int alumno = 0; alumno < 50; alumno++)
            {
                Console.WriteLine($"El promedio del alumno {alumno + 1} es {promedioAlumno[alumno]}");
            }
            Console.WriteLine($"El alumno con mayor promedio es el alumno {alumnoMayorPromedio} con un promedio de {mayorPromedio}");
            Console.WriteLine($"El promedio general del curso es {promedioCurso}");
            Console.WriteLine($"Cantidad de alumnos con 2 o menos notas ingresadas: {alumnosConPocasNotas}");
            Console.WriteLine($"Cantidad de alumnos con T.P. aprobado: {alumnosTPAprobado}");
            Console.WriteLine("================");
        }

        static void Ej28()
        {
            Console.Clear();
            int dni;
            char sexo;
            int anioNacimiento;
            int cantidadHombres = 0;
            int cantidadMujeres = 0;
            int totalPersonas = 0;
            int menoresDeEdad = 0;
            int dniMenor30Millones = 0;
            int anioActual = 2026;

            do
            {
                Console.WriteLine("Ingrese el DNI (un número negativo para finalizar): ");
                dni = Convert.ToInt32(Console.ReadLine());

                if (dni < 0)
                {
                    break;
                }

                Console.WriteLine("Ingrese el sexo (M o F): ");
                sexo = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Ingrese el año de nacimiento: ");
                anioNacimiento = Convert.ToInt16(Console.ReadLine());

                totalPersonas++;

                if (sexo == 'M' || sexo == 'm')
                {
                    cantidadHombres++;
                }
                else if (sexo == 'F' || sexo == 'f')
                {
                    cantidadMujeres++;
                }

                if ((anioActual - anioNacimiento) < 18)
                {
                    menoresDeEdad++;
                }

                if (dni < 30000000)
                {
                    dniMenor30Millones++;
                }

            } while (dni >= 0);

            double porcentajeMenores = (menoresDeEdad * 100) / (double)totalPersonas;

            Console.WriteLine("================");
            Console.WriteLine($"Cantidad de hombres: {cantidadHombres}");
            Console.WriteLine($"Cantidad de mujeres: {cantidadMujeres}");
            Console.WriteLine($"Porcentaje de personas menores de edad: {porcentajeMenores}%");
            Console.WriteLine($"Cantidad de personas con DNI inferior a 30 millones: {dniMenor30Millones}");
            Console.WriteLine("================");
        }

        static void Ej29()
        {
            Console.Clear();
            int n;
            long resultado = 1;

            Console.WriteLine("Ingrese un número entero mayor o igual a 0: ");
            n = Convert.ToInt16(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("El número debe ser mayor o igual a 0");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    resultado *= i;
                }

                Console.WriteLine("================");
                Console.WriteLine($"El factorial de {n} es {resultado}");
                Console.WriteLine("================");
            }
        }
    }
}