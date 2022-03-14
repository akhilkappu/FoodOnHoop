using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LoginBusiness
    {
        public void GetLoginDataBL(FoodOnHoopModel onHoopModel)
        {
            LoginOpen open = new LoginOpen();
            open.GetLoginData(onHoopModel);
        }
    }
}
