using BusinessLayer;
using DataAccessLayer;
using EntityLayer;
using FoodOnHoop.ViewModels;
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
    /// Interaction logic for EmployeeAccess.xaml
    /// </summary>
    public partial class EmployeeAccess : Page
    {
        FoodonHoopDBEntities dBEntities = new FoodonHoopDBEntities();

        public int id { get; set; }
        public List<Category> listBillATC { get; set; }
        public List<Category> listBillFOM { get; set; }

        public List<Category> listBillHC { get; set; }
        public int Inc { get; set; }
        public int CustInc { get; set; }
        //public List<AutoInc> AutoIncs { get; set; }
        public int Orderid;
        public int Custid;

        public EmployeeAccess()
        {
            InitializeComponent();
            listBillATC = new List<Category>();
            MenuCategoryItem menuCategoryData = new MenuCategoryItem();
            listBillATC = menuCategoryData.AlltimechillerBill();
            listBillFOM = menuCategoryData.FoodOnMood();
            listBillHC = menuCategoryData.HotClassicBill();

            //AdminOrderViewModel adminOrderViewModel1 = new AdminOrderViewModel();
            //grdAdminOrder.ItemsSource = adminOrderViewModel1.bills;
            //this.DataContext = adminOrderViewModel1;

            //categoryBusiness.
            //Category category = new Category();
            //MenuCategoryBusiness categoryBusiness = new MenuCategoryBusiness();
            //cbCategoryName.Text = 
            //cbCategoryName.ItemsSource = categoryBusiness.GetCategoryHot();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Employee.Content = new AdminEmployeeAccess();
        }

        private void cbCategoryName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbItemName.Items.Clear();

            if (cbCategoryName.SelectedItem == cbitemFM)
            {
                MessageBox.Show("FoodOnMood Selected");

                foreach (var item in listBillFOM)
                {
                    cbItemName.Items.Add(item);
                }
                foreach (var item in listBillFOM)
                {
                    cbMenuID.Items.Add(item);
                }


                //MessageBox.Show("FoodOnMood Item Added");
            }
            else if (cbCategoryName.SelectedItem == cbitemHC)
            {
                MessageBox.Show("Hot Classic Selected");
                foreach (var item in listBillHC)
                {
                    cbItemName.Items.Add(item);
                }
                foreach (var item in listBillHC)
                {
                    cbMenuID.Items.Add(item);
                }
                //MessageBox.Show("HotClassic Item Added");
            }
            else if (cbCategoryName.SelectedItem == cbItemATC)
            {
                MessageBox.Show("All time Selected");
                AllTimeChillersViewModel allTimeChillers = new AllTimeChillersViewModel();

                foreach (var item in listBillATC)
                {
                    cbItemName.Items.Add(item);
                }
                foreach (var item in listBillATC)
                {
                    cbMenuID.Items.Add(item);
                }
                //MessageBox.Show("AllTime Item Added"); 
            }
        }
        //public decimal gt;
        public void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            BillingBusiness billingBusiness = new BillingBusiness();
            Billing billing = new Billing();
            Inc = billingBusiness.GetAutoIncOrderB();
            //CustInc = billingBusiness.GetAutoIncCusB();


            int EmployeeID = Int32.Parse(txtAddEmployeeID.Text);
            int MenuID = Int32.Parse(txtMenuID.Text);

            int ItemQuantity = Int32.Parse(txtAddQuantity.Text);

            decimal Price = Convert.ToDecimal(txtAddPrice.Text);

            decimal ItemTotalPrice = ItemQuantity * Price;

            DateTime date = Convert.ToDateTime(dpEditdate.Text);

            CustomerInfo customerInfo = new CustomerInfo();

            billing.OrderID = Inc;

            var i = (from d in dBEntities.tblCustomers
                     select d.CustomerID).Max();

            billing.CustomerID = i;
            billing.ItemQuantity = ItemQuantity;
            billing.ItemTotalPrice = ItemTotalPrice;
            billing.Date = date;
            billing.EmployeeID = EmployeeID;
            billing.MenuID = MenuID;

            string ItemName = cbItemName.Text;
            string FoodStatus = cbFoodStatus.Text;
            string PaymentStatus = cbPaymentStatus.Text;

            billing.ItemName = ItemName;
            billing.PaymentStatus = PaymentStatus;
            billing.FoodStatus = FoodStatus;
            billingBusiness.SaveBillData(billing);//----------

            MessageBox.Show("Saved");

            Refresh();
            decimal sum = 0m;
            for (int ito = 0; ito < grdBill.Items.Count - 1; ito++)
            {
                sum += (decimal.Parse((grdBill.Columns[3].GetCellContent(grdBill.Items[ito]) as TextBlock).Text));
            }
            txtBGrandTotal.Text = sum.ToString();
        }
        void Refresh()
        {
            MessageBox.Show("Refresh");

            BillingBusiness billingBusiness = new BillingBusiness();
            grdBill.ItemsSource = billingBusiness.GetBillB();
            MessageBox.Show("Refreahed clear");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Back.Content = new Login();
        }


        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                if (grdBill.Items.Count > 0)
                {
                    var value = (grdBill.SelectedItem as Billing).OrderID;
                    Billing billing = new Billing();
                    BillingBusiness billB = new BillingBusiness();
                    billing.OrderID = value;
                    billB.DeleteBillB(billing);
                    MessageBox.Show("Product Deleted :" + billing.OrderID);
                    Refresh();

                    decimal sum = 0m;
                    for (int ito = 0; ito < grdBill.Items.Count - 1; ito++)
                    {
                        sum += (decimal.Parse((grdBill.Columns[3].GetCellContent(grdBill.Items[ito]) as TextBlock).Text));
                    }
                    txtBGrandTotal.Text = sum.ToString();
                }
                else
                {
                    MessageBox.Show("No Product available for Delete:??");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw ex;
            }
        }

        private void btnGetTotal(object sender, RoutedEventArgs e)
        {
            //decimal GrandTotal = GrandTotal + 
        }

        //private void btnEdit_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        Billing billing = new Billing();
        //        billing.OrderID = id;
        //        billing.FoodStatus = cbFoodStatus.Text;
        //        billing.PaymentStatus = cbPaymentStatus.Text;
        //        billing.EmployeeID = int.Parse(txtAddEmployeeID.Text);
        //        //billing.OrderID = Inc;

        //        //billing.CustomerID = ;

        //        billing.ItemQuantity = int.Parse(txtAddQuantity.Text);
        //        billing.ItemName = cbItemName.Text;
        //        billing.ItemTotalPrice = Int32.Parse(txtAddPrice.Text);
        //        billing.MenuID = Int32.Parse(txtMenuID.Text);
        //        billing.Date = Convert.ToDateTime(dpEditdate.Text);


        //        BillingBusiness billingBusiness = new BillingBusiness();
        //        billingBusiness.BillingUpdateBL(billing);
        //        MessageBox.Show("Order Edited");
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }


        //}
        //private void Edit(object sender, RoutedEventArgs e)
        //{
        //    id = (grdBill.SelectedItem as Billing).OrderID;
        //    //txtEditID.Text = (grdMenu.SelectedItem as Billing).EmployeeID.ToString();
        //    txtAddQuantity.Text = (grdBill.SelectedItem as Billing).ItemQuantity.ToString();
        //    txtAddEmployeeID.Text = (grdBill.SelectedItem as Billing).EmployeeID.ToString();
        //    txtAddPrice.Text = (grdBill.SelectedItem as Billing).ItemTotalPrice.ToString();
        //    //txtMenuID.Text = 

        //    //cbFoodStatus.Text = (grdBill.SelectedItem as Billing).FoodStatus.ToString();
        //    //cbPaymentStatus.Text = (grdBill.SelectedItem as Billing).PaymentStatus.ToString();
        //    //cbItemName.Text = (grdBill.SelectedItem as Billing).ItemName.ToString();

        //    //dpEditdate.Text = (grdBill.SelectedItem as Billing).Date.ToString();

        //}

        //private void btnAddCus_Click(object sender, RoutedEventArgs e)
        //{
        //    BillingBusiness billingBusiness = new BillingBusiness();
        //    Billing billing = new Billing();
        //    CustInc = billingBusiness.GetAutoIncCusB();

        //    //string CustomerName = txtCustomerName.Text;
        //    //int ContactNumber = Int32.Parse(txtCustomerPhone.Text);

        //    CustomerInfo customerInfo = new CustomerInfo();
        //    customerInfo.CustomerID = CustInc;
        //    customerInfo.CustomerName = CustomerName;
        //    customerInfo.ContactNumber = ContactNumber;
        //    billingBusiness.SaveCustomerData(customerInfo);

        //    MessageBox.Show("Cus Added");

        //    //btnAdd_Click_1(object sender, RoutedEventArgs e);


        //}

        ////AdminOrder adminOrder = new AdminOrder();


        //MenuInfo menuInfo = new MenuInfo();
        //menuInfo.ItemName = ItemName;


        //dgtItemName.Binding = (cbItemName.SelectedItem as MenuInfo).ItemName;

        //txtEditEmployeeName.Text = (grdEmployee.SelectedItem as FoodOnHoopModel).EmployeeFullName.ToString();
    }
}
