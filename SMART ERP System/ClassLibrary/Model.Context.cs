﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ERPEntities : DbContext
    {
        public ERPEntities()
            : base("name=ERPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<거래처> 거래처 { get; set; }
        public virtual DbSet<거래처구분> 거래처구분 { get; set; }
        public virtual DbSet<경비구분> 경비구분 { get; set; }
        public virtual DbSet<계정과목> 계정과목 { get; set; }
        public virtual DbSet<계정과목그룹> 계정과목그룹 { get; set; }
        public virtual DbSet<고정자산> 고정자산 { get; set; }
        public virtual DbSet<공급업체> 공급업체 { get; set; }
        public virtual DbSet<공제별세부사항> 공제별세부사항 { get; set; }
        public virtual DbSet<과세별세액> 과세별세액 { get; set; }
        public virtual DbSet<근로소득> 근로소득 { get; set; }
        public virtual DbSet<근로소득별세부사항> 근로소득별세부사항 { get; set; }
        public virtual DbSet<급_상여지급_급여구분> 급_상여지급_급여구분 { get; set; }
        public virtual DbSet<급_상여지급_일자등록> 급_상여지급_일자등록 { get; set; }
        public virtual DbSet<급_상여지급_직종및_급여형태> 급_상여지급_직종및_급여형태 { get; set; }
        public virtual DbSet<급여입력및계산> 급여입력및계산 { get; set; }
        public virtual DbSet<급여정보> 급여정보 { get; set; }
        public virtual DbSet<급여지급대상> 급여지급대상 { get; set; }
        public virtual DbSet<급여형태> 급여형태 { get; set; }
        public virtual DbSet<기간비용> 기간비용 { get; set; }
        public virtual DbSet<기간비용계산방법> 기간비용계산방법 { get; set; }
        public virtual DbSet<기준설정> 기준설정 { get; set; }
        public virtual DbSet<납품업체> 납품업체 { get; set; }
        public virtual DbSet<메뉴별권한설정> 메뉴별권한설정 { get; set; }
        public virtual DbSet<발주리스트> 발주리스트 { get; set; }
        public virtual DbSet<발주서> 발주서 { get; set; }
        public virtual DbSet<발주확인리스트> 발주확인리스트 { get; set; }
        public virtual DbSet<발주확인서> 발주확인서 { get; set; }
        public virtual DbSet<부가세신고서> 부가세신고서 { get; set; }
        public virtual DbSet<부서등록> 부서등록 { get; set; }
        public virtual DbSet<분기별예산> 분기별예산 { get; set; }
        public virtual DbSet<사업장관할세무서> 사업장관할세무서 { get; set; }
        public virtual DbSet<사업장기본등록사항> 사업장기본등록사항 { get; set; }
        public virtual DbSet<사업장등록> 사업장등록 { get; set; }
        public virtual DbSet<사용자권한설정> 사용자권한설정 { get; set; }
        public virtual DbSet<사원등록> 사원등록 { get; set; }
        public virtual DbSet<사원인적정보> 사원인적정보 { get; set; }
        public virtual DbSet<사원정보> 사원정보 { get; set; }
        public virtual DbSet<사원정보등록> 사원정보등록 { get; set; }
        public virtual DbSet<상각방법> 상각방법 { get; set; }
        public virtual DbSet<세무유형> 세무유형 { get; set; }
        public virtual DbSet<소득_세액공제환경설정> 소득_세액공제환경설정 { get; set; }
        public virtual DbSet<수주> 수주 { get; set; }
        public virtual DbSet<수주확인리스트> 수주확인리스트 { get; set; }
        public virtual DbSet<수주확인서> 수주확인서 { get; set; }
        public virtual DbSet<시스템환경설정> 시스템환경설정 { get; set; }
        public virtual DbSet<업무용승용차_차량등록> 업무용승용차_차량등록 { get; set; }
        public virtual DbSet<역추적> 역추적 { get; set; }
        public virtual DbSet<예산> 예산 { get; set; }
        public virtual DbSet<인사_급여환경설정> 인사_급여환경설정 { get; set; }
        public virtual DbSet<자금계획달력> 자금계획달력 { get; set; }
        public virtual DbSet<자금과목> 자금과목 { get; set; }
        public virtual DbSet<자재> 자재 { get; set; }
        public virtual DbSet<자재명세서> 자재명세서 { get; set; }
        public virtual DbSet<작업완료지시> 작업완료지시 { get; set; }
        public virtual DbSet<작업완료확인서> 작업완료확인서 { get; set; }
        public virtual DbSet<작업지시> 작업지시 { get; set; }
        public virtual DbSet<작업지시리스트> 작업지시리스트 { get; set; }
        public virtual DbSet<작업지시서> 작업지시서 { get; set; }
        public virtual DbSet<전표> 전표 { get; set; }
        public virtual DbSet<전표리스트> 전표리스트 { get; set; }
        public virtual DbSet<제품> 제품 { get; set; }
        public virtual DbSet<코드> 코드 { get; set; }
        public virtual DbSet<코드분류> 코드분류 { get; set; }
        public virtual DbSet<퇴직공제항목> 퇴직공제항목 { get; set; }
        public virtual DbSet<퇴직기준설명> 퇴직기준설명 { get; set; }
        public virtual DbSet<퇴직지급항목> 퇴직지급항목 { get; set; }
        public virtual DbSet<품목정보> 품목정보 { get; set; }
        public virtual DbSet<환경요소> 환경요소 { get; set; }
        public virtual DbSet<회사기본등록사항> 회사기본등록사항 { get; set; }
        public virtual DbSet<회사등록> 회사등록 { get; set; }
    }
}