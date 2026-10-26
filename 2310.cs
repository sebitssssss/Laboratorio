using System;
using System.IO;

namespace StockDeportes
{
internal class Program
{
static void Main(string[] args)
{
StreamReader lector = new StreamReader("STOCK_DEPORTES.TXT");
StreamWriter escritor = new StreamWriter("STOCK_BAJO.TXT");

string producto = lector.ReadLine();

while (producto != null)
{
int cantidad = Convert.ToInt32(lector.ReadLine());

if (cantidad < 50)
{
escritor.WriteLine(producto);
}

producto = lector.ReadLine();
}

lector.Close();
escritor.Close();
}
}
}
