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
    
    public partial class 사업장기본등록사항
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 사업장기본등록사항()
        {
            this.사업장관할세무서 = new HashSet<사업장관할세무서>();
        }
    
        public int 사업장등록번호 { get; set; }
        public int 법인등록번호 { get; set; }
        public string 대표자명 { get; set; }
        public int 사업장우편번호 { get; set; }
        public string 사업장주소 { get; set; }
        public string 사업장번지 { get; set; }
        public string 전화번호 { get; set; }
        public string FAX_번호 { get; set; }
        public string 업태 { get; set; }
        public string 종목 { get; set; }
        public System.DateTime 개업년월일 { get; set; }
        public Nullable<System.DateTime> 폐업년월일 { get; set; }
        public int 사업장등록코드 { get; set; }
        public System.DateTime 회계기간 { get; set; }
    
        public virtual 부가세신고서 부가세신고서 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<사업장관할세무서> 사업장관할세무서 { get; set; }
        public virtual 사업장등록 사업장등록 { get; set; }
    }
}
