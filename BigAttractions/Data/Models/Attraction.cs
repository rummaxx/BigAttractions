using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigAttractions.Data.Models
{
    public class Attraction
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDesc { set; get; }

        public string longDesc { set; get; }

        public string img { set; get; }

        public String linkGoogle { set; get; }

        public bool isFavourite { set; get; }

        public virtual City city { set; get; }


    }
}
