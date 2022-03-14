using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for RegisterEmployee.xaml
    /// </summary>
    public partial class RegisterEmployee : UserControl
    {
        public RegisterEmployee()
        {
            InitializeComponent();
            clear();
        }
        void clear()
        {
            txtContactNumber.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtAdhaarNumber.Text = string.Empty;
            txtPincode.Text = string.Empty;
        }
        //int GetDifferenceInYears(DateTime startDate, DateTime endDate)
        //{
        //    return (endDate.Year - startDate.Year - 1) +
        //        (((endDate.Month > startDate.Month) ||
        //        ((endDate.Month == startDate.Month) && (endDate.Day >= startDate.Day))) ? 1 : 0);
        //}
        private void dpDob_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            //DobValidation();
            //if ((DateTime.Now.Subtract(dpDob.SelectedDate.Value).Days) / (365) < 18)
            //{
            //    MessageBox.Show("Less than 18 Years are not allowed");
            //    Main.Content = new Login();
            //}

            //var ageInYears = GetDifferenceInYears(dpDob.SelectedDate.Value, DateTime.Today);
            //if (ageInYears < 18)
            //{
            //    //MessageBox.Show("Under age");
            //}
        }
        void DobValidation()
        {
            if ((DateTime.Now.Subtract(dpDob.SelectedDate.Value).Days) / (365) < 18)
            {
                MessageBox.Show("Less than 18 Years are not allowed");
                Main.Content = new Login();
            }
        }
        private void btnSumbit_Click(object sender, RoutedEventArgs e)
        {
            
            if (txtFullName.Text == "" || txtEmailId.Text == "" || txtAddress.Text == "" || txtContactNumber.Text == "" || txtPassword.Text == "" || txtAddress.Text =="")
                MessageBox.Show("Please Fill Mandatory Fields");

            else if ((DateTime.Now.Subtract(dpDob.SelectedDate.Value).Days) / (365) < 18)
            {
                MessageBox.Show("Less than 18 Years are not allowed");
                Main.Content = new Login();
            }
            else
            {
                MessageBox.Show("Correct");
            }

            //if(dpDob.Text.Length == 0)
            //{

            //    dpDob.Focus();
            //}
            //else if (!Regex.IsMatch(txtEmailId.Text, @"^[a-zA-Z][\w\.-][a-zA-Z0-9]@[a-zA-Z0-9][\w\.-][a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            //{
            //    //errormessage.Text = "Enter a valid email.";
            //    MessageBox.Show("Enter a valid email");
            //    txtEmailId.Select(0, txtEmailId.Text.Length);
            //    txtEmailId.Focus();
            //}
            //if (txtPassword.Text.Length == 0)
            //{
            //    //errormessage.Text = "Enter password.";
            //    MessageBox.Show("Enter password");
            //    txtPassword.Focus();
            //}
            //else if (!Regex.IsMatch(txtPassword.Text, @"[0-9]+(?=.*\W)"))
            //{
            //    MessageBox.Show(" Enter a password with atleast one number and symbol ");
            //    txtPassword.Select(0, txtPassword.Text.Length);
            //    txtPassword.Focus();
            //}
            //if (txtContactNumber.Text.Length == 0)
            //{
            //    //errormessage.Text = "Enter password.";
            //    MessageBox.Show("Enter Phone Number");
            //    txtContactNumber.Focus();
            //}
            //else if (!Regex.IsMatch(txtContactNumber.Text, @"^[+][(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]$"))
            //{
            //    MessageBox.Show("Maximum 10 digits");
            //    txtContactNumber.Select(0, txtContactNumber.Text.Length);
            //    txtContactNumber.Focus();
            //}
            SignUpBusiness signBusiness = new SignUpBusiness();
            LoginData login = new LoginData();

            string UserName = ("empUnKey" +txtUserName.Text);
            string Password = ("empPwKey" +txtPassword.Text);

            //if (!string.IsNullOrEmpty(UserName))
            //{
            //    MessageBox.Show("Enter UserName");
            //}
            login.UserName = UserName;
            login.Password = Password;
            signBusiness.SaveLoginB(login);

            MessageBox.Show("Registered");

        }
    }
}
