﻿using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  public interface IFoodOnHoop
    {
        void SignUpB(FoodOnHoopModel ifoodOn);
        void SaveDataBl(Category category);


    }
}