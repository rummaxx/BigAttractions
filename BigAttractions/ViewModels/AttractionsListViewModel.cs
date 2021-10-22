using BigAttractions.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigAttractions.ViewModels
{
    public class AttractionsListViewModel
    {
        public IEnumerable<Attraction> allAttractions { get; set; }

        public string currCity { get; set; }
    }
}
