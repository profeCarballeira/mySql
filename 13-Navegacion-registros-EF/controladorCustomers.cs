using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using _13_Navegacion_registros_EF.Modelss;

namespace _13_Navegacion_registros_EF
{
    public class CustomerController
    {
        private w3schoolsContext _context;

        public CustomerController()
        {
            _context = new w3schoolsContext();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = _context.Customers.Find(customer.CustomerId);
            if (existingCustomer != null)
            {
                // Mapear las propiedades actualizadas aquí
                _context.SaveChanges();
            }
        }

        public void DeleteCustomer(int CustomerId)
        {
            var customer = _context.Customers.Find(CustomerId);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }
    }
}
