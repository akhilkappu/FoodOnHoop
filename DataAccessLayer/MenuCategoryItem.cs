using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MenuCategoryItem
    {
        public List<Category> AllTimeChillers()
        {
            List<Category> list3 = new List<Category>();
            FoodonHoopDBEntities foodonHoopDBEntities3 = new FoodonHoopDBEntities();
            var result = from alltime in foodonHoopDBEntities3.tblMenus
                         where alltime.CategoryID == 3
                         select alltime;
            foreach (var item in result)
            {
                Category category = new Category();
                category.ItemName = item.Item;
                category.MenuID = item.MenuID;
                category.Price = item.Price;
                list3.Add(category);

            }
            return list3;
        }
        public List<Category> FoodOnMood()
        {
            List<Category> list1 = new List<Category>();
            FoodonHoopDBEntities foodonHoopDBEntities1 = new FoodonHoopDBEntities();
            var result = from alltime in foodonHoopDBEntities1.tblMenus
                         where alltime.CategoryID == 1
                         select alltime;
            foreach (var item in result)
            {
                Category category = new Category();
                category.ItemName = item.Item;
                category.MenuID = item.MenuID;
                category.Price = item.Price;
                list1.Add(category);

            }
            return list1;
        }
        public List<Category> HotClassic()
        {
            List<Category> list2 = new List<Category>();
            FoodonHoopDBEntities foodonHoopDBEntities2 = new FoodonHoopDBEntities();
            var result = from alltime in foodonHoopDBEntities2.tblMenus
                         where alltime.CategoryID == 2
                         select alltime;
            foreach (var item in result)
            {
                Category category = new Category();
                category.ItemName = item.Item;
                category.MenuID = item.MenuID;
                category.Price = item.Price;
                list2.Add(category);

            }
            return list2;
        }
        public List<Category>GetMenuData() 
        {
            List<Category> getmenu = new List<Category>();
            FoodonHoopDBEntities menuDB = new FoodonHoopDBEntities();
            var result = from menu in menuDB.tblMenus
                         select menu;
            foreach (var item in result)
            {
                Category category = new Category();
                category.CategoryID = item.CategoryID;
                category.ItemName=item.Item;
                category.Price=item.Price;
                category.MenuID=item.MenuID;
                getmenu.Add(category);
                
            }
            return getmenu;
        }

        public List<Category> AlltimechillerBillData()
        {
            List<Category> categorylist = new List<Category>();
            FoodonHoopDBEntities foodonHoopDBEntities = new FoodonHoopDBEntities();
            var result = from alltime in foodonHoopDBEntities.tblMenus
                         where alltime.CategoryID == 3
                         select alltime;
            foreach (var item in result)
            {
                Category onHoop = new Category();
                onHoop.MenuID = item.MenuID;
                onHoop.ItemName = item.Item;
                onHoop.Price = item.Price;
                categorylist.Add(onHoop);
            }
            return categorylist;
        }
        public List<Category> FoodOnMoodBillData()
        {
            List<Category> categorylist = new List<Category>();
            FoodonHoopDBEntities foodonHoopDBEntities = new FoodonHoopDBEntities();
            var result = from alltime in foodonHoopDBEntities.tblMenus
                         where alltime.CategoryID == 1
                         select alltime;
            foreach (var item in result)
            {
                Category onHoop = new Category();
                onHoop.MenuID = item.MenuID;
                onHoop.ItemName = item.Item;
                onHoop.Price = item.Price;
                categorylist.Add(onHoop);
            }
            return categorylist;
        }
        public List<Category> HotClassicBillData()
        {
            List<Category> categorylist = new List<Category>();
            FoodonHoopDBEntities foodonHoopDBEntities = new FoodonHoopDBEntities();
            var result = from alltime in foodonHoopDBEntities.tblMenus
                         where alltime.CategoryID == 2
                         select alltime;
            foreach (var item in result)
            {
                Category onHoop = new Category();
                //onHoop.MenuID = item.MenuID;
                onHoop.ItemName = item.Item;
                //onHoop.Price = item.Price;
                categorylist.Add(onHoop);
            }
            return categorylist;

        }

    }
}
