using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SignUpBusiness : IFoodOnHoop
    {
      

        public void SignUpB(FoodOnHoopModel ifoodOn)
        {
              SignUpData signUpData = new SignUpData();
              signUpData.SaveSignUpEmployee(ifoodOn);
        }
        public void SaveDataBl(Category category)
        {
            MenuSaveData menuSaveData = new MenuSaveData();
            menuSaveData.SaveData(category);
        }
        public void DeleteDataBl( Category category)
        {
            MenuSaveData menuSaveData = new MenuSaveData();
            menuSaveData.DeleteData(category);
        }
        public void UpdateDataBl( Category category)
    {
            MenuSaveData menuSaveData = new MenuSaveData();
            menuSaveData.UpdateData(category);
        }


    }
}
