using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BethanysPieShopHRM.Shared;

using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; }
        public EmployeeModel Employee { get; set; } = new EmployeeModel();

        protected override Task OnInitializedAsync()
        {

            InitializeCountries();
            InitializeJobCategories();
            InitializeEmployees();

            Employee = Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));


            return base.OnInitializedAsync();
        }

        public IEnumerable<EmployeeModel> Employees { get; set; }

        private List<CountryModel> Countries { get; set; }

        private List<JobCategoryModel> JobCategories { get; set; }

        private void InitializeJobCategories() => JobCategories = new List<JobCategoryModel>()
            {
                new JobCategoryModel{JobCategoryId = 1, JobCategoryName = "Pie research"},
                new JobCategoryModel{JobCategoryId = 2, JobCategoryName = "Sales"},
                new JobCategoryModel{JobCategoryId = 3, JobCategoryName = "Management"},
                new JobCategoryModel{JobCategoryId = 4, JobCategoryName = "Store staff"},
                new JobCategoryModel{JobCategoryId = 5, JobCategoryName = "Finance"},
                new JobCategoryModel{JobCategoryId = 6, JobCategoryName = "QA"},
                new JobCategoryModel{JobCategoryId = 7, JobCategoryName = "IT"},
                new JobCategoryModel{JobCategoryId = 8, JobCategoryName = "Cleaning"},
                new JobCategoryModel{JobCategoryId = 9, JobCategoryName = "Bakery"},
                new JobCategoryModel{JobCategoryId = 9, JobCategoryName = "Bakery"}
            };

        private void InitializeCountries() => Countries = new List<CountryModel>
            {
                new CountryModel {CountryId = 1, Name = "Belgium"},
                new CountryModel {CountryId = 2, Name = "Netherlands"},
                new CountryModel {CountryId = 3, Name = "USA"},
                new CountryModel {CountryId = 4, Name = "Japan"},
                new CountryModel {CountryId = 5, Name = "China"},
                new CountryModel {CountryId = 6, Name = "UK"},
                new CountryModel {CountryId = 7, Name = "France"},
                new CountryModel {CountryId = 8, Name = "Brazil"}
            };

        private void InitializeEmployees()
        {
            var e1 = new EmployeeModel
            {
                CountryId = 1,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1989, 3, 11),
                City = "Brussels",
                Email = "bethany@bethanyspieshop.com",
                EmployeeId = 1,
                FirstName = "Bethany",
                LastName = "Smith",
                Gender = Gender.Female,
                PhoneNumber = "324777888773",
                Smoker = true,
                Street = "Grote Markt 1",
                Zip = "1000",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1)
            };

            var e2 = new EmployeeModel
            {
                CountryId = 2,
                MaritalStatus = MaritalStatus.Married,
                BirthDate = new DateTime(1979, 1, 16),
                City = "Antwerp",
                Email = "gill@bethanyspieshop.com",
                EmployeeId = 2,
                FirstName = "Gill",
                LastName = "Cleeren",
                Gender = Gender.Male,
                PhoneNumber = "33999909923",
                Smoker = false,
                Street = "New Street",
                Zip = "2000",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2017, 12, 24)
            };
            Employees = new List<EmployeeModel> { e1, e2 };
        }
    }
}