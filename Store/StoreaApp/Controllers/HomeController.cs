using Microsoft.AspNetCore.Mvc;

namespace StoreaApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "hello raotung";
        //}
    }
}
                                        