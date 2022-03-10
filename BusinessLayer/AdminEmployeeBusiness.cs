using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AdminEmployeeBusiness
    {
        //public List<FoodOnHoopModel> GetEmployee()
        //{
        //    AdminEmployeeData employeedata = new AdminEmployeeData();
        //    return employeedata.GetEmployeeData();
        //}
        public List<FoodOnHoopModel> GetEmployees()
        {
            AdminEmployeeData employeedata = new AdminEmployeeData();
            return employeedata.GetEmployeeData();
        }

        public void DeleteEmployee(FoodOnHoopModel foodOnHoopModel)
        {
            AdminEmployeeData employeedata = new AdminEmployeeData();
            employeedata.DeleteProductData(foodOnHoopModel);

        }
        public void UpdateEmployee(FoodOnHoopModel foodOnHoopModel)
        {
            AdminEmployeeData employeeData = new AdminEmployeeData();
            employeeData.UpdateEmployeeData(foodOnHoopModel);
        }   
    }
}
