//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM_TTV
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbRegion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbRegion()
        {
            this.tbCompanies = new HashSet<tbCompany>();
            this.tbQueues = new HashSet<tbQueue>();
            this.tbRegion1 = new HashSet<tbRegion>();
            this.tbUsers = new HashSet<tbUser>();
            this.tbUsers1 = new HashSet<tbUser>();
        }
    
        public int idRegion { get; set; }
        public Nullable<int> parentID { get; set; }
        public int type { get; set; }
        public Nullable<int> localities { get; set; }
        public string name { get; set; }
        public Nullable<int> sort { get; set; }
        public bool del { get; set; }
        public string icon { get; set; }
    
        public virtual tbCategory tbCategory { get; set; }
        public virtual tbCategory tbCategory1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCompany> tbCompanies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbQueue> tbQueues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRegion> tbRegion1 { get; set; }
        public virtual tbRegion tbRegion2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbUser> tbUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbUser> tbUsers1 { get; set; }
    }
}