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
    }
}
