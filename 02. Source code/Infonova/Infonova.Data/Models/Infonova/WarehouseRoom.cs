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
    
    public partial class WarehouseRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WarehouseRoom()
        {
            this.WarehouseRows = new HashSet<WarehouseRow>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Priority { get; set; }
        public double TemperatureRangeMin { get; set; }
        public double TemperatureRangeMax { get; set; }
        public int WarehouseId { get; set; }
    
        public virtual Warehouse Warehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarehouseRow> WarehouseRows { get; set; }
    }
}
