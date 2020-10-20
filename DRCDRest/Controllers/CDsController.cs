using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DRCDRest.Controllers
{
    [Route("api/CD")]
    [ApiController]
    public class CDsController : ControllerBase
    {
        private static List<CD> cder = new List<CD>()
        {
            new CD(1,"xx","yy",10.0, 5, 2000),
            new CD(2,"x","y",10.5, 7, 2032),
            new CD(3,"xxx","yyy",13.0, 2, 2120),
            new CD(4,"xxxx","yyyy",8.0, 1, 2003),
            new CD(5,"xxxxx","yyyyy",17.0, 6, 2043),
        };

        // GET: api/<CDsController>
        [HttpGet]
        public IEnumerable<CD> Get()
        {
            return cder;
        }

        // GET api/<CDsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CDsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CDsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CDsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
