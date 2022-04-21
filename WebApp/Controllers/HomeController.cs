using BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(List<Medewerker> meds)
        {
            ///
            /// meds is full list or filtered list of medewerkers
            /// The index displayed deze list
            /// When filtered go to this page and add the filtered medewerkers list to the function
            /// 

            #region this is to test the filter functions
            MedewerkerContainer medewerkerContainer = new MedewerkerContainer();
            var mds = medewerkerContainer.FilterMedewerkersFunc(medewerkerContainer.GetAllMedewerkers(), FilterOn.Functie, "e");
            ViewBag.medewerkers = mds;
            #endregion
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
