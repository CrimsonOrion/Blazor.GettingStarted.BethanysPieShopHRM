using System.Collections.Generic;

using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategoryModel> GetAllJobCategories();
        JobCategoryModel GetJobCategoryById(int jobCategoryId);
    }
}