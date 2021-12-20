using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soppingbazar.Entities
{
    public class category:BaseEntity
    {
       
        public List<product> Products { get; set; }
    }
}
