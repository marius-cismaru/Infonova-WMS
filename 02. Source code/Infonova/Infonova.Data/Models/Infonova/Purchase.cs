//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonova.Data.Models.Infonova
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchase
    {
        public int Id { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int CompanyId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int EmployeeId { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
