using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodOnHoop.ViewModels
{
    public class FoodOnMoodViewModel:BaseViewModel
    {
        public Category category;
        public List<Category> foodonmood { get; set; }
       // public ICommand foodonmood { get; set; }

        public FoodOnMoodViewModel()
        {
            foodonmood = new List<Category>();
            MenuCategoryBusiness menuCategoryBusiness = new MenuCategoryBusiness();
            foodonmood= menuCategoryBusiness.FoodOnBl();
        }
    }
}
