using FoodOnHoop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodOnHoop.Commands
{
    public class RedirectViewCommand : ICommand
    {
        public MainViewModel mainView;

        public RedirectViewCommand(MainViewModel viewModel)
        {
            this.mainView = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter.ToString()=="Home")
            {
                mainView.SelectedViewModel = new HomeViewModel();
            }
            else if (parameter.ToString()=="FoodOnMood")
            {
                mainView.SelectedViewModel = new FoodOnMoodViewModel();
            }
            else if (parameter.ToString() =="HotClassic")
            {
                mainView.SelectedViewModel = new HotClassicViewModel();
            }
            else if (parameter.ToString() =="AllTimeChillers")
            {
                mainView.SelectedViewModel = new AllTimeChillersViewModel();
            }
            else if(parameter.ToString() =="Login")
            {
                mainView.SelectedViewModel= new LoginViewModel();
            }
            else if (parameter.ToString()=="AboutUs")
            {
                mainView.SelectedViewModel = new AboutUsViewModel();
            }
            else if (parameter.ToString()=="ContactUs")
            {
                mainView.SelectedViewModel = new ContactUsViewModel();
            }
        }
    }
}
