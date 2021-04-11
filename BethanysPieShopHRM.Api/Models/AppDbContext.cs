using System;

using BethanysPieShopHRM.Shared;

using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopHRM.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<CountryModel> Countries { get; set; }
        public DbSet<JobCategoryModel> JobCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed categories
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { CountryId = 1, Name = "Belgium" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { CountryId = 2, Name = "Germany" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { CountryId = 3, Name = "Netherlands" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { CountryId = 4, Name = "USA" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { CountryId = 5, Name = "Japan" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { CountryId = 6, Name = "China" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { CountryId = 7, Name = "UK" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { CountryId = 8, Name = "France" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { CountryId = 9, Name = "Brazil" });

            modelBuilder.Entity<JobCategoryModel>().HasData(new JobCategoryModel() { JobCategoryId = 1, JobCategoryName = "Pie research" });
            modelBuilder.Entity<JobCategoryModel>().HasData(new JobCategoryModel() { JobCategoryId = 2, JobCategoryName = "Sales" });
            modelBuilder.Entity<JobCategoryModel>().HasData(new JobCategoryModel() { JobCategoryId = 3, JobCategoryName = "Management" });
            modelBuilder.Entity<JobCategoryModel>().HasData(new JobCategoryModel() { JobCategoryId = 4, JobCategoryName = "Store staff" });
            modelBuilder.Entity<JobCategoryModel>().HasData(new JobCategoryModel() { JobCategoryId = 5, JobCategoryName = "Finance" });
            modelBuilder.Entity<JobCategoryModel>().HasData(new JobCategoryModel() { JobCategoryId = 6, JobCategoryName = "QA" });
            modelBuilder.Entity<JobCategoryModel>().HasData(new JobCategoryModel() { JobCategoryId = 7, JobCategoryName = "IT" });
            modelBuilder.Entity<JobCategoryModel>().HasData(new JobCategoryModel() { JobCategoryId = 8, JobCategoryName = "Cleaning" });
            modelBuilder.Entity<JobCategoryModel>().HasData(new JobCategoryModel() { JobCategoryId = 9, JobCategoryName = "Bakery" });

            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel
            {
                EmployeeId = 1,
                CountryId = 1,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1979, 1, 16),
                City = "Brussels",
                Email = "bethany@bethanyspieshop.com",
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
                JoinedDate = new DateTime(2015, 3, 1),
                Latitude = 50.8503,
                Longitude = 4.3517
            });

            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel
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
                JoinedDate = new DateTime(2017, 12, 24),
                Latitude = 50.8503,
                Longitude = 4.3517
            });
        }
    }
}