//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MOLUX.Models
{
    using System;
    
    public partial class web_getChildCateNews_Result
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string UrlCustom { get; set; }
        public Nullable<int> Orders { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDesc { get; set; }
        public Nullable<bool> IsShow { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> Type { get; set; }
    }
}