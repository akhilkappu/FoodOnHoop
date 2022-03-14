using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        static int attempt = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLoginEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (attempt == 1)
            {
                lbl_Msg.Content = ("ALERT!!! LOGIN FAILED");
                Main.Content = new Home();
                return;
            }
            LoginBusiness loginBusiness = new LoginBusiness();
            FoodOnHoopModel model = new FoodOnHoopModel();

            model.Password = pwpassword.Password;
            model.UserName = txtusername.Text;
            loginBusiness.GetLoginDataBL(model);
            int id = model.EmployeeID;
            if (id > 1)
            {

                Main.Content = new CustomerBill();
                MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
               // this.Close();
            }
            else
            {
                MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");

                --attempt;
                lbl_Msg.Content = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try !!");
                txtusername.Clear();
                pwpassword.Clear();

            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Home();
        }

        private void btnLoginAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (attempt == 1)
            {
                lbl_Msg.Content = ("ALERT!!! LOGIN FAILED");
                Main.Content = new Home();
                return;
            }
            LoginBusiness loginBusiness = new LoginBusiness();
            FoodOnHoopModel model = new FoodOnHoopModel();

            model.Password = pwpassword.Password;
            model.UserName = txtusername.Text;

            loginBusiness.GetLoginDataBL(model);
            int id = model.EmployeeID;
            if (id == 1)
            {

                Main.Content = new AdminAccess();
                MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
               // this.Close();
            }

            else
            {
                MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");

                --attempt;
                lbl_Msg.Content = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try !!");
                txtusername.Clear();
                pwpassword.Clear();

            }

        }

        
    }
}


