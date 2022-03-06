﻿using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodOnHoop.ViewModels
{
    public class AllTimeChillersViewModel:BaseViewModel
    {
        public Category category;
        public List<Category> alltime { get; set; }
      //  public ICommand alltime { get; set; }

        public AllTimeChillersViewModel()
        {
            alltime = new List<Category>();
            MenuCategoryBusiness menuCategoryBusiness = new MenuCategoryBusiness();
            alltime = menuCategoryBusiness.AllTimeBl();
        }
    }
}
