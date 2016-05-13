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
    
    public partial class Collaborator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Collaborator()
        {
            this.ArticlePackages = new HashSet<ArticlePackage>();
            this.CollaboratorArticles = new HashSet<CollaboratorArticle>();
            this.CollaboratorLocations = new HashSet<CollaboratorLocation>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
            this.SaleOrders = new HashSet<SaleOrder>();
        }
    
        public int Id { get; set; }
        public string NameFull { get; set; }
        public string NameFriendly { get; set; }
        public string CodeAlpha2Chars { get; set; }
        public string CodeAlpha3Chars { get; set; }
        public bool IsRelationCustomer { get; set; }
        public bool IsRelationSupplier { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticlePackage> ArticlePackages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollaboratorArticle> CollaboratorArticles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollaboratorLocation> CollaboratorLocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
    }
}