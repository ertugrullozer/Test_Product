﻿using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Test_Product.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {

                return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {   
            ProductValidator validationRules = new ProductValidator();
            var result = validationRules.Validate(p);
            if (result.IsValid)
            {
                productManager.TInsert(p);
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
        public IActionResult DeleteProduct(int id)
        {
            var value = productManager.TGetById(id);
            productManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProduct(int id) 
        {
            var value = productManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product p) 
        {
            productManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
