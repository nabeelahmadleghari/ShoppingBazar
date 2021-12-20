using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soppingbazar.Entities
{
    public class product : BaseEntity
    {
        public category Category { get; set; }
        
        public decimal Price { get; set; }

    }
}
