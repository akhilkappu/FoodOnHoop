using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Category
    {
        public int MenuID { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; } 
    }
}
