﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GalaxyMobileEntities : DbContext
    {
        public GalaxyMobileEntities()
            : base("name=GalaxyMobileEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CuaHang> CuaHangs { get; set; }
        public virtual DbSet<DongSanPham> DongSanPhams { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HSX> HSXes { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiNV> LoaiNVs { get; set; }
        public virtual DbSet<LoaiSP> LoaiSPs { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
        public virtual DbSet<MauSP> MauSPs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<KhoHang> KhoHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<ChiTietSP> ChiTietSPs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ChiTietHDNhapHang> ChiTietHDNhapHangs { get; set; }
        public virtual DbSet<GiaoHang> GiaoHangs { get; set; }
        public virtual DbSet<HoaDonNhapHang> HoaDonNhapHangs { get; set; }
    
        public virtual ObjectResult<CuaHang> USP_GetAllCuaHang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CuaHang>("USP_GetAllCuaHang");
        }
    
        public virtual ObjectResult<CuaHang> USP_GetAllCuaHang(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CuaHang>("USP_GetAllCuaHang", mergeOption);
        }
    
        public virtual ObjectResult<KhoHang> USP_GetAllKhoHang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KhoHang>("USP_GetAllKhoHang");
        }
    
        public virtual ObjectResult<KhoHang> USP_GetAllKhoHang(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KhoHang>("USP_GetAllKhoHang", mergeOption);
        }
    
        public virtual ObjectResult<NhanVien> GetAllNV()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhanVien>("GetAllNV");
        }
    
        public virtual ObjectResult<NhanVien> GetAllNV(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhanVien>("GetAllNV", mergeOption);
        }
    
        public virtual ObjectResult<LoaiNV> GetLNV()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LoaiNV>("GetLNV");
        }
    
        public virtual ObjectResult<LoaiNV> GetLNV(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LoaiNV>("GetLNV", mergeOption);
        }
    
        public virtual int spThemNV(string manv, string macuahang, string maloainv, string tennv, string gioitinh, string diachi, string sdt, Nullable<decimal> luong)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var macuahangParameter = macuahang != null ?
                new ObjectParameter("macuahang", macuahang) :
                new ObjectParameter("macuahang", typeof(string));
    
            var maloainvParameter = maloainv != null ?
                new ObjectParameter("maloainv", maloainv) :
                new ObjectParameter("maloainv", typeof(string));
    
            var tennvParameter = tennv != null ?
                new ObjectParameter("tennv", tennv) :
                new ObjectParameter("tennv", typeof(string));
    
            var gioitinhParameter = gioitinh != null ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var luongParameter = luong.HasValue ?
                new ObjectParameter("luong", luong) :
                new ObjectParameter("luong", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemNV", manvParameter, macuahangParameter, maloainvParameter, tennvParameter, gioitinhParameter, diachiParameter, sdtParameter, luongParameter);
        }
    
        public virtual int updateNV(string manv, string macuahang, string maloainv, string tennv, string gioitinh, string diachi, string sdt, Nullable<decimal> luong)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var macuahangParameter = macuahang != null ?
                new ObjectParameter("macuahang", macuahang) :
                new ObjectParameter("macuahang", typeof(string));
    
            var maloainvParameter = maloainv != null ?
                new ObjectParameter("maloainv", maloainv) :
                new ObjectParameter("maloainv", typeof(string));
    
            var tennvParameter = tennv != null ?
                new ObjectParameter("tennv", tennv) :
                new ObjectParameter("tennv", typeof(string));
    
            var gioitinhParameter = gioitinh != null ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var luongParameter = luong.HasValue ?
                new ObjectParameter("luong", luong) :
                new ObjectParameter("luong", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateNV", manvParameter, macuahangParameter, maloainvParameter, tennvParameter, gioitinhParameter, diachiParameter, sdtParameter, luongParameter);
        }
    
        public virtual int delNV(string manv)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delNV", manvParameter);
        }
    
        public virtual int spDelLNV(string maloai)
        {
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDelLNV", maloaiParameter);
        }
    
        public virtual int spInsertLNV(string maloai, string tenloai)
        {
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var tenloaiParameter = tenloai != null ?
                new ObjectParameter("tenloai", tenloai) :
                new ObjectParameter("tenloai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertLNV", maloaiParameter, tenloaiParameter);
        }
    
        public virtual int spUpdateLNV(string maloai, string tenloai)
        {
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var tenloaiParameter = tenloai != null ?
                new ObjectParameter("tenloai", tenloai) :
                new ObjectParameter("tenloai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateLNV", maloaiParameter, tenloaiParameter);
        }
    
        public virtual int spDelKH(string ma)
        {
            var maParameter = ma != null ?
                new ObjectParameter("ma", ma) :
                new ObjectParameter("ma", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDelKH", maParameter);
        }
    
        public virtual int spInsertKH(string ma, string ten, string diachi, string sdt)
        {
            var maParameter = ma != null ?
                new ObjectParameter("ma", ma) :
                new ObjectParameter("ma", typeof(string));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertKH", maParameter, tenParameter, diachiParameter, sdtParameter);
        }
    
        public virtual int spUpdateKH(string ma, string ten, string diachi, string sdt)
        {
            var maParameter = ma != null ?
                new ObjectParameter("ma", ma) :
                new ObjectParameter("ma", typeof(string));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateKH", maParameter, tenParameter, diachiParameter, sdtParameter);
        }
    
        public virtual ObjectResult<KhachHang> spGetKH()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KhachHang>("spGetKH");
        }
    
        public virtual ObjectResult<KhachHang> spGetKH(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KhachHang>("spGetKH", mergeOption);
        }
    
        public virtual ObjectResult<USP_GETAllInfoSP_Result> USP_GETAllInfoSP(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GETAllInfoSP_Result>("USP_GETAllInfoSP", idParameter);
        }
    
        public virtual ObjectResult<USP_GETAllInfoSPNew_Result> USP_GETAllInfoSPNew(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GETAllInfoSPNew_Result>("USP_GETAllInfoSPNew", idParameter);
        }
    
        public virtual int USP_DeleteCTSP(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_DeleteCTSP", idParameter);
        }
    
        public virtual int USP_ThayDoiGiaChiTietSP(string id, Nullable<decimal> gia)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var giaParameter = gia.HasValue ?
                new ObjectParameter("Gia", gia) :
                new ObjectParameter("Gia", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_ThayDoiGiaChiTietSP", idParameter, giaParameter);
        }
    
        public virtual int USP_ThayDoiSoLuongChiTietSP(string id, Nullable<int> sl)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var slParameter = sl.HasValue ?
                new ObjectParameter("sl", sl) :
                new ObjectParameter("sl", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_ThayDoiSoLuongChiTietSP", idParameter, slParameter);
        }
    
        public virtual ObjectResult<ChiTietSP> USP_GetCTSPOderByMaCHByMaKieu(string idch, string id)
        {
            var idchParameter = idch != null ?
                new ObjectParameter("idch", idch) :
                new ObjectParameter("idch", typeof(string));
    
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ChiTietSP>("USP_GetCTSPOderByMaCHByMaKieu", idchParameter, idParameter);
        }
    
        public virtual ObjectResult<ChiTietSP> USP_GetCTSPOderByMaCHByMaKieu(string idch, string id, MergeOption mergeOption)
        {
            var idchParameter = idch != null ?
                new ObjectParameter("idch", idch) :
                new ObjectParameter("idch", typeof(string));
    
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ChiTietSP>("USP_GetCTSPOderByMaCHByMaKieu", mergeOption, idchParameter, idParameter);
        }
    
        public virtual ObjectResult<ChiTietSP> USP_GetCTSPOderByMaCHByMaSP(string idch, string id)
        {
            var idchParameter = idch != null ?
                new ObjectParameter("idch", idch) :
                new ObjectParameter("idch", typeof(string));
    
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ChiTietSP>("USP_GetCTSPOderByMaCHByMaSP", idchParameter, idParameter);
        }
    
        public virtual ObjectResult<ChiTietSP> USP_GetCTSPOderByMaCHByMaSP(string idch, string id, MergeOption mergeOption)
        {
            var idchParameter = idch != null ?
                new ObjectParameter("idch", idch) :
                new ObjectParameter("idch", typeof(string));
    
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ChiTietSP>("USP_GetCTSPOderByMaCHByMaSP", mergeOption, idchParameter, idParameter);
        }
    
        public virtual int USP_PhanChiaSP(string id, string idNhap, string idPP, Nullable<int> sL)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var idNhapParameter = idNhap != null ?
                new ObjectParameter("idNhap", idNhap) :
                new ObjectParameter("idNhap", typeof(string));
    
            var idPPParameter = idPP != null ?
                new ObjectParameter("idPP", idPP) :
                new ObjectParameter("idPP", typeof(string));
    
            var sLParameter = sL.HasValue ?
                new ObjectParameter("SL", sL) :
                new ObjectParameter("SL", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_PhanChiaSP", idParameter, idNhapParameter, idPPParameter, sLParameter);
        }
    
        public virtual int USP_ThemSL_KhoHangByMaKieuByMaCH(string id, string idCH, Nullable<int> sL)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var idCHParameter = idCH != null ?
                new ObjectParameter("idCH", idCH) :
                new ObjectParameter("idCH", typeof(string));
    
            var sLParameter = sL.HasValue ?
                new ObjectParameter("SL", sL) :
                new ObjectParameter("SL", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_ThemSL_KhoHangByMaKieuByMaCH", idParameter, idCHParameter, sLParameter);
        }
    
        public virtual int USP_ThayDoiSLChiTietHoaDon(string idhd, string idch, string id, Nullable<int> sL)
        {
            var idhdParameter = idhd != null ?
                new ObjectParameter("idhd", idhd) :
                new ObjectParameter("idhd", typeof(string));
    
            var idchParameter = idch != null ?
                new ObjectParameter("idch", idch) :
                new ObjectParameter("idch", typeof(string));
    
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var sLParameter = sL.HasValue ?
                new ObjectParameter("SL", sL) :
                new ObjectParameter("SL", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_ThayDoiSLChiTietHoaDon", idhdParameter, idchParameter, idParameter, sLParameter);
        }
    }
}
