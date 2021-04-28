using apiangular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace apiangular.Controllers
{
    
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {

        countryEntities1 DB = new countryEntities1();
        [HttpGet]  

        [Route("getSearchedCountry/{keyword}")]  
        public IEnumerable<tbl_Countries> getSearchedCountry(string keyword)
        {  
           var countryResult = DB.searchCountryByName(keyword).ToList();  
                return countryResult;  
        }
}
}
