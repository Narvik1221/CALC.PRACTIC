using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using WebCalc.Models;
using WindowsFormsApp2;
namespace WebCalc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]{
            new SelectListItem() { Value = "Multiplic", Text ="Умножение" },
           new SelectListItem() { Value = "Addition", Text ="Сложение" },
            new SelectListItem() { Value = "substract", Text ="Разность" },
            new SelectListItem() { Value = "Division", Text ="Деление" }
        };


            return View();
        }



    [HttpPost]
    public ActionResult Index(
        double firstNumber,
        double secondNumber,
        string operation)
        {
        ITwoArgumentsCalculator calculator =
        TwoArgFactory.CreateCalculator(operation);
        double result = calculator.Calculate(firstNumber, secondNumber);
         ViewBag.Result = result;

         ViewBag.Operation = new SelectListItem[]{
            new SelectListItem() { Value = "Multiplic", Text ="Умножение" },
           new SelectListItem() { Value = "Addition", Text ="Сложение" },
            new SelectListItem() { Value = "substract", Text ="Разность" },
            new SelectListItem() { Value = "Division", Text ="Деление" }
        };


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