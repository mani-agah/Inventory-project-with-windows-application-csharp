//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace anbardari2
{
    using System;
    using System.Collections.Generic;
    
    public partial class FactorTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FactorTbl()
        {
            this.FactorDetailsTbls = new HashSet<FactorDetailsTbl>();
        }
    
        public int FactorId { get; set; }
        public string FactorCode { get; set; }
        public System.DateTime FactorSubmitTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactorDetailsTbl> FactorDetailsTbls { get; set; }
    }
}