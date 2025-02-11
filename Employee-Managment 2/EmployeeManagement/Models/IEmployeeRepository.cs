﻿
namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee? GetEmployee(int Id);
        IEnumerable<Employee?>? GetAllEmployees();

        Employee? AddEmployee (Employee? employee);
        Employee? UpdateEmployee (Employee? employeeChanges);
        Employee? DeleteEmployee (int  id);
    }
}