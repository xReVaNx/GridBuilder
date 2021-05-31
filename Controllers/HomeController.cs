using GridBuilder.Models;
using GridBuilder.lib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GridBuilder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        public ActionResult Action()
        {
            GridBuilder<Person> grid = new GridBuilder<Person>();
            grid.Name("grid")
                .Columns(columns =>
                {
                    columns.Bound(p => p.Firstname).Height("30px");
                    columns.Bound(p => p.Lastname);
                    columns.Bound(p => p.Company);
                    columns.Bound(p => p.ExperienceInYears);
                })
                .Pageable()
                .Filterable();



            return View();
        }
    }
}
