using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOnHoop.ViewModels
{
   public  class AdminMenuPageViewModel : BaseViewModel
    {
        public Category category;

        public List<Category> categories { get; set; }

        public AdminMenuPageViewModel()
        {
            categories = new List<Category>();
            MenuCategoryBusiness menuCategoryBusiness = new MenuCategoryBusiness();
            categories = menuCategoryBusiness.MenuDataBl();
        }

    }
}
