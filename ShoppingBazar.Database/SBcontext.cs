using soppingbazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBazar.Database
{
    class SBcontext:DbContext
    {

        public SBcontext() : base("ShoppingBazarConnection")
        {

        }
        public DbSet<category> Categories { get; set;  }
        public DbSet<product> Products { get; set; }
    }
}
