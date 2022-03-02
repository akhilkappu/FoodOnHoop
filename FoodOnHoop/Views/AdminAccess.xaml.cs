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
    /// Interaction logic for AdminAccess.xaml
    /// </summary>
    public partial class AdminAccess : Page
    {
        public AdminAccess()
        {
            InitializeComponent();
        }
        private void btnAdminMenuPage_Click(object sender, RoutedEventArgs e)
        {
            Admin.Content = new AdminMenuPage();
        }

        private void btnAdminEmployeePage_Click(object sender, RoutedEventArgs e)
        {
            Admin.Content = new AdminEmployeeAccess();
        }

        private void btnAdminOrderPage_Click(object sender, RoutedEventArgs e)
        {
            Admin.Content = new AdminOrder();
        }
    }
}
