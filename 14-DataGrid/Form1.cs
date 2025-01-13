using System.Windows.Forms;

namespace _14_DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarCiudades();
        }

        private void CargarCiudades()
        {
            var ciudades = new List<Ciudad>
           {
               new Ciudad { ID = 1, Nombre = "Madrid", ComunidadAutonoma = "Comunidad de Madrid", Poblacion = 3266126 },
               new Ciudad { ID = 2, Nombre = "Barcelona", ComunidadAutonoma = "Cataluña", Poblacion = 1636762 },
               new Ciudad { ID = 3, Nombre = "Valencia", ComunidadAutonoma = "Comunidad Valenciana", Poblacion = 791413 },
               new Ciudad { ID = 4, Nombre = "Sevilla", ComunidadAutonoma = "Andalucía", Poblacion = 688592 },
               new Ciudad { ID = 5, Nombre = "Zaragoza", ComunidadAutonoma = "Aragón", Poblacion = 675302 },
               new Ciudad { ID = 6, Nombre = "Málaga", ComunidadAutonoma = "Andalucía", Poblacion = 578460 },
               new Ciudad { ID = 7, Nombre = "Murcia", ComunidadAutonoma = "Región de Murcia", Poblacion = 459403 },
               new Ciudad { ID = 8, Nombre = "Palma", ComunidadAutonoma = "Islas Baleares", Poblacion = 416065 },
               new Ciudad { ID = 9, Nombre = "Las Palmas de Gran Canaria", ComunidadAutonoma = "Canarias", Poblacion = 381847 },
               new Ciudad { ID = 10, Nombre = "Bilbao", ComunidadAutonoma = "País Vasco", Poblacion = 346843 },
           };
            bindingSource1.DataSource = ciudades;
            dataGridView1.DataSource = bindingSource1;
        }

        private void btnAddEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnColumna = new DataGridViewButtonColumn();
            btnColumna.Name = "btnAccion";
            btnColumna.HeaderText = "Acción";
            btnColumna.Text = "Eliminar";
            btnColumna.UseColumnTextForButtonValue = true; // Esto asegura que todas las celdas muestren el texto
            dataGridView1.Columns.Add(btnColumna);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el clic ocurrió en la columna del botón
            if (e.ColumnIndex == dataGridView1.Columns["btnAccion"].Index && e.RowIndex >= 0)
            {
                string nombreCiudad = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();

                DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar la ciudad {nombreCiudad}?",
                                                      "Confirmar Eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Acción para eliminar la fila (base de datos, lógica, etc.)
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show($"Ciudad {nombreCiudad} eliminada correctamente.");
                }
            }

        }
    }
}
