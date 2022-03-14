using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BillingData
    {
        public int i { get; set; }
        FoodonHoopDBEntities dBEntities = new FoodonHoopDBEntities();
        public void SaveBillData(Billing billing)
        {
            try
            {
                tblOrder tblOrderBill = new tblOrder();
                tblEmployee tblEmployeeBill = new tblEmployee();
                tblCustomer tblCustomerBill = new tblCustomer();
                tblOrderBill.EmployeeID = billing.EmployeeID;
                tblOrderBill.CustomerID = (int)billing.CustomerID;
                tblOrderBill.OrderID = billing.OrderID;
                tblOrderBill.MenuID = billing.MenuID;
                tblOrderBill.ItemName = billing.ItemName;

                tblOrderBill.Date = billing.Date;
                tblOrderBill.ItemQuantity = billing.ItemQuantity;
                tblOrderBill.ItemTotalPrice = billing.ItemTotalPrice;

                tblOrderBill.FoodStatus = billing.FoodStatus;
                tblOrderBill.PaymentStatus = billing.PaymentStatus;

                dBEntities.tblOrders.Add(tblOrderBill);
                dBEntities.SaveChanges();

            }
            catch (Exception exx)
            {
                throw exx;
            }

        }
        public void SaveCustomer(CustomerInfo cuObj)
        {
            tblCustomer customer = new tblCustomer();
            customer.CustomerID = cuObj.CustomerID;
            customer.CustomerName = cuObj.CustomerName;
            customer.ContactNumber = cuObj.ContactNumber;

            dBEntities.tblCustomers.Add(customer);
            dBEntities.SaveChanges();
        }

        public List<Billing> GetBillData()
        {
            List<Billing> adminOrderslist = new List<Billing>();
            FoodonHoopDBEntities foodonHoopDBEntities = new FoodonHoopDBEntities();

            var indicators = foodonHoopDBEntities.Set<tblOrder>();

            var query = indicators.Where(i => i.CustomerID >= indicators.Max(i2 => (int?)i2.CustomerID));
            foreach (var Item in query)
            {
                Billing adminOrder = new Billing();
                adminOrder.OrderID = Item.OrderID;
                adminOrder.ItemQuantity = Item.ItemQuantity;
                adminOrder.ItemTotalPrice = Item.ItemTotalPrice;
                adminOrder.ItemName = Item.ItemName;

                adminOrderslist.Add(adminOrder);

            }
            return adminOrderslist;
        }

        public void DeleteBillData(Billing billing)
        {
            try
            {
                FoodonHoopDBEntities objEntities = new FoodonHoopDBEntities();
                var result = from obj in objEntities.tblOrders
                             where obj.OrderID == billing.OrderID
                             select obj;

                foreach (var entity in result)
                {
                    objEntities.tblOrders.Remove(entity);
                }
                objEntities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<CustomerInfo> GetCustomerData()
        {
            FoodonHoopDBEntities dBEntities = new FoodonHoopDBEntities();
            List<CustomerInfo> customerList = new List<CustomerInfo>();
            var indicators = dBEntities.Set<tblCustomer>();

            var cus = indicators.Where(i => i.CustomerID >= indicators.Max(i2 => (int?)i2.CustomerID));
            //var cus = from cusObj in dBEntities.tblCustomers
            //          select cusObj;

            foreach (var customer in cus)
            {
                CustomerInfo customerInfo = new CustomerInfo();
                customerInfo.CustomerID = customer.CustomerID;
                customerInfo.CustomerName = customer.CustomerName;
                customerList.Add(customerInfo);
            }
            return customerList;
        }
        //public List<LoginData> GetLoginDatas()
        //{ Lis<LoginData> list = new Lis<LoginData>();
        //FoodonHoopDBEntities dBEntities = new FoodonHoopDBEntities();
        //List<CustomerInfo> customerList = new List<CustomerInfo>();SqlConnection scn = new SqlConnection();
        //scn.ConnectionString = @"data source = LAPTOP-IJI0NIKR; database = FoodonHoopDB; integrated security = SSPI";
        //    SqlCommand scmd = new SqlCommand("select count (*) as cnt from tblLoginData where UserName=@UserName and Password=@Password", scn);
        //scmd.Parameters.Clear();
        //    scmd.Parameters.AddWithValue("@UserName", txtusername.Text);
        //    scmd.Parameters.AddWithValue("@Password", pwpassword.Password);
        //    scn.Open();

        //}
        //public void BillingUpdate(Billing billing)
        //{
        //    try
        //    {
        //        FoodonHoopDBEntities foodonHoopDBEntities = new FoodonHoopDBEntities();
        //        var query = from foh in foodonHoopDBEntities.tblOrders
        //                    where foh.OrderID == billing.OrderID
        //                    select foh;


        //        foreach (var order in query)
        //        {
        //            order.OrderID = billing.OrderID;
        //            order.CustomerID = billing.CustomerID;
        //            order.MenuID = billing.MenuID;
        //            order.EmployeeID = billing.EmployeeID;
        //            order.Date = billing.Date;
        //            order.ItemQuantity = billing.ItemQuantity;
        //            order.ItemTotalPrice = billing.ItemTotalPrice;
        //            order.PaymentStatus = billing.PaymentStatus;
        //            order.FoodStatus = billing.FoodStatus;
        //        }
        //        foodonHoopDBEntities.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //var i = (from d in dBEntities.tblCustomers
        //         select d.CustomerID).Max();

        public int GetAutoIncOrderID()
        {
            AutoInc auto = new AutoInc();


            var i = (from d in dBEntities.tblOrders
                     select d.OrderID).Max();

            return i + 1;
        }

        public int GetAutoIncCusID()
        {
            AutoInc auto = new AutoInc();


            var i = (from d in dBEntities.tblCustomers
                     select d.CustomerID).Max();

            return i + 1;
        }
        public int GetAutoIncCusIDBill()
        {
            AutoInc auto = new AutoInc();


            var i = (from d in dBEntities.tblCustomers
                     select d.CustomerID).Max();
            return i;
        }
    }
}
