using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DRCDRest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

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
        [Route("Artist/{_substring}")]
        [ProducesResponseType(200)] //når der er en CD med substring
        [ProducesResponseType(404)] //når substring ikke matcher nogen artist 
        public IActionResult GetArtistSub(String _substring)
        {
            if (cder.Exists( c => c.Artist.ToLower().Contains(_substring.ToLower())))
            {
                return Ok(cder.FindAll(c => c.Artist.ToLower().Contains(_substring.ToLower())));
            }
            return NotFound($"der er ikke nogen CDér med artist {_substring}");
        }

        [HttpGet]
        [Route("Title/{_substring}")]
        [ProducesResponseType (200)] //når der er en CD med substring
        [ProducesResponseType (404)] //når substring ikke matcher nogen tittel

        public IActionResult GetFromTitle(string _substring) //brug substring til at søge efter CDér med substring i titlen.
        {
            if (cder.Exists(c => c.Title.ToLower().Contains(_substring.ToLower()))) //se om titel (alt med småt) matcher substring (alt med småt)
            {
                return Ok(cder.FindAll(c => c.Title.ToLower().Contains(_substring.ToLower())));
            }
            return NotFound($"der er ikke nogen CDér med titel {_substring}");
        }

        [HttpGet]
        [Route("Duration/{_subint}")]
        [ProducesResponseType(200)] //når der er en CD med substring
        [ProducesResponseType(404)] //når søgning ikke matcher nogen duration

        public IActionResult GetFromDuration(double _subint) //brug subint til at søge i duration værdier
        {
            if (cder.Exists(c => c.Duration == _subint)) //se om duration matcher søgning
            {
                return Ok(cder.FindAll(c => c.Duration == _subint)); //returner alle Cder med indtastet duration 
            }
            return NotFound($"der er ikke nogen CDér med duration: {_subint}"); //returner søgeværdi i fejlkode ved 404 not found
        }

        [HttpGet]
        [Route("Publication/{_subint}")]
        [ProducesResponseType(200)] //når der er en CD med substring
        [ProducesResponseType(404)] //når søgning ikke matcher noget publication år

        public IActionResult GetFromPublication(int _subint) //brug subint til at søge i publication værdier
        {
            if (cder.Exists(c => c.YearOfPublication == _subint)) //se om publication matcher søgning
            {
                return Ok(cder.FindAll(c => c.YearOfPublication == _subint)); //returner alle Cder med indtastet publication år 
            }
            return NotFound($"der er ikke nogen CDér udgivet i år: {_subint}"); //returner søgeværdi i fejlkode ved 404 not found
        }

        [HttpGet]
        [Route("Tracks/{_subint}")]
        [ProducesResponseType(200)] //når der er en CD med substring
        [ProducesResponseType(404)] //når søgning ikke matcher nogen NumberOfTracks værdi

        public IActionResult GetFromTracks(int _subint) //brug subint til at søge i NumberOfTracks værdier
        {
            if (cder.Exists(c => c.NumberOfTracks == _subint)) //se om NumberOfTracks matcher søgning
            {
                return Ok(cder.FindAll(c => c.NumberOfTracks == _subint)); //returner alle Cder med indtastet nummer af tracks år 
            }
            return NotFound($"der er ikke nogen CDér med: {_subint} numre på."); //returner søgeværdi i fejlkode ved 404 not found
        }

        [HttpGet]
        [Route("Time/Search")]
        [ProducesResponseType(200)] //når der er en CD med duration der matcher søgning
        [ProducesResponseType(404)] //når der ikke er en CD med duration der matcher søgning

        public IActionResult GetFromDurationQuerry([FromQuery] QuerryItemDuration item) //brug querry resultater til at søge i Duration værdier.
        {
            if (cder.Exists(c => c.Duration > item.DurationLower && c.Duration < item.DurationHigher)) //se om der er en CD med en duration højere end DurationLower og lavere end DurationHigher.
            {
                return Ok(cder.FindAll(c => c.Duration > item.DurationLower && c.Duration < item.DurationHigher)); //returner alle Cder med indtastet nummer af tracks år 
            }
            return NotFound($"der er ikke nogen CDér med duration højere end: {item.DurationLower}, og lavere end: {item.DurationHigher}."); //returner søgeværdi i fejlkode ved 404 not found
        }

        [HttpGet]
        [Route("Number/Search")]
        [ProducesResponseType(200)] 
        [ProducesResponseType(404)] 

        public IActionResult GetFromTracksQuerry([FromQuery] QuerryItemTracks item) 
        {
            if (cder.Exists(c => c.NumberOfTracks > item.TracksLower && c.NumberOfTracks < item.TracksHigher)) 
            {
                return Ok(cder.FindAll(c => c.NumberOfTracks > item.TracksLower && c.NumberOfTracks < item.TracksHigher)); 
            }
            return NotFound($"der er ikke nogen CDér med Antal tracks mellem: {item.TracksLower}, og: {item.TracksHigher}."); 
        }

        [HttpGet]
        [Route("Year/Search")]
        [ProducesResponseType(200)] 
        [ProducesResponseType(404)] 

        public IActionResult GetFromYearQuerry([FromQuery] QuerryItemYear item) 
        {
            if (cder.Exists(c => c.YearOfPublication > item.YearLower && c.YearOfPublication < item.YearHigher)) 
            {
                return Ok(cder.FindAll(c => c.YearOfPublication > item.YearLower && c.YearOfPublication < item.YearHigher)); 
            }
            return NotFound($"der er ikke nogen CDér med udgivelsesår mellem: {item.YearLower}, og: {item.YearHigher}.");
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
