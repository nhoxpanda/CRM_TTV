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
    
    public partial class tbUserFileAttach
    {
        public int idUserFileAttach { get; set; }
        public Nullable<int> idUser { get; set; }
        public string fileName { get; set; }
        public Nullable<System.DateTime> postDate { get; set; }
        public Nullable<int> fileType { get; set; }
        public Nullable<int> byUser { get; set; }
        public Nullable<int> roleID { get; set; }
        public string fileRole { get; set; }
        public string password { get; set; }
        public string note { get; set; }
    
        public virtual tbCategory tbCategory { get; set; }
        public virtual tbRole tbRole { get; set; }
        public virtual tbUser tbUser { get; set; }
        public virtual tbUser tbUser1 { get; set; }
    }
}