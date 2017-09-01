using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePersonApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CorePersonApi.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        List<Person> people = People.GetPeople();

        // GET api/<controller>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return people;
        }
    }
}
