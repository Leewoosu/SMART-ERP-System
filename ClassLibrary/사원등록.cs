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
    
    public partial class 사원등록
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 사원등록()
        {
            this.부서등록 = new HashSet<부서등록>();
        }
    
        public string 사원코드 { get; set; }
        public string 사원명 { get; set; }
        public string 사원명_영문_ { get; set; }
        public string 부서코드 { get; set; }
        public System.DateTime 입사일 { get; set; }
        public Nullable<System.DateTime> 퇴사일 { get; set; }
        public bool 인사입력방식 { get; set; }
        public Nullable<bool> 회계입력방식 { get; set; }
        public string 조회권한 { get; set; }
        public bool 품의서권한 { get; set; }
        public bool 검수조서권한 { get; set; }
        public string 비상연락망 { get; set; }
        public string 암호 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<부서등록> 부서등록 { get; set; }
        public virtual 사원인적정보 사원인적정보 { get; set; }
    }
}
