using System.Diagnostics;
using AspCoreWebAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using TagHelpersDemo.Models;

namespace AspCoreWebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Index(Employee e)
        {
            return "Name is: "+e.Name+" Age is:  "+e.Age+" Salary is : "+ e.Salary;
        }
        public string Details(int id, string name)
        {
            return "Id is : "+ id + " Name is : "+ name;
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
