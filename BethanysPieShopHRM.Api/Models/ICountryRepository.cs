using System.Collections.Generic;

using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.Api.Models
{
    public interface ICountryRepository
    {
        IEnumerable<CountryModel> GetAllCountries();
        CountryModel GetCountryById(int countryId);
    }
}