//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace procluentdbfirstuygulama
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vatandaş
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vatandaş()
        {
            this.Vergiler = new HashSet<Vergiler>();
        }
    
        public int kisiNo { get; set; }
        public Nullable<int> tc { get; set; }
        public string meslek { get; set; }
        public string adres { get; set; }
        public string telefon { get; set; }
        public string mail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vergiler> Vergiler { get; set; }
    }
}
