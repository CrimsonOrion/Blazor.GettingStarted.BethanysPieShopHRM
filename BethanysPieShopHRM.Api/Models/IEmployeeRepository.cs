using System.Collections.Generic;

using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.Api.Models
{
    public interface IEmployeeRepository
    {
        Employee AddEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
        Employee UpdateEmployee(Employee employee);
    }
}