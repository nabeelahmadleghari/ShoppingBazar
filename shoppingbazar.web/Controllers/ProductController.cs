using ShoppingBazar.Services;
using soppingbazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoppingbazar.web.Controllers
{
    public class ProductController : Controller
    {
        ProductService serviceproduct = new ProductService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ProductTable(string search)
        {
            var products = serviceproduct.GetProducts();

            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.Name.ToLower().Contains(search.ToLower())).ToList();
            }
           
            return PartialView(products);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(product Product)
        {

            serviceproduct.SaveProduct(Product);
            return RedirectToAction("ProductTable");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var product = serviceproduct.GetProducts(ID);
            return PartialView(product);
        }

        [HttpPost]
        public ActionResult Edit(product Product)
        {

            serviceproduct.UpdateProduct(Product);
            return RedirectToAction("ProductTable");
        }


        [HttpPost]
        public ActionResult Delete(int ID)
        {

            serviceproduct.DeleteProduct(ID);
            return RedirectToAction("ProductTable");
        }
    }
}