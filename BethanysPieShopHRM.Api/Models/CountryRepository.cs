using System.Collections.Generic;
using System.Linq;

using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.Api.Models
{
    public class CountryRepository : ICountryRepository
    {
        // replace this with a data access layer for Dapper use. (I.e. ISqlDataAccess _sqlDataAccess) modeled after AppContext's properties.
        private readonly AppDbContext _appDbContext;

        public CountryRepository(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public IEnumerable<CountryModel> GetAllCountries() => _appDbContext.Countries;

        public CountryModel GetCountryById(int countryId) => _appDbContext.Countries.FirstOrDefault(_ => _.CountryId == countryId);
    }
}