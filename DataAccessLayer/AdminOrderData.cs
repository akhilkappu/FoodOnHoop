using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AdminOrderData
    {
        public List<AdminOrder> AdminOrdersdet()
        {
            List<AdminOrder> adminOrderslist = new List<AdminOrder>();
            FoodonHoopDBEntities foodonHoopDBEntities = new FoodonHoopDBEntities();
            var result = (from adminorder in foodonHoopDBEntities.tblOrders
                          join cust in foodonHoopDBEntities.tblCustomers on adminorder.CustomerID equals cust.CustomerID
                          join emp in foodonHoopDBEntities.tblEmployees on adminorder.EmployeeID equals emp.EmployeeID
                          join menu in foodonHoopDBEntities.tblMenus on adminorder.MenuID equals menu.MenuID
                          select new
                          {
                              adminorder.OrderID,
                              cust.CustomerName,
                              menu.Item,
                              emp.EmployeeFullName,
                              adminorder.Date,
                              adminorder.ItemQuantity,
                              adminorder.ItemTotalPrice
                          }).ToList();

            foreach (var Item in result)
            {
                AdminOrder adminOrder = new AdminOrder();
                adminOrder.OrderID = Item.OrderID;
                adminOrder.CustomerName = Item.CustomerName;
                adminOrder.ItemName = Item.Item;
                adminOrder.EmployeeName = Item.EmployeeFullName;
                adminOrder.Date = Item.Date;
                adminOrder.ItemQuantity = Item.ItemQuantity;
                adminOrder.TotalPrice = Item.ItemTotalPrice;
                adminOrderslist.Add(adminOrder);

            }
            return adminOrderslist;
        }
    }
}

