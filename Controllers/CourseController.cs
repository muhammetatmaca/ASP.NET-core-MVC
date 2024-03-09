//using AspNetCore;
using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
        [HttpGet]
        public IActionResult Apply() 
        {
            return View();
        }

        [HttpPost]
     //   [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model)
        {
            if (Repository.Applications.Any(c=>c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("", "zaten bir kaydın var");
            }

            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Feedback", model);
                
            }
            return View();
            
        }


    }
}
