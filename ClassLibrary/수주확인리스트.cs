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
    
    public partial class 수주확인리스트
    {
        public int 수주확인번호 { get; set; }
        public int 제품번호 { get; set; }
        public int 수량 { get; set; }
        public int 수주여부 { get; set; }
    
        public virtual 수주확인서 수주확인서 { get; set; }
        public virtual 제품 제품 { get; set; }
    }
}
