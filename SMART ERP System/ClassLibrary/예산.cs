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
    
    public partial class 예산
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 예산()
        {
            this.분기별예산 = new HashSet<분기별예산>();
        }
    
        public int 예산코드 { get; set; }
        public System.DateTime 신청연도 { get; set; }
        public string 예산과목명 { get; set; }
        public int 총액 { get; set; }
        public int C1분기_금액 { get; set; }
        public int C2분기_금액 { get; set; }
        public int C3분기_금액 { get; set; }
        public int C4분기_금액 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<분기별예산> 분기별예산 { get; set; }
    }
}
