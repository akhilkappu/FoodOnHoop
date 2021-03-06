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
    /// Interaction logic for BillingPrint.xaml
    /// </summary>
    public partial class BillingPrint : UserControl
    {
        public BillingPrint()
        {
            InitializeComponent();

            BillingBusiness billingBusiness = new BillingBusiness();
            grdPrint.ItemsSource = billingBusiness.GetBillB();

            MessageBox.Show("BillGenerating");

            Billing billing = new Billing();
            txtdate.Text = billing.Date.ToString();

            printerList.ItemsSource = billingBusiness.GetCustomerB();

            //List<CustomerInfo> lst_PrinterToGridBindings = new List<CustomerInfo>();
            //printerList.ItemsSource = lst_PrinterToGridBindings;
        }
        void Refresh()
        {
            BillingBusiness billingBusiness = new BillingBusiness();
            grdPrint.ItemsSource = billingBusiness.GetBillB();

            //BillGT();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "BillPage");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }

        private void btnGT_Click(object sender, RoutedEventArgs e)
        {
            decimal sum = 0m;
            for (int ito = 0; ito < grdPrint.Items.Count - 1; ito++)
            {
                sum += (decimal.Parse((grdPrint.Columns[3].GetCellContent(grdPrint.Items[ito]) as TextBlock).Text));
            }
            txtgrand.Text = sum.ToString();

            List<CustomerInfo> lst_PrinterToGridBindings = new List<CustomerInfo>();
            printerList.ItemsSource = lst_PrinterToGridBindings;

            BillingBusiness billingBusiness = new BillingBusiness();
            printerList.ItemsSource = billingBusiness.GetCustomerB();
            //this.txtgrand.Text = Convert.ToString( emp.GetGT());
            //MessageBox.Show("GT got");
        }
        private void btnToCusBill_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new CustomerBill();
        }
    }
}
