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
    
    public partial class hbundle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hbundle()
        {
            this.dbundles = new HashSet<dbundle>();
            this.transDiskons = new HashSet<transDiskon>();
        }
    
        public string kode_bundle { get; set; }
        public Nullable<System.DateTime> tanggal_mulai { get; set; }
        public Nullable<System.DateTime> tanggal_selesai { get; set; }
        public string keterangan { get; set; }
        public Nullable<int> harga_before { get; set; }
        public Nullable<int> potongan { get; set; }
        public Nullable<int> harga_after { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbundle> dbundles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transDiskon> transDiskons { get; set; }
    }
}
