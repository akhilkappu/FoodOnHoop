using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataAccessLayer
{
    public class LoginOpen
    {
        public void GetLoginData(FoodOnHoopModel onHoopModel)
        {
            SqlConnection scn = new SqlConnection(@"data source = LAPTOP-68VIVQAF; database = FoodonHoopDB; integrated security = SSPI");
            try
            {
                if (scn.State == System.Data.ConnectionState.Closed)
                {
                    FoodOnHoopModel foodOn = new FoodOnHoopModel();
                    string user = onHoopModel.UserName;
                    string password = onHoopModel.Password;
                    scn.Open();
                    string query = "select EmployeeID  from tblEmployee where UserName=@UserName and Password=@Password";
                    SqlCommand scmd = new SqlCommand(query, scn);
                    scmd.CommandType = CommandType.Text;
                    scmd.Parameters.AddWithValue("@UserName", user);
                    scmd.Parameters.AddWithValue("@Password", password);
                    //int userId = Convert.ToInt32(scmd.ExecuteScalar());
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = scmd;
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        onHoopModel.EmployeeID = (int)dataSet.Tables[0].Rows[0]["EmployeeID"];

                    }

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
