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
    public class HotClassicViewModel : BaseViewModel
    {

        //public int GetData(string s)
        //{
        //    return 1;
        //}
        //public void GetData(string s)
        //{

        //}

        public Category category;
        public List<Category> hotclass { get; set; }
      //  public ICommand hotclass { get; set; }

        public HotClassicViewModel()
        {
            hotclass = new List<Category>();
            MenuCategoryBusiness menuCategoryBusiness = new MenuCategoryBusiness();
            hotclass = menuCategoryBusiness.HotBl();

            
        }
    }
}
