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
            
        
                ViewBag.Operation1arg = new SelectListItem[]{
                new SelectListItem() { Value = "None", Text ="Функция 1 аргумента" },
                new SelectListItem() { Value = "Ln", Text ="Натуральный логарифм" },
                new SelectListItem() { Value = "Sqrt", Text ="Корень квадратная" },
                new SelectListItem() { Value = "Pow2", Text ="Квадрат числа" },
                new SelectListItem() { Value = "OneDiv", Text ="1/число" },
                new SelectListItem() { Value = "ATan", Text ="Atan" },
                new SelectListItem() { Value = "Tan", Text ="Тангенс" },
                new SelectListItem() { Value = "Sin", Text ="Синус" },
                new SelectListItem() { Value = "Cos", Text ="Косинус" }


        };
                ViewBag.Operation2arg = new SelectListItem[]{
            new SelectListItem() { Value = "None", Text ="Функция 2 аргументов" },
            new SelectListItem() { Value = "Multiplic", Text ="Умножение" },
           new SelectListItem() { Value = "Addition", Text ="Сложение" },
            new SelectListItem() { Value = "substract", Text ="Разность" },
            new SelectListItem() { Value = "Division", Text ="Деление" },
            new SelectListItem() { Value = "Pow", Text ="Возведение в степень" },
            new SelectListItem() { Value = "Sred", Text ="Среднее значение" },
            new SelectListItem() { Value = "AntiPow", Text ="Корень n степени" }
            };


                return View();
        }



    [HttpPost]
    public ActionResult Index(
        double firstNumber,
        double secondNumber,
        string operation2arg, string operation1arg)
        {
            ViewBag.Operation1arg = new SelectListItem[]{
                new SelectListItem() { Value = "None", Text ="Функция 1 аргумента" },
                new SelectListItem() { Value = "Ln", Text ="Натуральный логарифм" },
                new SelectListItem() { Value = "Sqrt", Text ="Корень квадратная" },
                new SelectListItem() { Value = "Pow2", Text ="Квадрат числа" },
                new SelectListItem() { Value = "OneDiv", Text ="1/число" },
                new SelectListItem() { Value = "ATan", Text ="Atan" },
                new SelectListItem() { Value = "Tan", Text ="Тангенс" },
                new SelectListItem() { Value = "Sin", Text ="Синус" },
                new SelectListItem() { Value = "Cos", Text ="Косинус" }


        };
            ViewBag.Operation2arg = new SelectListItem[]{
            new SelectListItem() { Value = "None", Text ="Функция 2 аргументов" },
            new SelectListItem() { Value = "Multiplic", Text ="Умножение" },
           new SelectListItem() { Value = "Addition", Text ="Сложение" },
            new SelectListItem() { Value = "substract", Text ="Разность" },
            new SelectListItem() { Value = "Division", Text ="Деление" },
            new SelectListItem() { Value = "Pow", Text ="Возведение в степень" },
            new SelectListItem() { Value = "Sred", Text ="Среднее значение" },
            new SelectListItem() { Value = "AntiPow", Text ="Корень n степени" }
            };
        ITwoArgumentsCalculator calculator2 =
        TwoArgFactory.CreateCalculator(operation2arg);
        IOneArgumentsCalculator calculator1 =
        OneArgFactory.CreateCalculator(operation1arg);
         
            
            double result = calculator2.Calculate(firstNumber, secondNumber);
            double result1 = calculator1.Calculate(firstNumber);


            ViewBag.Result = result;
            ViewBag.Result1 = result1;



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