using System;
using System.Data;
using MySqlConnector;

class Program
{
    static string cadenaConexion = "Server=127.0.0.1;Database=escuela;User Id=root;Password=;";

    static void RegistrarAlumno()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine().Trim();
        Console.Write("Edad: ");
        bool edadOk = int.TryParse(Console.ReadLine(), out int edad);
        Console.Write("Curso: ");
        string curso = Console.ReadLine().Trim();

        if (nombre == "" || curso == "" || !edadOk || edad <= 0)
        {
            Console.WriteLine("Datos no válidos.");
            return;
        }

        using var conexion = new MySqlConnection(cadenaConexion);
        conexion.Open();
        using var comando = new MySqlCommand("RegistrarAlumno", conexion);
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("p_nombre", nombre);
        comando.Parameters.AddWithValue("p_edad", edad);
        comando.Parameters.AddWithValue("p_curso", curso);
        comando.ExecuteNonQuery();
        Console.WriteLine("Alumno registrado.");
    }

    static void ListarAlumnos()
    {
        using var conexion = new MySqlConnection(cadenaConexion);
        conexion.Open();
        using var comando = new MySqlCommand("ListarAlumnos", conexion);
        comando.CommandType = CommandType.StoredProcedure;
        using var lector = comando.ExecuteReader();
        while (lector.Read())
            Console.WriteLine($"{lector["id"]} - {lector["nombre"]} - {lector["edad"]} - {lector["curso"]}");
    }

    static void BuscarAlumnosPorCurso()
    {
        Console.Write("Curso: ");
        string curso = Console.ReadLine().Trim();
        if (curso == "")
        {
            Console.WriteLine("El curso no puede estar vacío.");
            return;
        }

        using var conexion = new MySqlConnection(cadenaConexion);
        conexion.Open();
        using var comando = new MySqlCommand("BuscarAlumnosPorCurso", conexion);
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("p_curso", curso);
        using var lector = comando.ExecuteReader();
        while (lector.Read())
            Console.WriteLine($"{lector["id"]} - {lector["nombre"]} - {lector["edad"]} - {lector["curso"]}");
    }

    static void ModificarEdadAlumno()
    {
        Console.Write("ID: ");
        bool idOk = int.TryParse(Console.ReadLine(), out int id);
        Console.Write("Nueva edad: ");
        bool edadOk = int.TryParse(Console.ReadLine(), out int edad);

        if (!idOk || !edadOk || edad <= 0)
        {
            Console.WriteLine("Datos no válidos.");
            return;
        }

        using var conexion = new MySqlConnection(cadenaConexion);
        conexion.Open();
        using var comando = new MySqlCommand("ModificarEdadAlumno", conexion);
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("p_id", id);
        comando.Parameters.AddWithValue("p_edad", edad);
        int filas = comando.ExecuteNonQuery();
        Console.WriteLine(filas > 0 ? "Edad modificada." : "No se encontró el alumno.");
    }

    static void EliminarAlumno()
    {
        Console.Write("ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID no válido.");
            return;
        }

        using var conexion = new MySqlConnection(cadenaConexion);
        conexion.Open();
        using var comando = new MySqlCommand("EliminarAlumno", conexion);
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("p_id", id);
        int filas = comando.ExecuteNonQuery();
        Console.WriteLine(filas > 0 ? "Alumno eliminado." : "No se encontró el alumno.");
    }

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n========= GESTIÓN DE ALUMNOS =========");
            Console.WriteLine("1. Registrar alumno");
            Console.WriteLine("2. Listar todos los alumnos");
            Console.WriteLine("3. Buscar alumnos por curso");
            Console.WriteLine("4. Modificar edad de un alumno");
            Console.WriteLine("5. Eliminar alumno");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            int.TryParse(Console.ReadLine(), out opcion);

            try
            {
                switch (opcion)
                {
                    case 1: RegistrarAlumno(); break;
                    case 2: ListarAlumnos(); break;
                    case 3: BuscarAlumnosPorCurso(); break;
                    case 4: ModificarEdadAlumno(); break;
                    case 5: EliminarAlumno(); break;
                    case 0: Console.WriteLine("¡Hasta luego!"); break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error de MySQL: " + ex.Message);
            }
        } while (opcion != 0);
    }
}
