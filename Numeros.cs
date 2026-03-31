namespace ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int temp;
            int temp1 = -999999999;
            int temp2 = 1000000000;
            int pos1 = 0;
            int pos2 = 0;
            Console.WriteLine("Ingrese 10 numeros:");

            int[] array = new int[10];

            for (i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("--------------------------------------");
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine(array[j]);
            }
            for (j = 0; j < 10; j++)
            {
                temp = array[j];
                if (temp > temp1)
                {
                    temp1 = temp;
                    pos1 = j + 1;
                }
            }
            for (j = 9; j >= 0; j--)
            {
                temp = array[j];
                if (temp < temp2)
                {
                    temp2 = temp;
                    pos2 = j + 1;
                }
            }
            Console.WriteLine($"El numero mas alto del array es: {temp1}, y está en la posición: {pos1}");
            Console.WriteLine($"El numero mas bajo del array es: {temp2}, y está en la posición: {pos2}");
        }
    }
}
