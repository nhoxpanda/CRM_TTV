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
    using System.Collections.Generic;
    
    public partial class web_Cart
    {
        public int Id { get; set; }
        public string CartId { get; set; }
        public int ItemId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<int> ColorId { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> SizeId { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual web_SizeColor web_SizeColor { get; set; }
        public virtual web_SizeColor web_SizeColor1 { get; set; }
    }
}