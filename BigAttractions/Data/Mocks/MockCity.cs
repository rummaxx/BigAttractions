using BigAttractions.Data.interfaces;
using BigAttractions.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigAttractions.Data.Mocks
{
    public class MockCity : ICities
    {
        public IEnumerable<City> AllCities
        {
            get
            {
                return new List<City>
                {
                    new City{countryName = "Россия",desc = "Достопримечательности России привлекают в страну, ставшей правопреемником СССР, " +
                    "самой мощной и огромной державы XX столетия, десятки миллионов туристов. Гости страны приезжают сюда, " +
                    "стремясь посетить как можно больше красивых мест. Разумеется, одной поездки для осмотра всех их недостаточно."},
                    new City{countryName = "Беларусь",desc = "Беларусь – это небольшая страна в сердце Европы и ближайший, дружественный сосед России. " +
                    "Здесь нет изобилия архитектурных памятников старины, они разрушены безжалостным военным временем. Но те, что сохранились," +
                    " являются жемчужинами республики и трепетно оберегаются. Беларусь – край лесов, озер, зубров и аистов. Она останется в сердце чистыми городами," +
                    " уютными деревнями, неповторимой заповедной природой, старинными местами, театрами и музеями."}
                };
            }
        }
    }
}
