using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRCDRest.DButil
{
    public class Manager
    {
        private static List<CD> cder = new List<CD>()
        {
            new CD(1,"xx","jon",10.0, 5, 2000),
            new CD(2,"xy","Chris",10.5, 7, 2032),
            new CD(3,"xxx","Eva",13.0, 2, 2120),
            new CD(4,"xxxx","jon",8.0, 1, 2003),
            new CD(5,"xxxxx","Urf",17.0, 6, 2043),
        };

         public IEnumerable<CD> GetAll()
         {
             return cder;

         }

         public CD GetArtist()
         {
             if (cder.Exists(c => c.Artist.ToLower().Contains(_substring.ToLower())))
             {
                 return Ok(cder.FindAll(c => c.Artist.ToLower().Contains(_substring.ToLower())));
             }
             return NotFound($"der er ikke nogen CDér med artist {_substring}");
        }
    }
}
