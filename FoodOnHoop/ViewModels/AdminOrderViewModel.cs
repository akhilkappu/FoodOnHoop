using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOnHoop.ViewModels
{
   public class AdminOrderViewModel : BaseViewModel
        {
            public AdminOrder adminOrder;
            public List<AdminOrder> values { get; set; }
            public AdminOrderViewModel()
            {
                values = new List<AdminOrder>();
                AdminOrderBusiness adminOrderBusiness = new AdminOrderBusiness();
                values = adminOrderBusiness.AdminOrderBL();
            }

        }
   
}
