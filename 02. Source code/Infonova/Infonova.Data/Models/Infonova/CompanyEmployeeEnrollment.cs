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
    
    public partial class CompanyEmployeeEnrollment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyEmployeeEnrollment()
        {
            this.EmployeeGroups = new HashSet<EmployeeGroup>();
        }
    
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateEmployed { get; set; }
        public Nullable<System.DateTime> DateResignation { get; set; }
        public bool IsDefault { get; set; }
        public bool IsLoginAllowed { get; set; }
        public string JobName { get; set; }
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeGroup> EmployeeGroups { get; set; }
    }
}