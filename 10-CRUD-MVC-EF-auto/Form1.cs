using _10_CRUD_MVC_EF_auto.Modelss;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateOnly dateOnly = DateOnly.FromDateTime(dtpBirthDate.Value);
            var employee = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirthDate = dateOnly
            };

            _controller.AddEmployee(employee);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                var row = dgvEmployees.SelectedRows[0];
                DateOnly dateOnly = DateOnly.FromDateTime(dtpBirthDate.Value);
                var employee = new Employee
                {
                    EmployeeId = (int)row.Cells["EmployeeID"].Value,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = dateOnly
                };

                _controller.UpdateEmployee(employee);
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecciona un empleado para actualizar.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                var row = dgvEmployees.SelectedRows[0];
                int employeeId = (int)row.Cells["EmployeeID"].Value;

                _controller.DeleteEmployee(employeeId);
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecciona un empleado para eliminar.");
            }
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                var row = dgvEmployees.SelectedRows[0];
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                dtpBirthDate.Value = ((DateOnly)row.Cells["BirthDate"].Value).ToDateTime(TimeOnly.MinValue);
            } 
        }
    }
}
