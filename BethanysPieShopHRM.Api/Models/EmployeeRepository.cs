﻿using System.Collections.Generic;
using System.Linq;

using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public IEnumerable<EmployeeModel> GetAllEmployees() => _appDbContext.Employees;

        public EmployeeModel GetEmployeeById(int employeeId) => _appDbContext.Employees.FirstOrDefault(_ => _.EmployeeId == employeeId);

        public EmployeeModel AddEmployee(EmployeeModel employee)
        {
            var addedEntity = _appDbContext.Employees.Add(employee);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public EmployeeModel UpdateEmployee(EmployeeModel employee)
        {
            var foundEmployee = _appDbContext.Employees.FirstOrDefault(_ => _.EmployeeId == employee.EmployeeId);

            if (foundEmployee != null)
            {
                foundEmployee.CountryId = employee.CountryId;
                foundEmployee.MaritalStatus = employee.MaritalStatus;
                foundEmployee.BirthDate = employee.BirthDate;
                foundEmployee.City = employee.City;
                foundEmployee.Email = employee.Email;
                foundEmployee.FirstName = employee.FirstName;
                foundEmployee.LastName = employee.LastName;
                foundEmployee.Gender = employee.Gender;
                foundEmployee.PhoneNumber = employee.PhoneNumber;
                foundEmployee.Smoker = employee.Smoker;
                foundEmployee.Street = employee.Street;
                foundEmployee.Zip = employee.Zip;
                foundEmployee.JobCategoryId = employee.JobCategoryId;
                foundEmployee.Comment = employee.Comment;
                foundEmployee.ExitDate = employee.ExitDate;
                foundEmployee.JoinedDate = employee.JoinedDate;

                _appDbContext.SaveChanges();

                return foundEmployee;
            }

            return null;
        }

        public void DeleteEmployee(int employeeId)
        {
            var foundEmployee = _appDbContext.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);
            if (foundEmployee == null) return;

            _appDbContext.Employees.Remove(foundEmployee);
            _appDbContext.SaveChanges();
        }
    }
}