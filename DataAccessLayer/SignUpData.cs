using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SignUpData
    {
        public void SaveSignUpEmployee(FoodOnHoopModel foodOn)
        {
            try 
            {
                FoodonHoopDBEntities foodonHoopDBEntities = new FoodonHoopDBEntities();
                tblEmployee tblEmployee = new tblEmployee();
                tblEmployee.EmployeeID = foodOn.EmployeeID;
                tblEmployee.EmployeeFullName = foodOn.EmployeeFullName;
                tblEmployee.Dob = foodOn.Dob;
                tblEmployee.Age = foodOn.Age;
                tblEmployee.AdhaarNumber = foodOn.AdhaarNumber;
                tblEmployee.FatherName = foodOn.FatherName;
                tblEmployee.MotherName = foodOn.MotherName;
                tblEmployee.Address = foodOn.Address;
                tblEmployee.District = foodOn.District;
                tblEmployee.Pincode = foodOn.Pincode;
                tblEmployee.State = foodOn.State;
                tblEmployee.ContactNumber = foodOn.ContactNumber;
                tblEmployee.EmailID = foodOn.EmailID;
                tblEmployee.JoinDate = foodOn.JoinDate;
                tblEmployee.OtherSubmittedProof = foodOn.OtherSubmittedProof;
                tblEmployee.UserName = foodOn.UserName;
                tblEmployee.Password = foodOn.Password;
                foodonHoopDBEntities.tblEmployees.Add(tblEmployee);
                foodonHoopDBEntities.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
           




        }
    }
}
