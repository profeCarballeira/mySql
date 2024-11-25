using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Models;
using CRUD.Controllers;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CRUD.Views {
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

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                var row = dgvEmployees.SelectedRows[0];
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                dtpBirthDate.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var employee = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirthDate = dtpBirthDate.Value
            };

            _controller.AddEmployee(employee);
            LoadData();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                var row = dgvEmployees.SelectedRows[0];
                var employee = new Employee
                {
                    EmployeeID = (int)row.Cells["EmployeeID"].Value,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = dtpBirthDate.Value
                };

                _controller.UpdateEmployee(employee);
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecciona un empleado para actualizar.");
            }
        }
    }
}
