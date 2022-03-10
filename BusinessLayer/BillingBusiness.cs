using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BillingBusiness
    {
        public void SaveBillData(Billing billing)
        {
            BillingData billingData = new BillingData();
            billingData.SaveBillData(billing);
        }

        public void SaveCustomerData(CustomerInfo customerInfo)
        {
            BillingData customerData = new BillingData();
            customerData.SaveCustomer(customerInfo);
        }

        public int GetAutoIncCusB()
        {
            BillingData billingDataInc = new BillingData();
            return billingDataInc.GetAutoIncCusID();
        }

        public int GetAutoIncOrderB()
        {
            BillingData billingDataInc = new BillingData();
            return billingDataInc.GetAutoIncOrderID();
        }
        public List<Billing> GetBillB()
        {
            BillingData billingData = new BillingData();
            return billingData.GetBillData();
        }

        public void DeleteBillB(Billing billing)
        {
            BillingData billingData = new BillingData();
            billingData.DeleteBillData(billing);
        }
    }
}
