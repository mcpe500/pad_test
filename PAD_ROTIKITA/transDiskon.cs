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
    
    public partial class transDiskon
    {
        public string transDiskon_id { get; set; }
        public string kode_diskon { get; set; }
        public string htrans_id { get; set; }
        public Nullable<int> potongan { get; set; }
        public string keterangan { get; set; }
    
        public virtual diskon diskon { get; set; }
        public virtual hbundle hbundle { get; set; }
        public virtual htran htran { get; set; }
    }
}
