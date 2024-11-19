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

                //inserción
                //ejemplo de myAdmin
                //INSERT INTO `employees` (`EmployeeID`, `LastName`, `FirstName`, `BirthDate`, `Photo`, `Notes`) VALUES ('20', 'Perez', 'Pepito', '2000-12-01', NULL, 'aaaa');
                string insertQuery = @"INSERT INTO employees (FirstName, LastName, BirthDate) 
                                       VALUES ('Hugo','Outumuro','2001-10-05')";
                using (MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn)) { 
                    int filasAfectadas = cmdInsert.ExecuteNonQuery();
                    Console.WriteLine($"Filas insertadatas: {filasAfectadas}");
                }


                //modificación
                //ejemplo de myAdmin
                //UPDATE `employees` SET `FirstName` = 'Andrews' WHERE `employees`.`EmployeeID` = 2
                string updateQuery = @"UPDATE employees SET FirstName = 'Antía' WHERE EmployeeID = 2";
                using (MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, conn))
                {
                    int filasAfectadas = cmdUpdate.ExecuteNonQuery();
                    Console.WriteLine($"Filas modificadas: {filasAfectadas}");
                }


                //borrado
                //ejemplo de myAdmin
                //DELETE FROM employees WHERE `employees`.`EmployeeID` = 22
                string deleteQuery = @"DELETE FROM employees WHERE EmployeeID = 21";
                using (MySqlCommand cmdDelete = new MySqlCommand(deleteQuery, conn))
                {
                    int filasAfectadas = cmdDelete.ExecuteNonQuery();
                    Console.WriteLine($"Tuplas borradas: {filasAfectadas}");
                }

                //consulta
                string selectQuery = "SELECT * FROM employees";
                using (MySqlCommand cmdSelect = new MySqlCommand(selectQuery, conn))
                {
                    using (MySqlDataReader dr = cmdSelect.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine($"ID: {dr["EmployeeID"]}, Nombre: {dr["FirstName"]}");
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
