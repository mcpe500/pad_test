//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PAD_ROTIKITA
{
    using System;
    using System.Collections.Generic;
    
    public partial class dtran
    {
        public string dtrans_id { get; set; }
        public string htrans_id { get; set; }
        public string kode_roti { get; set; }
        public Nullable<int> qty { get; set; }
        public Nullable<int> harga { get; set; }
        public Nullable<int> subtotal { get; set; }
    
        public virtual htran htran { get; set; }
        public virtual roti roti { get; set; }
    }
}
