using soppingbazar.Entities;
using ShoppingBazar.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBazar.Services
{
    public class ProductService
    {

        
        public product GetProducts(int ID) //category id k through get krne k liay
        {
            using (var context = new SBcontext())
            {
                return context.Products.Find(ID);
            }
        }

        //*************************************

        public List<product> GetProducts() //database se list of categories dekhne k liay
        {
            using (var context = new SBcontext())
            {
                return context.Products.ToList();
            }
        }

        //*************************************************
        public void SaveProduct(product Product) //Database me categories add krne k liay
        {
            using (var context = new SBcontext())
            {
                context.Products.Add(Product);
                context.SaveChanges();
            }


        }


        public void UpdateProduct(product Product) //Database me categories update krne k liay
        {
            using (var context = new SBcontext())
            {
                context.Entry(Product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }


        }




        public void DeleteCategory(int ID) //Database me categories Delete krne k liay
        {
            using (var context = new SBcontext())
            {
                var Product = context.Products.Find(ID);
                context.Entry(Product).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }


        }
    }
}
