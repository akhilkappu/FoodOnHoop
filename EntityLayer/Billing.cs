using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Billing
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int EmployeeID { get; set; }
        public int CategoryID { get; set; }
        public int MenuID { get; set; }
        private DateTime _dateBill = DateTime.Now;
        public DateTime Date
        {
            get { return _dateBill; }
            set { _dateBill = value; }
        }
        public int ItemQuantity { get; set; }
        //public decimal ItemPrice { get; set; }
        public decimal ItemTotalPrice { get; set; }
        public string PaymentStatus { get; set; }
        public string FoodStatus { get; set; }
        public string ItemName { get; set; }
        public EmployeeInfo EmployeeInfo { get; set; }
        public MenuInfo MenuInfo { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
    }

    public class EmployeeInfo
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
    }
    public class MenuInfo
    {
        public int MenuID { get; set; }
        public string ItemName { get; set; }
    }
    public class CustomerInfo
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public long ContactNumber { get; set; }
    }

    public class AutoInc
    {
        public int AutoIncOrderID { get; set; }
        public int AutoIncCustID { get; set; }
    }   
}
