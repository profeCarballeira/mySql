using System;
using MySql.Data.MySqlClient;

class Programa {
    static void Main() {
        string cadConexion = "server=localhost;port=3307;user=dam2;password=abc123.;database=w3schools;";
        try{
            //conectar
            using (MySqlConnection conn = new MySqlConnection(cadConexion)){
                conn.Open();
                Console.WriteLine("Conectado con éxito");         
            //traer datos
            //query en sql
            string query = "SELECT * FROM employees";

                //crear el comando
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) { 
                    using (MySqlDataReader dr = cmd.ExecuteReader()) {
                        while (dr.Read()) {
                            Console.WriteLine($"ID: {dr["EmployeeID"]}, Nombre: {dr["FirstName"]}");
                        }
                    }      
                }
            }
        }
        catch (Exception ex) { 
            Console.WriteLine($"Expeción: {ex.ToString()}");
        }
    }
}
