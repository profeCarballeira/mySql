using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace _15_Yaml_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void cargarConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hola");
            try
            {
                // Leer el archivo YAML
                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .Build();

                var yamlContent = File.ReadAllText("config.yaml");
                var config = deserializer.Deserialize<DatabaseConfig>(yamlContent);

                // Mostrar los parámetros cargados
                MessageBox.Show($"Host: {config.Host}\nUsuario: {config.User}\nBase de Datos: {config.Database}",
                    "Configuración Cargada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la configuración: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
