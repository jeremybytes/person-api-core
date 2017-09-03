using System.Collections.Generic;
using System.Linq;
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

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return People.GetPeople().FirstOrDefault(p => p.Id == id);
        }
    }
}
