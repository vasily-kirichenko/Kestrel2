using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kestrel2.Controllers
{
  public class Person
    {
        public readonly string Name;
        public readonly int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    [Route("/[controller]")]
    public class PersonController : Controller
    {
        // GET api/values
        //[HttpGet]
        //public string Get() => "value1";

        [HttpGet("{name}")]
        //[Authorize]
        public Person Get(string name) => new Person(name, 41);

        // POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
