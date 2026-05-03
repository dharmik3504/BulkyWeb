using BulkyWeb;
using BulkyWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class CategoryController : Controller
    {
        private readonly  ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db=db;
        }
        
        // GET: CategoryController.cs
        public ActionResult Index()
        {
           List<Category> objCategoryList= _db.Categories.ToList();
            return View();
        }

    }
}
