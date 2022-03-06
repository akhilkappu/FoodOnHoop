using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MenuCategoryBusiness
    {
        public List<Category> AllTimeBl() // all time chillers
        {
            MenuCategoryItem menuCategoryItem = new MenuCategoryItem();
            return menuCategoryItem.AllTimeChillers();

        }
        public List<Category> FoodOnBl() // food on mood
        {
            MenuCategoryItem menuCategoryItem = new MenuCategoryItem();
            return menuCategoryItem.FoodOnMood();

        }
        public List<Category> HotBl() // hot classic
        {
            MenuCategoryItem menuCategoryItem = new MenuCategoryItem();
            return menuCategoryItem.HotClassic();

        }
        public List<Category> MenuDataBl()
        {
            MenuCategoryItem menuCategoryItem = new MenuCategoryItem();
            return menuCategoryItem.GetMenuData();
        }
    }
}
