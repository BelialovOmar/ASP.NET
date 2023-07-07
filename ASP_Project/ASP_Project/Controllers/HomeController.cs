using ASP_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_Project.Controllers
{
	public class HomeController: Controller
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
		public IActionResult Intro()
		{
			return View();
		}
		public IActionResult Scheme()
		{
            ViewBag.bagdata		 = "Data from Bag";
            ViewData["viewdata"] = "Data from ViewData";

            return View();
		}
		public IActionResult HW_URL()
		{
            return View();
		}
		public IActionResult Razor()
		{
            return View();
		}
		public IActionResult Model()
		{
			Models.Home.Model model = new()
			{
				Header = "Моделі",
				Tittle = "Передача моделі у представлення",
				Departments = new()
				{
                    "Department 1",
                    "Department 2",
                    "Department 3",
					"Department 4",
                    "Department 5"
                },

                Products = new()
				{
                    new() { Name = "Drill",      Price = 256.00 },
                    new() { Name = "TV",         Price = 500.00 },
                    new() { Name = "Headphones", Price = 150.00 },
                    new() { Name = "Phone",      Price = 400.00 },
                    new() { Name = "Mouse",      Price = 105.00 },
                    new() { Name = "Table",      Price = 500.00 },
                }
            };

            return View( model);
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