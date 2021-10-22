using BigAttractions.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigAttractions.Data.interfaces
{
    public interface ICities
    {
        IEnumerable<City> AllCities { get; }

    }
}
