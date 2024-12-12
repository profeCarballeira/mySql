using Microsoft.EntityFrameworkCore.Diagnostics;

namespace _13_Navegacion_registros_EF
{
    public partial class Form1 : Form
    {
        private CustomerController _controller;

        private BindingSource _bindingSource;

        public Form1()
        {
            InitializeComponent();
            _controller = new CustomerController();
            LoadData();
            SetupDataBindings();
        }
        private void LoadData()
        {
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _controller.GetAllCustomers();
        }
        private void SetupDataBindings()
        {
            //configurar los DataBindings para los TextBox
            txtNombre.DataBindings.Add("Text", _bindingSource, "CustomerName");
            txtDireccion.DataBindings.Add("Text", _bindingSource, "Address");
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            _bindingSource.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _bindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _bindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            _bindingSource.MoveLast();
        }
    }
}
