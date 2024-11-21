using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;port=3307;user=dam2;password=abc123.;database=w3schools;",
                new MySqlServerVersion(new Version(8, 0, 27)));
        }
        //solo en caso de que el nombre de la clase sea distinto de la tabla
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // Specify the table name explicitly
        //    modelBuilder.Entity<Employee>().ToTable("employees");
        //}
    }
}
