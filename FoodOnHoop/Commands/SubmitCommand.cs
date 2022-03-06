using BusinessLayer;
using EntityLayer;
using FoodOnHoop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodOnHoop.Commands
{
    internal class SubmitCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public SignUpViewModel signUpViewModel { get; set; }
        public SubmitCommand(SignUpViewModel signUpView)
        {
            signUpViewModel = signUpView;
        }
        public bool CanExecute(object parameter)
        {
           return true;
        }

        public void Execute(object parameter)
        {
            FoodOnHoopModel foodOnHoopModel = new FoodOnHoopModel();
            foodOnHoopModel.EmployeeID = signUpViewModel.EmployeeID;
            foodOnHoopModel.EmployeeFullName = signUpViewModel.EmployeeFullName;
            foodOnHoopModel.Dob = signUpViewModel.Dob;
            foodOnHoopModel.Age = signUpViewModel.Age;
            foodOnHoopModel.AdhaarNumber = signUpViewModel.AdhaarNumber;   
            foodOnHoopModel.FatherName = signUpViewModel.FatherName;   
            foodOnHoopModel.MotherName = signUpViewModel.MotherName;
            foodOnHoopModel.Address = signUpViewModel.Address;
            foodOnHoopModel.District = signUpViewModel.District;
            foodOnHoopModel.Pincode = signUpViewModel.Pincode;
            foodOnHoopModel.State = signUpViewModel.State;
            foodOnHoopModel.ContactNumber = signUpViewModel.ContactNumber;
            foodOnHoopModel.EmailID = signUpViewModel.EmailID; 
            foodOnHoopModel.JoinDate = signUpViewModel.JoinDate;
            foodOnHoopModel.OtherSubmittedProof = signUpViewModel.OtherSubmittedProof;
            foodOnHoopModel.UserName = signUpViewModel.UserName;
            foodOnHoopModel.Password = signUpViewModel.Password;
            foodOnHoopModel.ContactNumber = signUpViewModel.ContactNumber;
            SignUpBusiness signUpBusiness = new SignUpBusiness();
            signUpBusiness.SignUpB(foodOnHoopModel);
        }
    }
}
