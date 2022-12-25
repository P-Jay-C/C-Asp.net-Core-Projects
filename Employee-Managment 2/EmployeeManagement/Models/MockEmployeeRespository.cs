using System.Runtime.CompilerServices;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository:IEmployeeRepository
    {
        private List<Employee?>? _employeeList { get; set; }

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee?>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@gmail.com" },
                new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@gmail.com" },
                new Employee() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@gmail.com" }
            };

        }

        public Employee? GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee?>? GetAllEmployees()
        {
            return _employeeList;
        }


        public Employee? AddEmployee(Employee? employee)
        {
            employee.Id = _employeeList.Max(e=>e.Id)+ 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee? UpdateEmployee(Employee? employeeChanges)
        {
            if (_employeeList != null)
            {
                if (_employeeList != null)
                {
                    Employee? employee = _employeeList.FirstOrDefault(e => employeeChanges != null && e.Id == employeeChanges.Id);

                    if (employee != null)
                    {
                        employee.Name = employeeChanges?.Name;
                        if (employeeChanges != null)
                        {
                            employee.Department = employeeChanges.Department;
                            employee.Email = employeeChanges.Email;
                        }
                    }

                    return employee;
                }
            }

            return null;
        }

        public Employee? DeleteEmployee(int id)
        {
            Employee? employee = null;
            if (_employeeList != null)
            {
                foreach (var e in _employeeList)
                {
                    if (e.Id == id)
                    {
                        employee = e;
                        break;
                    }
                }

                if (employee != null)
                {
                    _employeeList.Remove(employee);
                }
            }

            return employee;

        }
    }
}
