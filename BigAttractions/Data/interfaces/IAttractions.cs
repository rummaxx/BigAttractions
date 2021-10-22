using BigAttractions.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigAttractions.Data.interfaces
{
    public interface IAttractions
    {
        IEnumerable<Attraction> Attractions { get; }
        IEnumerable<Attraction> getFavouriteAttraction { get; set; }
        Attraction getObjectAttraction(int attractionId);
    }
}
