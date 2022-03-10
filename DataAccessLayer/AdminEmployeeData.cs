using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AdminEmployeeData
    {
        public List<FoodOnHoopModel> GetEmployeeData()
        {
            List<FoodOnHoopModel> dataList = new List<FoodOnHoopModel>();
            FoodonHoopDBEntities objEntities = new FoodonHoopDBEntities();
            var result = from prdObj in objEntities.tblEmployees //against DB obj
                         select prdObj;
            foreach (var item in result)
            {
                FoodOnHoopModel foodOnHoopModel = new FoodOnHoopModel();
                foodOnHoopModel.EmployeeID = item.EmployeeID;
                foodOnHoopModel.EmployeeFullName = item.EmployeeFullName;
                foodOnHoopModel.Dob = (DateTime)item.Dob;
                foodOnHoopModel.Age = (int)item.Age;
                foodOnHoopModel.AdhaarNumber = (long)(item.AdhaarNumber);
                foodOnHoopModel.FatherName = item.FatherName;
                foodOnHoopModel.MotherName = item.MotherName;
                foodOnHoopModel.Address = item.Address;
                foodOnHoopModel.District = item.District;
                foodOnHoopModel.Pincode = (int)item.Pincode;
                foodOnHoopModel.State = item.State;
                foodOnHoopModel.ContactNumber = (int)item.ContactNumber;
                foodOnHoopModel.EmailID = item.EmailID;
                foodOnHoopModel.JoinDate = (DateTime)item.JoinDate;
                foodOnHoopModel.OtherSubmittedProof = item.OtherSubmittedProof;
                foodOnHoopModel.UserName = item.UserName;
                foodOnHoopModel.Password = item.Password;

                //model. = item.ProductID;
                //model.ProductName = item.ProductName;
                //model.ProductDescription = item.Description;
                //model.ProductPrice = (float)item.Price;
                //model.ProductUnit = item.Unit;
                dataList.Add(foodOnHoopModel);
            }
            return dataList;
        }

        public void DeleteProductData(FoodOnHoopModel model)
        {
            try
            {
                FoodonHoopDBEntities objEntities = new FoodonHoopDBEntities();
                var result = from obj in objEntities.tblEmployees
                             where obj.EmployeeID == model.EmployeeID
                             select obj;

                foreach (var entity in result)
                {
                    objEntities.tblEmployees.Remove(entity);
                }
                objEntities.SaveChanges();

                //ProductDBEntities productDBEntities = new ProductDBEntities();
                //var result = from product in productDBEntities.Products
                //             where product.ProductID == model.ProductId
                //             select product;
                //foreach (var item in result)
                //{
                //    productDBEntities.Products.Remove(item);
                //}
                //productDBEntities.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   
        public void UpdateEmployeeData(FoodOnHoopModel productModel)
        {
            try
            {
                FoodonHoopDBEntities objEntities = new FoodonHoopDBEntities();
                var query = from product in objEntities.tblEmployees
                            where product.EmployeeID == productModel.EmployeeID
                            select product;

                foreach (var item in query)
                {

                    item.EmployeeID = productModel.EmployeeID;
                    item.EmployeeFullName = productModel.EmployeeFullName;
                    //item.Dob = productModel.Dob;
                    //item.Age = productModel.Age;
                    //item.AdhaarNumber = productModel.AdhaarNumber;
                    //item.FatherName = productModel.FatherName;
                    //item.MotherName = productModel.MotherName;
                    item.Address = productModel.Address;
                    item.District = productModel.District;
                    item.Pincode = productModel.Pincode;
                    item.State = productModel.State;
                    item.ContactNumber = productModel.ContactNumber;
                    item.EmailID = productModel.EmailID;
                    //item.JoinDate = productModel.JoinDate;
                    //item.OtherSubmittedProof = productModel.OtherSubmittedProof;
                    //item.UserName = productModel.UserName;
                    //item.Password = productModel.Password;

                    //item.= productModel.ProductName;
                    //item.Description = productModel.ProductDescription;
                    //item.Price = productModel.ProductPrice;
                    //item.Unit = productModel.ProductUnit;
                }
                objEntities.SaveChanges();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
