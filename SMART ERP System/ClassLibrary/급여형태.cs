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
    
    public partial class 급여형태
    {
        public int 급여형태코드번호 { get; set; }
        public string 급여형태이름 { get; set; }
        public int 급_상여지급_직종코드 { get; set; }
        public int 사원코드번호 { get; set; }
    
        public virtual 급_상여지급_직종및_급여형태 급_상여지급_직종및_급여형태 { get; set; }
    }
}
