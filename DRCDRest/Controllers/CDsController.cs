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
            new CD(1,"xx","jon",10.0, 5, 2000),
            new CD(2,"xy","Chris",10.5, 7, 2032),
            new CD(3,"xxx","Eva",13.0, 2, 2120),
            new CD(4,"xxxx","jon",8.0, 1, 2003),
            new CD(5,"xxxxx","Urf",17.0, 6, 2043),
        };

        // GET: api/<CDsController>
        [HttpGet]
        public IEnumerable<CD> GetAll()
        {
            //if (cder == null)
            //{
            //    throw new Exception();
            //}
            return cder;


        }
        // GET: api/CD/Artist/....
        [HttpGet]
        [Route("Artist/{substring}")]
        public IEnumerable<CD> GetArtistSub(String substring)
        {
            return cder.FindAll(c => c.Artist.Contains(substring));
        }

        // GET api/<CDsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<CDsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<CDsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<CDsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
