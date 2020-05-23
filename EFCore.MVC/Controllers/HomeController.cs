using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EFCore.MVC.Models;
using EFCore.Domain;

namespace EFCore.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly CountryRepository countryRepository;
        public HomeController(CountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }
        public IActionResult Index()
        {
            IEnumerable<Country> countries = this.countryRepository.GetCountries();
            ViewBag.Countries = countries;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
