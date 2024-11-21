using CRUD.Models;


namespace CRUD.Controllers
{
    public class EmployeeController
    {
        private AppDbContext _context;

        public EmployeeController()
        {
            _context = new AppDbContext();
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.employees.ToList();
        }

        public void AddEmployee(Employee employee)
        {
            _context.employees.Add(employee);
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = _context.employees.Find(employee.EmployeeID);
            if (existingEmployee != null)
            {
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.BirthDate = employee.BirthDate;
                _context.SaveChanges();
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = _context.employees.Find(employeeId);
            if (employee != null)
            {
                _context.employees.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}
