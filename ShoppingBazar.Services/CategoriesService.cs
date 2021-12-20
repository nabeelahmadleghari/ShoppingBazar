using soppingbazar.Entities;
using ShoppingBazar.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBazar.Services
{
    public class CategoriesService
    {

        
        public category GetCategory(int ID) //category id k through get krne k liay
        {
            using (var context = new SBcontext())
            {
                return context.Categories.Find(ID);
            }
        }

        //*************************************

        public List<category> GetCategories() //database se list of categories dekhne k liay
        {
            using (var context = new SBcontext())
            {
                return context.Categories.ToList();
            }
        }

        //*************************************************
        public void SaveCategory(category Category) //Database me categories add krne k liay
        {
            using (var context = new SBcontext())
            {
                context.Categories.Add(Category);
                context.SaveChanges();
            }


        }


        public void UpdateCategory(category Category) //Database me categories update krne k liay
        {
            using (var context = new SBcontext())
            {
                context.Entry(Category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }


        }




        public void DeleteCategory(int ID) //Database me categories Delete krne k liay
        {
            using (var context = new SBcontext())
            {
                var Category = context.Categories.Find(ID);
                context.Entry(Category).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }


        }
    }
}
