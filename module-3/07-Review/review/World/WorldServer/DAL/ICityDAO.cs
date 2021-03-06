﻿using System;
using System.Collections.Generic;
using System.Text;
using WorldServer.Models;

namespace WorldServer.DAL
{
    public interface ICityDAO
    {
        /// <summary>
        /// Gets all cities provided a country code.
        /// </summary>
        /// <param name="countryCode">The country code to search for.</param>
        /// <returns></returns>
        List<City> GetCitiesByCountryCode(string countryCode);

        /// <summary>
        /// Adds a new city.
        /// </summary>
        /// <param name="city">The city to add.</param>
        bool AddCity(City city);
    }
}
