using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigAttractions.Data.Models
{
    public class City
    {

        public int id { set; get; }
        public String countryName { set; get; }
        public String desc { set; get; }
        public List<Attraction> Attractions { set; get; }

    }
}
