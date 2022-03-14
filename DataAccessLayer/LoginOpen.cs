using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataAccessLayer
{
    public class LoginOpen
    {
        public List<FoodOnHoopModel> GetLoginData()
        {
            List<FoodOnHoopModel> list = new List<FoodOnHoopModel> ();
            FoodonHoopDBEntities dBEntities = new FoodonHoopDBEntities();
            
            try
            {
                SqlConnection sqlConnection = null;
                using (sqlConnection = new SqlConnection("Data Source = LAPTOP-IJI0NIKR; Database = FoodonHoopDB; Integrated Security = true;"))
                {
                    SqlCommand scmd = new SqlCommand("select count (*) as cnt from tblLoginData where UserName=@UserName and Password=@Password", sqlConnection);
                    scmd.Parameters.Clear();
                    //scmd.Parameters.AddWithValue("@UserName", UserName);
                    //scmd.Parameters.AddWithValue("@Password", Password);
                    sqlConnection.Open();

                    if (scmd.ExecuteScalar().ToString() == "1")
                    {
                        //pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Documents\Visual Studio 2015\Projects\mylogin\granted.png");
                        MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                        //Main.Content = new AdminAccess();
                    }

                    else
                    {
                        //pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Documents\Visual Studio 2015\Projects\mylogin\denied.jpg");
                        MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");
                        //lbl_Msg.Content = ("You Have Only " + Convert.ToString(adminAttempt) + " Attempt Left To Try !!");
                        //--adminAttempt;
                        //txtusername.Clear();
                        //pwpassword.Clear();
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
    }
}
