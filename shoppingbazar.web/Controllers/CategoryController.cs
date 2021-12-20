using ShoppingBazar.Services;
using soppingbazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoppingbazar.web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService categoryservice = new CategoriesService();


        [HttpGet]
        public ActionResult Index()
        {
            var categories = categoryservice.GetCategories();
            return View(categories);
        }




        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(category Category)
        {

            categoryservice.SaveCategory(Category);
            return RedirectToAction("Index");
        }

        //*****************************************
        [HttpGet]
        public ActionResult Edit(int ID) //list of category ko edit krne k liay
        {
            var category = categoryservice.GetCategory(ID);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(category Category)
        {

            categoryservice.UpdateCategory(Category);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(int ID) //list of category ko delete krne k liay
        {
            var category = categoryservice.GetCategory(ID);
            return View(category);
        }

        [HttpPost]
        public ActionResult Delete(category Category)
        {
             
            categoryservice.DeleteCategory(Category.ID);
            return RedirectToAction("Index");
        }
    }
}