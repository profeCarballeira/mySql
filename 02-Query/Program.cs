using System;
using MySql.Data.MySqlClient;

class Programa
{
    static void Main()
    {
        string cadConexion = "server=localhost;port=3307;user=dam2;password=abc123.;database=w3schools;";
        try
        {
            //conectar
            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                conn.Open();
                Console.WriteLine("Conectado con éxito");
                //hacer una consulta de todos los productos de la categoría "Condiments"
                string query = @"
                    SELECT p.ProductName, p.Price
                    FROM products p
                    JOIN categories c ON p.CategoryID = c.CategoryID
                    WHERE c.CategoryName = 'Condiments';
                ";

                //crear el comando
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine($"Producto: {dr["ProductName"]}, Precio: {dr["Price"]}");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Expeción: {ex.ToString()}");
        }
    }
}
