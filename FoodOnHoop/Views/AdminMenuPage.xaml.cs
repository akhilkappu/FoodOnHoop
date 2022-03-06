using BusinessLayer;
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
    /// Interaction logic for AdminMenuPage.xaml
    /// </summary>
    public partial class AdminMenuPage : Page
    {
        public int id;
        public AdminMenuPage()
        {
            InitializeComponent();
            AdminMenuPageViewModel adminMenuPageViewModel = new AdminMenuPageViewModel();
            grdMenu.ItemsSource = adminMenuPageViewModel.categories;
            this.DataContext = adminMenuPageViewModel;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Back.Content = new AdminAccess();
        }

        private void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            Category category = new Category();
            string Id = txtAddID.Text;
            string Name = txtAddItemName.Text;
            SignUpBusiness signUpBusiness = new SignUpBusiness();

            if(Id != null && Name !=null && txtAddID.Text.ToString() != null && txtAddItemName.Text.ToString() !=null )
            {
                category.MenuID = int.Parse(Id);
                category.ItemName = Name;
                category.CategoryID = int.Parse(txtCategoryID.Text);
                category.Price = int.Parse(txtAddPrice.Text);
                signUpBusiness.SaveDataBl(category);
                MessageBox.Show("Menu Item Added");
                Refresh();
                ClearText();
            }
        }

        void Refresh()
        {
            MenuCategoryBusiness menuCategoryBusiness = new MenuCategoryBusiness();
            grdMenu.ItemsSource = menuCategoryBusiness.MenuDataBl();

        }
        void ClearText()
        {
            txtCategoryID.Text = string.Empty;
            txtAddItemName.Text = string.Empty;
            txtAddID.Text = string.Empty;
            txtAddPrice.Text = string.Empty;    
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {

                if (grdMenu.Items.Count > 0)
                {
                    var value = (grdMenu.SelectedItem as Category).MenuID;
                    Category category = new Category();
                    SignUpBusiness signUpBusiness = new SignUpBusiness();
                    category.MenuID = value;
                    signUpBusiness.DeleteDataBl(category);
                    MessageBox.Show("Menu Deleted");
                    Refresh();
                }
                else
                {
                    MessageBox.Show("No Items available for delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Category category = new Category();
            category.MenuID = id;
            category.CategoryID = int.Parse(txtCategoryID.Text);
            category.ItemName = txtAddItemName.Text;
            category.Price = int.Parse(txtAddPrice.Text);
            SignUpBusiness signUpBusiness =new SignUpBusiness();    
            signUpBusiness.UpdateDataBl(category);
            MessageBox.Show("Menu Edited");
            Refresh();
            ClearText();


        }
        private void Edit(object sender, RoutedEventArgs e)
        {
            id = (grdMenu.SelectedItem as Category).MenuID;
            txtAddItemName.Text = (grdMenu.SelectedItem as Category).ItemName.ToString();
            txtAddPrice.Text = (grdMenu.SelectedItem as Category).
        }

       
    }
}
