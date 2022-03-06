using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class MenuSaveData
    {
        public void SaveData( Category category)
        {
            try
            {
                FoodonHoopDBEntities foodonHoopDBEntities = new FoodonHoopDBEntities();
                tblMenu menu = new tblMenu();
                menu.CategoryID = category.CategoryID;
                menu.Price = category.Price;
                menu.Item = category.ItemName;
                menu.MenuID = category.MenuID;
                foodonHoopDBEntities.tblMenus.Add(menu);
                foodonHoopDBEntities.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           

        }
        public void DeleteData( Category category)
        {
            try
            {
                FoodonHoopDBEntities foodonHoopDBEntities=new FoodonHoopDBEntities();
                var result = from foh in foodonHoopDBEntities.tblMenus
                             where foh .MenuID == category.MenuID
                             select foh;

                foreach (var menu in result)
                {
                    foodonHoopDBEntities.tblMenus.Remove(menu);
                }
                foodonHoopDBEntities.SaveChanges ();
            }
            catch ( Exception ex )
            {
                throw ex;
            }

        }

        public void UpdateData( Category category)
        {
            try
            {
                FoodonHoopDBEntities foodonHoopDBEntities =new FoodonHoopDBEntities();
                var query = from foh in foodonHoopDBEntities.tblMenus
                            where foh.MenuID == category.MenuID
                            select foh;

                foreach(var menu in query)
                {
                    menu.MenuID = category.MenuID;
                    menu.CategoryID = category.CategoryID;
                    menu.Price = category.Price;
                    menu.Item = category.ItemName;
                }
                foodonHoopDBEntities.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
