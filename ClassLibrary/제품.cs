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
    
    public partial class 제품
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 제품()
        {
            this.수주 = new HashSet<수주>();
            this.수주확인리스트 = new HashSet<수주확인리스트>();
            this.자재명세서 = new HashSet<자재명세서>();
            this.작업완료지시 = new HashSet<작업완료지시>();
            this.작업완료확인서 = new HashSet<작업완료확인서>();
            this.작업지시 = new HashSet<작업지시>();
            this.작업지시리스트 = new HashSet<작업지시리스트>();
            this.작업지시서 = new HashSet<작업지시서>();
        }
    
        public int 제품번호 { get; set; }
        public string 제품명 { get; set; }
        public int 안전재고량 { get; set; }
        public int 자재명세번호 { get; set; }
        public int 재고량 { get; set; }
        public int 제품단가 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<수주> 수주 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<수주확인리스트> 수주확인리스트 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<자재명세서> 자재명세서 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<작업완료지시> 작업완료지시 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<작업완료확인서> 작업완료확인서 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<작업지시> 작업지시 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<작업지시리스트> 작업지시리스트 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<작업지시서> 작업지시서 { get; set; }
    }
}
