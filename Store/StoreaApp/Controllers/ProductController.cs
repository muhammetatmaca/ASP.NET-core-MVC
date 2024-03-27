using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreaApp.Models;

namespace StoreaApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly RepositoryContexts _contexts;

        public ProductController(RepositoryContexts contexts)
        {
            _contexts = contexts;
        
        }

        //public IEnumerable<Product> Index() 
        //{
            

        //    //var context= new RepositoryContexts(
        //    //    new DbContextOptionsBuilder<RepositoryContexts>()
        //    //    .UseSqlServer("Data Source=MUHAMMET\\MAMİSQL;Integrated Security=True;Initial Catalog=fansaabi32;Trust Server Certificate=True;")
        //    //    .Options
                
        //    //    );
        //    return _contexts.Products ?? Enumerable.Empty<Product>();
            
           
        //}

        public IActionResult Index()
        { 
            var model=_contexts.Products.ToList();
            return View(model);
        }


        public IActionResult Get(int id)
        {
            Product product = _contexts.Products.First(p => p.ProductId == id);
            return View(product);
        }

    }
}
