namespace _10_CRUD_MVC_EF_auto
{
    public partial class Form1 : Form
    {
        private EmployeeController _controller;
        public Form1()
        {
            InitializeComponent();
            _controller = new EmployeeController();
            LoadData();

        }

        private void LoadData()
        {
            dgvEmployees.DataSource = _controller.GetAllEmployees();
        }

    }
}
