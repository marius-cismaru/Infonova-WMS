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
    
    public partial class EmployeeGroupPermission
    {
        public int Id { get; set; }
        public int Module { get; set; }
        public int AccessLevel { get; set; }
        public int EmployeeGroupId { get; set; }
    
        public virtual EmployeeGroup EmployeeGroup { get; set; }
    }
}
