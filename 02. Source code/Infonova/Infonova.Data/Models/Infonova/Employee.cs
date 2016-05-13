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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.CompanyEmployeeEnrollments = new HashSet<CompanyEmployeeEnrollment>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
            this.Purchases = new HashSet<Purchase>();
            this.SaleOrders = new HashSet<SaleOrder>();
        }
    
        public int Id { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string NameMiddle { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateBirth { get; set; }
        public string PhoneNumbers { get; set; }
        public string Emails { get; set; }
        public string Address { get; set; }
        public string IDSeriesAndNumber { get; set; }
        public string PersonalNumber { get; set; }
        public byte[] Picture { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public bool IsLoginToDomain { get; set; }
        public string LoginDomain { get; set; }
        public int CountryId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyEmployeeEnrollment> CompanyEmployeeEnrollments { get; set; }
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase> Purchases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
    }
}