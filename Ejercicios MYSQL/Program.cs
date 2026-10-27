namespace ConexionMySQL2
{
    using System;
    using System.Globalization;
    using MySqlConnector;

    class Program
    {
        static string connectionString =
            "Server=127.0.0.1;Database=testdb;User Id=root;Password=;";

        static void ListarProductos()
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT id, nombre, precio, stock FROM productos";
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\n{0,-5} {1,-25} {2,12} {3,8}", "ID", "Nombre", "Precio", "Stock");
                        Console.WriteLine(new string('-', 54));

                        bool hayDatos = false;
                        while (reader.Read())
                        {
                            hayDatos = true;
                            Console.WriteLine("{0,-5} {1,-25} {2,12:N2} {3,8}",
                                reader.GetInt32("id"),
                                reader.GetString("nombre"),
                                reader.GetDecimal("precio"),
                                reader.GetInt32("stock"));
                        }

                        if (!hayDatos)
                            Console.WriteLine("No hay productos registrados.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error de base de datos: " + ex.Message);
            }
        }

        static void AgregarProducto()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine()?.Trim() ?? "";
            if (nombre == "")
            {
                Console.WriteLine("El nombre no puede estar vacío.");
                return;
            }

            Console.Write("Precio: ");
            if (!decimal.TryParse(Console.ReadLine()?.Replace(',', '.'),
                    NumberStyles.Number, CultureInfo.InvariantCulture, out decimal precio) || precio < 0)
            {
                Console.WriteLine("Precio no válido.");
                return;
            }

            Console.Write("Stock: ");
            if (!int.TryParse(Console.ReadLine(), out int stock) || stock < 0)
            {
                Console.WriteLine("Stock no válido.");
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO productos (nombre, precio, stock) VALUES (@nombre, @precio, @stock)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        int filas = cmd.ExecuteNonQuery();
                        Console.WriteLine(filas > 0 ? "Producto agregado correctamente." : "No se agregó el producto.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error de base de datos: " + ex.Message);
            }
        }

        static void ActualizarStock()
        {
            Console.Write("ID del producto: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("ID no válido.");
                return;
            }

            Console.Write("Nuevo stock: ");
            if (!int.TryParse(Console.ReadLine(), out int stock) || stock < 0)
            {
                Console.WriteLine("Stock no válido.");
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE productos SET stock = @stock WHERE id = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@id", id);
                        int filas = cmd.ExecuteNonQuery();
                        Console.WriteLine(filas > 0 ? "Stock actualizado." : "No existe un producto con ese ID.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error de base de datos: " + ex.Message);
            }
        }

        static void EliminarProducto()
        {
            Console.Write("ID del producto a eliminar: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("ID no válido.");
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM productos WHERE id = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int filas = cmd.ExecuteNonQuery();
                        Console.WriteLine(filas > 0 ? "Producto eliminado." : "No existe un producto con ese ID.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error de base de datos: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("\n--- MENÚ DE INVENTARIO ---");
                Console.WriteLine("1. Listar productos");
                Console.WriteLine("2. Agregar producto");
                Console.WriteLine("3. Actualizar stock");
                Console.WriteLine("4. Eliminar producto");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            ListarProductos();
                            break;
                        case 2:
                            AgregarProducto();
                            break;
                        case 3:
                            ActualizarStock();
                            break;
                        case 4:
                            EliminarProducto();
                            break;
                        case 5:
                            Console.WriteLine("¡Hasta luego!");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ingresa un número válido.");
                }
            } while (opcion != 5);
        }
    }
}
