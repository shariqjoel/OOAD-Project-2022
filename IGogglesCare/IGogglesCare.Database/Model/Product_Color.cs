//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IGogglesCare.Database.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_Color
    {
        public long Product_ColorId { get; set; }
        public Nullable<long> ColorId { get; set; }
        public Nullable<long> ProductId { get; set; }
    
        public virtual Color Color { get; set; }
        public virtual Product Product { get; set; }
    }
}
