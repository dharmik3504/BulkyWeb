using BulkyWeb;
using Bulky.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Bulky.Models;

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
        public IActionResult Index()
        {
           List<Category> objCategoryList= _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            // if(category.Name == category.DisplayOrder)
            // {
            //     ModelState.AddModelError("name","Can be same ");
            // }
            if (ModelState.IsValid)
            {
                
            _db.Categories.Add(category);
            _db.SaveChanges();
             return RedirectToAction("Index","Category");
            }
            return View();
        }

    }
}
