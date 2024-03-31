using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Test_Product.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        CustomerValidator validationRules = new CustomerValidator();
        JopManager jopManager = new JopManager(new EfJopDal());
        public IActionResult Index()
        {
            //yeni tanımladığımız metot kullanıyoruz
            var values = customerManager.GetCustomerListWithJop();
            return View(values);
        }
        [HttpGet]
        public IActionResult CustomerAdd()
        {
          
            List<SelectListItem> values = (from x in jopManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JopID.ToString()
                                           }).ToList();

            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult CustomerAdd(Customer p)
        {

            var result = validationRules.Validate(p);
            if (result.IsValid)
            {
                customerManager.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult CustomerDelete(int id)
        {
            var values = customerManager.TGetById(id);
            customerManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CustomerUpdate(int id)
        {
            var value = customerManager.TGetById(id);
            List<SelectListItem> values = (from x in jopManager.TGetList()
                                           select new SelectListItem { 
                                            Text = x.Name,
                                            Value = x.JopID.ToString()
                                           
                                           }).ToList();
            ViewBag.u = values;
            return View(value);
        }
        [HttpPost]
        public IActionResult CustomerUpdate(Customer p)
        {

            customerManager.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
