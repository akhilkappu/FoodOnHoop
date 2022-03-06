using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AdminOrder
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ItemName { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Date { get; set; }
        public int ItemQuantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
