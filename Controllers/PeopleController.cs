using System.Collections.Generic;
using System.Linq;
using CorePersonApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CorePersonApi.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private IPeopleProvider provider;

        public PeopleController(IPeopleProvider peopleProvider)
        {
            provider = peopleProvider;
        }

        // GET api/<controller>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return provider.GetPeople();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return provider.GetPeople().FirstOrDefault(p => p.Id == id);
        }
    }
}
