using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EmployeeManagement.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public SqlEmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        
        public Employee? GetEmployee(int Id)
        {
            if (_context.Employees != null) 
                return _context.Employees.Find(Id);

            return null;
        }

        public IEnumerable<Employee?>? GetAllEmployees()
        {
            if (_context.Employees != null) 
                return _context.Employees;

            return null;
        }

        public Employee? AddEmployee(Employee? employee)
        {
            if (_context.Employees != null) 
                _context.Employees.Add(employee);

            _context.SaveChanges();
            return employee;
        }

        public Employee? UpdateEmployee(Employee? employeeChanges)
        {
            if (_context.Employees != null)
            {
                var employee = _context.Employees.Attach(employeeChanges);
                employee.State = EntityState.Modified;
            }

            _context.SaveChanges();
            return employeeChanges;
        }

        public Employee? DeleteEmployee(int id)
        {
            if (_context.Employees != null)
            {
                Employee? employee = _context.Employees.Find(id);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                }
            }
            
            return null;
        }
    }


}
