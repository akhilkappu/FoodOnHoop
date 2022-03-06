﻿using FoodOnHoop.ViewModels;
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
    /// Interaction logic for AdminOrder.xaml
    /// </summary>
    public partial class AdminOrder : Page
    {
        public AdminOrder()
        {
            InitializeComponent();
            AdminOrderViewModel adminOrderViewModel1 = new AdminOrderViewModel();
            grdAdminOrder.ItemsSource = adminOrderViewModel1.values;
            this.DataContext = adminOrderViewModel1;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Back.Content = new AdminAccess();
        }
    }
}
