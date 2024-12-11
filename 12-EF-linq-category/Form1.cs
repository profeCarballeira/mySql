using _12_EF_linq_category.Modelss;
using System;
using System.Diagnostics;

namespace _12_EF_linq_category
{
    public partial class Form1 : Form
    {
        private CategoryController _controller;
        public Form1()
        {
            InitializeComponent();
            _controller = new CategoryController();
            LoadData();

        }

        private void LoadData()
        {
            dgvCategories.DataSource = _controller.GetAllCategories();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var cat = new Category
            {
                CategoryName = txtNombreCateg.Text,
                Description = txtDescripcionCateg.Text
            };

            _controller.AddCategory(cat);
            LoadData();
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                var row = dgvCategories.SelectedRows[0];
                txtNombreCateg.Text = row.Cells["CategoryName"].Value.ToString();
                txtDescripcionCateg.Text = row.Cells["Description"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                var row = dgvCategories.SelectedRows[0];
                var cat = new Category
                {
                    CategoryId = (int)row.Cells["CategoryId"].Value,
                    CategoryName = txtNombreCateg.Text,
                    Description = txtDescripcionCateg.Text
                };

                _controller.UpdateCategory(cat);
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecciona una categoría para actualizar.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                var row = dgvCategories.SelectedRows[0];
                int categoryId = (int)row.Cells["CategoryId"].Value;

                _controller.DeleteCategory(categoryId);
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecciona una categoría para eliminar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ToList(), Add()  y Find() ya vistos

            w3schoolsContext _context = new w3schoolsContext();

            //where
            List<Category> listCat = _context.Categories.Where(e => e.CategoryId > 3).ToList();

            foreach (var cat in listCat)
            {
                Debug.WriteLine($"CategoryID: {cat.CategoryId}, CategoryName: {cat.CategoryName}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            w3schoolsContext _context = new w3schoolsContext();

            //select de 1 campo
            List<string?> nombreCat = _context.Categories.Select(e => e.CategoryName).ToList();
            foreach (var nombre in nombreCat)
            {
                Debug.WriteLine($"Nombre categoria: {nombre}");
            }

            //select mas de un campo con var
            var cat_id_nombre = _context.Categories.Select(e => new { e.CategoryId, e.CategoryName }).ToList();
            foreach (var c in cat_id_nombre)
            {
                Debug.WriteLine($"ID: {c.CategoryId} Nombre: {c.CategoryName}");
            }

        }

        private void btnSelectWhere_Click(object sender, EventArgs e)
        {
            w3schoolsContext _context = new w3schoolsContext();

            //where
            var cat_nombre_descripc = _context.Categories.Where(e => e.CategoryId > 5)
                                            .Select(e => new { e.CategoryName, e.Description })
                                            .ToList();

            foreach (var c in cat_nombre_descripc)
            {
                Debug.WriteLine($"Nombre: {c.CategoryName}, Descrpición: {c.Description}");
            }

            //se pueden combinar
            //otras operaciones: OrderBy, Join, GroupBy, Count...
            //Eager Loading con Include....

            //Unir Tablas(Join):
            //var resultado = from emp in context.Employees
            //    join dept in context.Departments on emp.DepartmentId equals dept.DepartmentId
            //    select new { emp.FirstName, dept.Name };
        }
    }
}
