using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class FoodOnHoopModel
    {
        private int _employeeID;

        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
        private string _employeeFullName;

        public string EmployeeFullName
        {
            get { return _employeeFullName; }
            set { _employeeFullName = value; }
        }
        private DateTime _dob;

        public DateTime Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private int _adhaarNumber;

        public int AdhaarNumber
        {
            get { return _adhaarNumber; }
            set { _adhaarNumber = value; }
        }
        private string  _fatherName;

        public string  FatherName
        {
            get { return _fatherName; }
            set { _fatherName = value; }
        }

        private string _motherName;

        public string MotherName
        {
            get { return _motherName; }
            set { _motherName = value; }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _district;

        public string District
        {
            get { return _district; }
            set { _district = value; }
        }
        private int _pincode;

        public int Pincode
        {
            get { return _pincode; }
            set { _pincode = value; }
        }
        private string _state;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        private int _contactNumber;

        public int ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }
        private string _emailID;

        public string EmailID
        {
            get { return _emailID; }
            set { _emailID = value; }
        }
        private DateTime _joinDate;

        public DateTime JoinDate
        {
            get { return _joinDate; }
            set { _joinDate = value; }
        }
        private string _otherSubmittedProof;

        public string OtherSubmittedProof
        {
            get { return _otherSubmittedProof; }
            set { _otherSubmittedProof = value; }
        }
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private int _confirmPassword;

        public int ConfirmPassword
        {
            get { return _confirmPassword; }
            set { _confirmPassword = value; }
        }
    }
}
