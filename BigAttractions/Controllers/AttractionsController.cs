using BigAttractions.Data.interfaces;
using BigAttractions.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigAttractions.Controllers
{
    public class AttractionsController : Controller
    {
        private readonly IAttractions _allAttractions;
        private readonly ICities _allCities;
        public AttractionsController(IAttractions iAttractions, ICities iCities)
        {
            _allAttractions = iAttractions;
            _allCities = iCities;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с аттракционами";
            AttractionsListViewModel obj = new AttractionsListViewModel();
            obj.allAttractions = _allAttractions.Attractions;
            obj.currCity = "";
            return View(obj);
        }

    }
}
