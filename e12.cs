namespace e12
{
    public class Program
    {
        public static void Main()
        {
            int[] elem = new int[20];
            int[] elemasc = new int[20];
            int[] eledesc = new int[20];
            int[] elemult = new int[20];

            int aux;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Ingrese el elemento " + (i + 1) + ": ");
                elem[i] = int.Parse(Console.ReadLine());

                elemasc[i] = elem[i];
                eledesc[i] = elem[i];
            }

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19 - i; j++)
                {
                    if (elemasc[j] > elemasc[j + 1])
                    {
                        aux = elemasc[j];
                        elemasc[j] = elemasc[j + 1];
                        elemasc[j + 1] = aux;
                    }

                    if (eledesc[j] < eledesc[j + 1])
                    {
                        aux = eledesc[j];
                        eledesc[j] = eledesc[j + 1];
                        eledesc[j + 1] = aux;
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                elemult[i] = elemasc[i] * eledesc[i];
            }

            Console.WriteLine("Vector ascendente:");

            for (int i = 0; i < 20; i++)
            {
                Console.Write(elemasc[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Vector descendente:");

            for (int i = 0; i < 20; i++)
            {
                Console.Write(eledesc[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Vector multiplicado:");

            for (int i = 0; i < 20; i++)
            {
                Console.Write(elemult[i] + " ");
            }
        }
    }
}

