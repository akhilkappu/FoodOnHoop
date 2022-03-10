using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FoodOnHoop.Views
{
    /// <summary>
    /// Interaction logic for CustomerBill.xaml
    /// </summary>
    public partial class CustomerBill : UserControl
    {
        public int CustInc { get; set; }
        public CustomerBill()
        {
            InitializeComponent();
        }
        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            BillingBusiness billingBusiness = new BillingBusiness();
            Billing billing = new Billing();
            CustInc = billingBusiness.GetAutoIncCusB();

            string CustomerName = txtCustomerName.Text;
            int ContactNumber = Int32.Parse(txtCustomerPhone.Text);

            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.CustomerID = CustInc;
            customerInfo.CustomerName = CustomerName;
            customerInfo.ContactNumber = ContactNumber;
            billingBusiness.SaveCustomerData(customerInfo);

            MessageBox.Show("Cus Added" + CustInc);
            Main.Content = new EmployeeAccess();
        }

        //private void btnGotoBill_Click(object sender, RoutedEventArgs e)
        //{
        //    //Main.Content = new EmployeeAccess();
        //}
    }
}
