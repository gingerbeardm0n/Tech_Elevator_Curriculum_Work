using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorldServer.APIServices;
using WorldServer.DAL;
using WorldServer.Models;

namespace WorldServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private ICountryDAO countryDAO;

        public CountryController(ICountryDAO countryDAO)
        {
            this.countryDAO = countryDAO;
        }

        [AllowAnonymous]
        [HttpGet]
        public List<Country> GetCountries()
        {
            List<Country> countries = countryDAO.GetCountries();
            return countries;
        }

        [Authorize]
        [HttpGet("{countryCode}")]
        public CountryDetail GetCountry(string countryCode)
        {
            Country country = countryDAO.GetCountry(countryCode);

            CountryDetail countryDetail = new CountryDetail(country);

            //get news
            NewsAPIService newsAPIService = new NewsAPIService();
            countryDetail = newsAPIService.GetCountry(countryDetail);

            return countryDetail;
        }
    }
}