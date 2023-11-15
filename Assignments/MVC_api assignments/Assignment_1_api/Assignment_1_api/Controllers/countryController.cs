using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assignment_1_api.Models;

namespace Assignment_1_api.Controllers
{
    public class countryController : ApiController
    {
        List<Country> countries = new List<Country>()
        {
            new Country{ID=1 , CountryName = "Argentina " , Capital="Buenos Aires"},
            new Country{ID=2 , CountryName = "Norway " , Capital="Buenos Oslo"},
            new Country{ID=3 , CountryName = "Portugal " , Capital="Lisbon"},
            new Country{ID=4 , CountryName = "Saudi Arabia" , Capital="Riyadh"}
        };
        //to display country we use get
        [HttpGet]
        public IHttpActionResult Getcountry()
        {
            return Ok(countries);
        }

        //to get a country with a specific id
        public IHttpActionResult Get(int id)
        {
            var country =  countries.FirstOrDefault(c => c.ID == id);
            return Ok(country);
        }

        //to insert a new country we use post
        [HttpPost]
        public IHttpActionResult Post([FromBody] Country country)
        {
            country.ID = countries.Count + 1;
            countries.Add(country);

            return Created(new Uri(Request.RequestUri + "/" + country.ID), country);
        }

        //to update a specifc id we us e put

        public IHttpActionResult Put(int id, [FromBody] Country country)
        {
            var existingCountry = countries.FirstOrDefault(c => c.ID == id);
            if (existingCountry == null)
                return NotFound();

            existingCountry.CountryName = country.CountryName;
            existingCountry.Capital = country.Capital;

            return Ok(existingCountry);
        }

        //to delete we use delete
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();

            countries.Remove(country);

            return Ok(country);
        }

    }
}
