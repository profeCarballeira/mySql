using System.Data;
using MySql.Data.MySqlClient;

namespace _07_ADO_forms
{
    public partial class Form1 : Form
    {
        string cadConexion = "server=localhost;port=3307;user=dam2;password=abc123.;database=w3schools;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstRsultados.Items.Clear();
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
                        //Console.WriteLine($"ID: {row["EmployeeID"]}, Nombre: {row["FirstName"]} {row["LastName"]}");
                        string resultado = $"ID: {row["EmployeeID"]}, Nombre: {row["FirstName"]} {row["LastName"]}, Fecha: {row["BirthDate"]}";
                        lstRsultados.Items.Add(resultado);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción: {ex.ToString()}");
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            //string birthDate = txtBirthDate.Text;

            // Convertir la fecha de "dd/MM/yy" a "yyyy-MM-dd"
            DateTime birthDate;
            if (!DateTime.TryParseExact(txtBirthDate.Text, "d/M/yy", null, System.Globalization.DateTimeStyles.None, out birthDate))
            {
                MessageBox.Show("Formato de fecha incorrecto. Usar dd/MM/yy, por ejemplo: 24/7/71.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(cadConexion))
                {
                    // Abrir la conexión
                    conn.Open();
                    Console.WriteLine("Conectado con éxito");

                    // Crear un DataSet para almacenar los datos
                    DataSet dataSet = new DataSet();
                    DataTable employeesTable = new DataTable();

                    // Configurar el DataAdapter con los comandos necesarios
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM employees", conn);

                    // Generar automáticamente los comandos Insert, Update y Delete
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

                    // Llenar el DataSet con los datos de la tabla "employees"
                    dataAdapter.Fill(dataSet, "employees");
                    employeesTable = dataSet.Tables["employees"];

                    // **Agregar una nueva fila directamente en el DataTable**
                    DataRow newRow = employeesTable.NewRow();
                    newRow["FirstName"] = firstName;
                    newRow["LastName"] = lastName;
                    newRow["BirthDate"] = birthDate;
                    employeesTable.Rows.Add(newRow);

                    // **Sincronizar el DataSet con la base de datos**
                    dataAdapter.Update(dataSet, "employees");

                    MessageBox.Show("Nueva fila insertada correctamente");

                    //// **Verificar los datos actualizados en el DataTable**
                    //foreach (DataRow row in employeesTable.Rows)
                    //{
                    //    Console.WriteLine($"ID: {row["EmployeeID"]}, Nombre: {row["FirstName"]} {row["LastName"]}");
                    //}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.ToString()}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string employeeIDText = txtEmployeeID.Text; // ID del empleado a modificar
            string newFirstName = txtFirstName.Text; // Nuevo nombre
            string newLastName = txtLastName.Text;   // Nuevo apellido

            // Validar que el ID es numérico
            if (!int.TryParse(employeeIDText, out int employeeID))
            {
                MessageBox.Show("El ID del empleado debe ser un número válido.");
                return;
            }

            // Convertir la fecha de "dd/MM/yy" a "yyyy-MM-dd"
            DateTime newBirthDate;
            if (!DateTime.TryParseExact(txtBirthDate.Text, "d/M/yy", null, System.Globalization.DateTimeStyles.None, out newBirthDate))
            {
                MessageBox.Show("Formato de fecha incorrecto. Usar dd/MM/yy, por ejemplo: 24/7/71.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(cadConexion))
                {
                    // Abrir la conexión
                    conn.Open();

                    // Crear un DataSet para almacenar los datos
                    DataSet dataSet = new DataSet();
                    DataTable employeesTable = new DataTable();

                    // Configurar el DataAdapter con los comandos necesarios
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM employees", conn);

                    // Generar automáticamente los comandos Insert, Update y Delete
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

                    // Llenar el DataSet con los datos de la tabla "employees"
                    dataAdapter.Fill(dataSet, "employees");
                    employeesTable = dataSet.Tables["employees"];

                    // **Buscar la fila correspondiente al EmployeeID**
                    DataRow[] rows = employeesTable.Select($"EmployeeID = {employeeID}");
                    if (rows.Length == 0)
                    {
                        MessageBox.Show("No se encontró un empleado con el ID especificado.");
                        return;
                    }

                    // Actualizar los valores en la fila encontrada
                    DataRow rowToUpdate = rows[0];
                    rowToUpdate["FirstName"] = newFirstName;
                    rowToUpdate["LastName"] = newLastName;
                    rowToUpdate["BirthDate"] = newBirthDate;

                    // **Sincronizar los cambios con la base de datos**
                    dataAdapter.Update(dataSet, "employees");

                    MessageBox.Show("Empleado actualizado correctamente.");

                    //// (Opcional) Imprimir los valores actualizados
                    //Console.WriteLine($"ID: {rowToUpdate["EmployeeID"]}, Nombre: {rowToUpdate["FirstName"]} {rowToUpdate["LastName"]}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción: {ex.ToString()}");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string employeeIDText = txtEmployeeID.Text; // ID del empleado a borrar

            // Validar que el ID es numérico
            if (!int.TryParse(employeeIDText, out int employeeID))
            {
                MessageBox.Show("El ID del empleado debe ser un número válido.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(cadConexion))
                {
                    // Abrir la conexión
                    conn.Open();

                    // Crear un DataSet para almacenar los datos
                    DataSet dataSet = new DataSet();
                    DataTable employeesTable = new DataTable();

                    // Configurar el DataAdapter con los comandos necesarios
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM employees", conn);

                    // Generar automáticamente los comandos Insert, Update y Delete
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

                    // Llenar el DataSet con los datos de la tabla "employees"
                    dataAdapter.Fill(dataSet, "employees");
                    employeesTable = dataSet.Tables["employees"];

                    // **Buscar la fila correspondiente al EmployeeID**
                    DataRow[] rows = employeesTable.Select($"EmployeeID = {employeeID}");
                    if (rows.Length == 0)
                    {
                        MessageBox.Show("No se encontró un empleado con el ID especificado.");
                        return;
                    }

                    // **Eliminar la fila del DataTable**
                    DataRow rowToDelete = rows[0];
                    rowToDelete.Delete();

                    // **Sincronizar los cambios con la base de datos**
                    dataAdapter.Update(dataSet, "employees");

                    MessageBox.Show("Empleado borrado correctamente.");

                    //// (Opcional) Verificar los datos restantes en el DataTable
                    //foreach (DataRow row in employeesTable.Rows)
                    //{
                    //    Console.WriteLine($"ID: {row["EmployeeID"]}, Nombre: {row["FirstName"]} {row["LastName"]}");
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción: {ex.ToString()}");
            }
        }
    }
}
