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
            if (attempt == 0)
            {
                lbl_Msg.Content = ("ALL 3 ATTEMPTS HAVE FAILED - CONTACT ADMIN");
                Main.Content = new Home();
                return;
            }
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"data source = LAPTOP-IJI0NIKR; database = FoodonHoopDB; integrated security = SSPI";
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from tblEmployee where UserName=@UserName and Password=@Password", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@UserName", txtusername.Text);
            scmd.Parameters.AddWithValue("@Password", pwpassword.Password);
            scn.Open();

            if (scmd.ExecuteScalar().ToString() == "1")
            {
                //pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Documents\Visual Studio 2015\Projects\mylogin\granted.png");
                MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                Main.Content = new CustomerBill();
            }

            else
            {

                //pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Documents\Visual Studio 2015\Projects\mylogin\denied.jpg");
                MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");
                lbl_Msg.Content = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try !!");
                --attempt;
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
            if (attempt == 0)
            {
                lbl_Msg.Content = ("ALERT!!! LOGIN FAILED");
                Main.Content = new Home();
                return;
            }

            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"data source = LAPTOP-IJI0NIKR; database = FoodonHoopDB; integrated security = SSPI";
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from tblLoginData where UserName=@UserName and Password=@Password", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@UserName", txtusername.Text);
            scmd.Parameters.AddWithValue("@Password", pwpassword.Password);
            scn.Open();

            if (scmd.ExecuteScalar().ToString() == "1")
            {
                //pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Documents\Visual Studio 2015\Projects\mylogin\granted.png");
                MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                Main.Content = new AdminAccess();
            }

            else
            {

                //pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Documents\Visual Studio 2015\Projects\mylogin\denied.jpg");
                MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");
                lbl_Msg.Content = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try !!");
                --attempt;
                txtusername.Clear();
                pwpassword.Clear();
            }
        }
    }
}
