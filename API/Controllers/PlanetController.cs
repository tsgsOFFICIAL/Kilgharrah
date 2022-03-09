using API.DAL; // API is our project.
using Microsoft.AspNetCore.Mvc; // AspNetCore is a web framework.

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")] // Route is for guide you in the web-browser.
    [ApiController] // ApiController tells a program, that the class is not an object, but a controller.
    public class PlanetController : ControllerBase
    {
        DBManager man = new DBManager();

        // GET: api/Planet
        [HttpGet]
        public string Get()
        {
            return man.GetPlanets();
        }

        /*
        // GET: api/<PlanetController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PlanetController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlanetController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PlanetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlanetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
