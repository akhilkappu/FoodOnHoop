using EntityLayer;
using FoodOnHoop.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodOnHoop.ViewModels
{
   public class SignUpViewModel:BaseViewModel
    {
        private FoodOnHoopModel foodOnHoopModel;
        public ICommand submitCommand { get; set; }

        public SignUpViewModel(FoodOnHoopModel foodOn)
        {
            foodOnHoopModel = foodOn;
            submitCommand = new SubmitCommand(this);
        }

        private int _employeeID;

        public int EmployeeID
        {
            get { return _employeeID; }
            set 
            {
                _employeeID = value;
                OnPropertyChanged("EmployeeID");
            }
        }
        private string _employeeFullName;

        public string EmployeeFullName
        {
            get { return _employeeFullName; }
            set
            {
                _employeeFullName = value;
                OnPropertyChanged("EmployeeFullName");
            }
        }
        private DateTime _dob = DateTime.Now;

        public DateTime Dob
        {
            get { return _dob; }
            set 
            {
                _dob = value;
                OnPropertyChanged("Dob");
            }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set 
            { 
                _age = value;
                OnPropertyChanged("Age");
            }
            //isgirg
        }
        private int _adhaarNumber;

        public int AdhaarNumber
        {
            get { return _adhaarNumber; }
            set
            {
                _adhaarNumber = value;
                OnPropertyChanged("AdhaarNumber");
            }
        }
        private string _fatherName;

        public string FatherName
        {
            get { return _fatherName; }
            set 
            { 
                _fatherName = value;
                OnPropertyChanged("FatherName");
            }
        }

        private string _motherName;

        public string MotherName
        {
            get { return _motherName; }
            set 
            { 
                _motherName = value;
                OnPropertyChanged("MotherName");
            }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }
        private string _district;

        public string District
        {
            get { return _district; }
            set 
            { 
                _district = value;
                OnPropertyChanged("District");
            }
        }
        private int _pincode;

        public int Pincode
        {
            get { return _pincode; }
            set
            { 
                _pincode = value;
                OnPropertyChanged("Pincode");
            }
        }
        private string _state;

        public string State
        {
            get { return _state; }
            set 
            { 
                _state = value;
                OnPropertyChanged("State");
            }
        }
        private int _contactNumber;

        public int ContactNumber
        {
            get { return _contactNumber; }
            set
            { 
                _contactNumber = value;
                OnPropertyChanged("ContactNumber");
            }
        }
        private string _emailID;

        public string EmailID
        {
            get { return _emailID; }
            set 
            {
                _emailID = value;
                OnPropertyChanged("EmailID");
            }
        }
        private DateTime _joinDate = DateTime.Now;

        public DateTime JoinDate
        {
            get { return _joinDate; }
            set
            {
                _joinDate = value;
                OnPropertyChanged("JoinDate");
            }
        }
        private string _otherSubmittedProof;

        public string OtherSubmittedProof
        {
            get { return _otherSubmittedProof; }
            set 
            { 
                _otherSubmittedProof = value;
                OnPropertyChanged("OtherSubmittedProof");
            }
        }
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set 
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set 
            { 
                _password = value;
                OnPropertyChanged("Password");
            }
        }
        //private int _confirmPassword;

        //public int ConfirmPassword
        //{
        //    get { return _confirmPassword; }
        //    set
        //    { 
        //        _confirmPassword = value;
        //        OnPropertyChanged("ConfirmPassword");
        //    }
        //}


    }

}
