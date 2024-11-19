using MySql.Data.MySqlClient;

namespace _04_OperacionesForm
{
    public partial class Form1 : Form
    {
        string cadConexion = "server=localhost;port=3307;user=dam2;password=abc123.;database=w3schools;";
        public Form1()
        {
            InitializeComponent();
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

            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                try
                {
                    conn.Open();
                    //dos formas hacer query:
                    //1. con formulacion de cadenas
                    //string query = $@"INSERT INTO employees (FirstName, LastName, BirthDate)
                    //            VALUES ('{firstName}', '{lastName}', '{birthDate.ToString("yyyy-MM-dd")}')";
                    //2. con parámetrasCualificados a posteriori
                    string query = "INSERT INTO employees (FirstName, LastName, BirthDate) VALUES (@FirstName, @LastName, @BirthDate)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        MessageBox.Show(filasAfectadas > 0 ? "Inserción exitosa" : "No se pudo insertar el registro.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al insertar: {ex.Message}");
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstRsultados.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM employees";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string resultado = $"ID: {reader["EmployeeID"]}, Nombre: {reader["FirstName"]} {reader["LastName"]}, Fecha: {reader["BirthDate"]}";
                                lstRsultados.Items.Add(resultado);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al consultar: {ex.Message}");
                }

            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                MessageBox.Show("Por favor, introduce el ID del empleado.");
                return;
            }

            int id = int.Parse(txtEmployeeID.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            // Convertir la fecha de "dd/MM/yy" a "yyyy-MM-dd"
            DateTime birthDate;
            if (!DateTime.TryParseExact(txtBirthDate.Text, "d/M/yy", null, System.Globalization.DateTimeStyles.None, out birthDate))
            {
                MessageBox.Show("Formato de fecha incorrecto. Usar dd/MM/yy, por ejemplo: 24/7/71.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE employees SET FirstName = @FirstName, LastName = @LastName, BirthDate = @BirthDate WHERE EmployeeID = @EmployeeID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                        cmd.Parameters.AddWithValue("@EmployeeID", id);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        MessageBox.Show(filasAfectadas > 0 ? "Modificación exitosa" : "No se encontró el registro.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar: {ex.Message}");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                MessageBox.Show("Por favor, ingresa el ID del empleado.");
                return;
            }

            int id = int.Parse(txtEmployeeID.Text);

            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM employees WHERE EmployeeID = @EmployeeID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", id);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        MessageBox.Show(filasAfectadas > 0 ? "Borrado exitoso" : "No se encontró el registro.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al borrar: {ex.Message}");
                }
            }

        }
    }
}
