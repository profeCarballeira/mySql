using MySql.Data.MySqlClient;

namespace CrearTablaFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;port=3307;user=dam2;password=abc123.;database=db1";
            string query = @"
                CREATE TABLE IF NOT EXISTS Frutas (
                    Id INT AUTO_INCREMENT PRIMARY KEY,
                    Nombre VARCHAR(50) NOT NULL,
                    Precio DECIMAL(10, 2) NOT NULL
                );";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open(); // Abre la conexión

                    // Ejecuta el comando para crear la tabla
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("La tabla 'Frutas' se ha creado exitosamente.");
                    }

                    connection.Close(); // Cierra la conexión
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
        }
    }
}

