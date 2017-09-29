using System.Collections.Generic;

namespace CorePersonApi.Models
{
    public interface IPeopleProvider
    {
        List<Person> GetPeople();
    }
}