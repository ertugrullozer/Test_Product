using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Test_Product.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager= new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var values= _categoryManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CategorAdd() 
        { 
        
            return View();
        }
        [HttpPost]
        public IActionResult CategorAdd(Category p) 
        {
            _categoryManager.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult CategorDelete(int id) 
        {
            var values = _categoryManager.TGetById(id);
            _categoryManager.TDelete(values);
            return RedirectToAction("Index"); 
        }
        [HttpGet]
        public IActionResult CategoryUpdate(int id) 
        {
            var values = _categoryManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category p)
        {
            _categoryManager.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
