using System.Collections.Generic;
using System.Linq;

using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.Api.Models
{
    public class JobCategoryRepository : IJobCategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public JobCategoryRepository(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public IEnumerable<JobCategoryModel> GetAllJobCategories() => _appDbContext.JobCategories;

        public JobCategoryModel GetJobCategoryById(int jobCategoryId) => _appDbContext.JobCategories.FirstOrDefault(_ => _.JobCategoryId == jobCategoryId);
    }
}