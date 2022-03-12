using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FoodOnHoop.Views
{
    /// <summary>
    /// Interaction logic for AdminEmployeeAccess.xaml
    /// </summary>
    public partial class AdminEmployeeAccess : Page
    {   
        public int id { get; set; }
        public AdminEmployeeAccess()
        {
            InitializeComponent();

            //AdminEmployeeViewModel viewModel = new AdminEmployeeViewModel();
            //grdEmployee.ItemsSource = viewModel.list;
            //this.DataContext = viewModel;

            AdminEmployeeBusiness adminEmployeeBusiness = new AdminEmployeeBusiness();
            grdEmployee.ItemsSource = adminEmployeeBusiness.GetEmployees();

        }
        

        private void btnDeleteInGrid(object sender, RoutedEventArgs e)
        {
            try
            {
                if (grdEmployee.Items.Count > 0)
                {
                    var value = (grdEmployee.SelectedItem as FoodOnHoopModel).EmployeeID;
                    FoodOnHoopModel onHoopModel = new FoodOnHoopModel();
                    AdminEmployeeBusiness adminEmployeeBusiness = new AdminEmployeeBusiness();
                    onHoopModel.EmployeeID = value;
                    adminEmployeeBusiness.DeleteEmployee(onHoopModel);
                    MessageBox.Show("Deleted :" + onHoopModel.EmployeeID);
                    Refresh();
                }
                else
                {
                    MessageBox.Show("No Product available for Delete:??");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw ex;
            }
        }

        private void Refresh()
        {
            AdminEmployeeBusiness adminEmployeeBusiness = new AdminEmployeeBusiness();
            grdEmployee.ItemsSource = adminEmployeeBusiness.GetEmployees(); 
        }

        private void btnEditInGrid(Object sender, RoutedEventArgs e)
        {
            id = (grdEmployee.SelectedItem as FoodOnHoopModel).EmployeeID;
            txtEditID.Text = (grdEmployee.SelectedItem as FoodOnHoopModel).EmployeeID.ToString();
            txtEditEmployeeName.Text = (grdEmployee.SelectedItem as FoodOnHoopModel).EmployeeFullName.ToString();
            txtEditAddress.Text = (grdEmployee.SelectedItem as FoodOnHoopModel).Address.ToString();
            txtEditContactNo.Text = (grdEmployee.SelectedItem as FoodOnHoopModel).ContactNumber.ToString();
            txtEditDistrict.Text = (grdEmployee.SelectedItem as FoodOnHoopModel).District.ToString();
            txtEditState.Text = (grdEmployee.SelectedItem as FoodOnHoopModel).State.ToString();
            txtEditPincode.Text = (grdEmployee.SelectedItem as FoodOnHoopModel).Pincode.ToString();
            txtEditEmailId.Text = (grdEmployee.SelectedItem as FoodOnHoopModel).EmailID.ToString();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FoodOnHoopModel foodOnHoop = new FoodOnHoopModel();
                foodOnHoop.EmployeeID = id;
                foodOnHoop.EmployeeFullName = (string)txtEditEmployeeName.Text;
                foodOnHoop.Address = (string)txtEditAddress.Text;
                foodOnHoop.ContactNumber = Int64.Parse(txtEditContactNo.Text);
                foodOnHoop.District = (string)txtEditDistrict.Text;
                foodOnHoop.State = (string)txtEditState.Text;
                foodOnHoop.Pincode = Int32.Parse(txtEditPincode.Text);
                foodOnHoop.EmailID = (string)txtEditEmailId.Text;

                //foodOnHoop.FatherName = 

                AdminEmployeeBusiness employeeBusiness = new AdminEmployeeBusiness();
                employeeBusiness.UpdateEmployee(foodOnHoop);

                MessageBox.Show("Edited");
                Refresh();
                ClearTextBox();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            void ClearTextBox()
            {
                txtEditEmployeeName.Text = string.Empty;
                txtEditEmailId.Text = string.Empty;
                txtEditAddress.Text = string.Empty;
                txtEditContactNo.Text = string.Empty;
                txtEditDistrict.Text = string.Empty;
                txtEditState.Text = string.Empty;
                txtEditID.Text = string.Empty;
                txtEditPincode.Text = string.Empty;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Back.Content = new AdminAccess();
        }
    }
}
