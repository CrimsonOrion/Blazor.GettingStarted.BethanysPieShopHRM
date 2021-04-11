using System.Collections.Generic;

using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.Api.Models
{
    public interface IEmployeeRepository
    {
        EmployeeModel AddEmployee(EmployeeModel employee);
        void DeleteEmployee(int employeeId);
        IEnumerable<EmployeeModel> GetAllEmployees();
        EmployeeModel GetEmployeeById(int employeeId);
        EmployeeModel UpdateEmployee(EmployeeModel employee);
    }
}