using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using _10_CRUD_MVC_EF_auto.Modelss;

namespace _10_CRUD_MVC_EF_auto
{
    public class EmployeeController
    {
        private w3schoolsContext _context;

        public EmployeeController()
        {
            _context = new w3schoolsContext();
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = _context.Employees.Find(employee.EmployeeId);
            if (existingEmployee != null)
            {
                // Mapear las propiedades actualizadas aquí
                _context.SaveChanges();
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = _context.Employees.Find(employeeId);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}
