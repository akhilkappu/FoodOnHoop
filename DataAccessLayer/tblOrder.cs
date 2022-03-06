//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrder()
        {
            this.tblAdminAccesses = new HashSet<tblAdminAccess>();
        }
    
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int MenuID { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime Date { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemTotalPrice { get; set; }
        public string PaymentStatus { get; set; }
        public string FoodStatus { get; set; }
    
        public virtual tblCustomer tblCustomer { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual tblMenu tblMenu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAdminAccess> tblAdminAccesses { get; set; }
    }
}