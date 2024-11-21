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
    }
}
