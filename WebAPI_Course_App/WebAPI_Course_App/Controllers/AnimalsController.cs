using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Course_App.Models;

namespace WebAPI_Course_App.Controllers
{
    public class AnimalsController : ApiController
    {
        // GET api/<controller>
        // public IEnumerable<Animal> Get() // Example: original code
        public IEnumerable<Animal> GetAllAnimals() // Example 2: method name is customized
        {
            //return new string[] { "value1", "value2" };
            return AnimalDB.Animals;
        }

        public IEnumerable<Animal> GetSomeAnimals()
        {
            return AnimalDB.Animals.Where(a => a.NumberOfLegs == 4);
        }

        // GET api/<controller>/5
        public Animal Get(string id)
        {
            return AnimalDB.Animals.Single(a => a.Species == id);
        }

        // POST api/<controller>
        public void Post([FromBody]Animal value)
        {
            AnimalDB.Animals.Add(value);
        }

        // PUT api/<controller>/5
        public void Put(string id, [FromBody]Animal value)
        {
            AnimalDB.Animals.RemoveAll(a => a.Species == id);
            AnimalDB.Animals.Add(value);
        }

        // DELETE api/<controller>/5
        public void Delete(string id)
        {
            AnimalDB.Animals.RemoveAll(a => a.Species == id);
        }
    }
}