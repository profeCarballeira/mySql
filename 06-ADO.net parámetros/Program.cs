using System;
using System.Data;
using MySql.Data.MySqlClient;

class Programa
{
    static void Main()
    {
        string cadConexion = "server=localhost;port=3307;user=dam2;password=abc123.;database=w3schools;";

        try
        {
            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                // Abrir la conexión
                conn.Open();
                Console.WriteLine("Conectado con éxito");

                // Crear un DataSet para almacenar los datos
                DataSet dataSet = new DataSet();

                // **Operación de Consulta (Select) para llenar el DataSet**
                string selectQuery = "SELECT * FROM employees";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery, conn))
                {
                    dataAdapter.Fill(dataSet, "employees"); // Llenar el DataSet con la tabla "employees"
                }

                // Ver los datos en el DataSet (a través de la tabla "employees")
                DataTable employeesTable = dataSet.Tables["employees"];
                foreach (DataRow row in employeesTable.Rows)
                {
                    Console.WriteLine($"ID: {row["EmployeeID"]}, Nombre: {row["FirstName"]} {row["LastName"]}");
                }

                // **Operación de Inserción (Insert)**  
                string insertQuery = "INSERT INTO employees (FirstName, LastName, BirthDate) VALUES (@firstName, @lastName, @birthDate)";
                using (MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@firstName", "Juan");
                    cmdInsert.Parameters.AddWithValue("@lastName", "Pérez");
                    cmdInsert.Parameters.AddWithValue("@birthDate", "2024-11-12");

                    cmdInsert.ExecuteNonQuery(); // Ejecutar la inserción
                }

                // Después de la inserción, actualizamos el DataSet
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery, conn))
                {
                    dataSet.Clear(); // Limpiar el DataSet actual
                    dataAdapter.Fill(dataSet, "employees"); // Volver a llenar el DataSet con los datos actualizados
                }

                // **Operación de Modificación (Update)**
                string updateQuery = "UPDATE employees SET FirstName = @firstName WHERE EmployeeID = @employeeID";
                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn))
                {
                    updateCommand.Parameters.AddWithValue("@firstName", "Carlos");
                    updateCommand.Parameters.AddWithValue("@employeeID", 3);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conn);
                    adapter.UpdateCommand = updateCommand;

                    adapter.Update(dataSet.Tables["employees"]); // Actualizar el DataSet
                }

                // Actualizar el DataSet después de la modificación
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery, conn))
                {
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "employees");
                }

                // **Operación de Borrado (Delete)**
                string deleteQuery = "DELETE FROM employees WHERE EmployeeID = @employeeID";
                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, conn))
                {
                    deleteCommand.Parameters.AddWithValue("@employeeID", 12);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conn);
                    adapter.DeleteCommand = deleteCommand;

                    adapter.Update(dataSet.Tables["employees"]); // Actualizar el DataSet
                }

                // Actualizar el DataSet después de la eliminación
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery, conn))
                {
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "employees");
                }

                // Ver los datos actualizados en el DataSet
                employeesTable = dataSet.Tables["employees"];
                foreach (DataRow row in employeesTable.Rows)
                {
                    Console.WriteLine($"ID: {row["EmployeeID"]}, Nombre: {row["FirstName"]} {row["LastName"]}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Excepción: {ex.ToString()}");
        }
    }
}
