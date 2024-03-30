using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Test_Product.Controllers
{
    public class JopController : Controller
    {
        JopManager jopManager=new JopManager(new EfJopDal());
        public IActionResult Index()
        {
            var value = jopManager.TGetList();
            return View(value);
        }
        public IActionResult JopDelete(int id) 
        {
            var value = jopManager.TGetById(id);
            jopManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult JopAdd() 
        { 
            return View(); 
        }
        [HttpPost]
        public IActionResult JopAdd(Jop p)
        {
            jopManager.TInsert(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult JopUpdate(int id)
        {
            var value=jopManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult JopUpdate(Jop p)
        {
            jopManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
