//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class 발주서
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 발주서()
        {
            this.발주리스트 = new HashSet<발주리스트>();
        }
    
        public int 발주번호 { get; set; }
        public int 공급업체번호 { get; set; }
        public System.DateTime 주문날짜 { get; set; }
        public System.DateTime 납기일 { get; set; }
    
        public virtual 공급업체 공급업체 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<발주리스트> 발주리스트 { get; set; }
    }
}
