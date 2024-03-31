using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Test_Product.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        public IActionResult Index()
        {
            //yeni tanımladığımız metot kullanıyoruz
            var values = customerManager.GetCustomerListWithJop();
            return View(values);
        }
        [HttpGet]
        public IActionResult CustomerAdd() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CustomerAdd(Customer p) 
        {
            CustomerValidator validationRules = new CustomerValidator();
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
