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
    
    public partial class tbBookRoom
    {
        public int idbookRoom { get; set; }
        public int idRoom { get; set; }
        public int idClass { get; set; }
        public Nullable<int> idUser { get; set; }
        public int idTimeFrame { get; set; }
        public System.DateTime dateBook { get; set; }
        public string note { get; set; }
    
        public virtual tbClass tbClass { get; set; }
        public virtual tbRoom tbRoom { get; set; }
        public virtual tbTimeFrame tbTimeFrame { get; set; }
        public virtual tbUser tbUser { get; set; }
    }
}
