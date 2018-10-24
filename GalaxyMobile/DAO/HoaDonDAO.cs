using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAO
{
    public class HoaDonDAO
    {
        public List<HoaDon> GetAllHoaDon()
        {
            using (GalaxyMobileEntities dbs = new GalaxyMobileEntities())
            {
                return dbs.HoaDons.ToList();
            }
        }
        public List<HoaDon> GetAllHoaDonByMaCH(string maCH)
        {
            using (GalaxyMobileEntities dbs = new GalaxyMobileEntities())
            {
                return dbs.HoaDons.Where(p=>p.MaCuaHang==maCH).ToList();
            }
        }
        public void ThemHoaDon(HoaDon hd)
        {
            using (GalaxyMobileEntities dbs = new GalaxyMobileEntities())
            {
                dbs.HoaDons.Add(hd);
                dbs.SaveChanges();
            }
        }
        public void XoaHoaDon(HoaDon hd)
        {
            using (GalaxyMobileEntities dbs = new GalaxyMobileEntities())
            {
                dbs.HoaDons.Attach(hd);
                dbs.HoaDons.Remove(hd);
                dbs.SaveChanges();
            }
        }
        public void ThanhToanHoaDon(string idhd, string idch)
        {
            using (GalaxyMobileEntities dbs = new GalaxyMobileEntities())
            {
                var ct = dbs.ChiTietHoaDons.Where(p => p.MaHoaDon == idhd && p.MaCuaHang == idch).ToList();
                foreach(ChiTietHoaDon c in ct)
                {
                    dbs.USP_ThayDoiSoLuongChiTietSP(c.MaKieu, -c.SoluongSP);
                    dbs.USP_ThemSL_KhoHangByMaKieuByMaCH(c.MaKieu, idch, -c.SoluongSP);
                }
                var hd = dbs.HoaDons.Where(p => p.MaHoaDon == idhd && p.MaCuaHang == idch).SingleOrDefault();
                dbs.HoaDons.Attach(hd);
                hd.TinhTrang = 1;
                dbs.Entry(hd).State = System.Data.Entity.EntityState.Modified;
                dbs.SaveChanges();
            }
        }
        public void LayHangHoaDon(string idhd, string idch)
        {
            using (GalaxyMobileEntities dbs = new GalaxyMobileEntities())
            {
                var ct = dbs.ChiTietHoaDons.Where(p => p.MaHoaDon == idhd && p.MaCuaHang == idch).ToList();
                foreach (ChiTietHoaDon c in ct)
                {
                    dbs.USP_ThayDoiSoLuongChiTietSP(c.MaKieu, -c.SoluongSP);
                    dbs.USP_ThemSL_KhoHangByMaKieuByMaCH(c.MaKieu, idch, -c.SoluongSP);
                }
               
            }
        }
        public void TraHangHoaDon(string idhd, string idch)
        {
            using (GalaxyMobileEntities dbs = new GalaxyMobileEntities())
            {
                var ct = dbs.ChiTietHoaDons.Where(p => p.MaHoaDon == idhd && p.MaCuaHang == idch).ToList();
                foreach (ChiTietHoaDon c in ct)
                {
                    dbs.USP_ThayDoiSoLuongChiTietSP(c.MaKieu, c.SoluongSP);
                    dbs.USP_ThemSL_KhoHangByMaKieuByMaCH(c.MaKieu, idch, c.SoluongSP);
                }

            }
        }
        public void DaThanhToan(string idhd, string idch)
        {
            using (GalaxyMobileEntities dbs = new GalaxyMobileEntities())
            {
                
                var hd = dbs.HoaDons.Where(p => p.MaHoaDon == idhd && p.MaCuaHang == idch).SingleOrDefault();
                dbs.HoaDons.Attach(hd);
                hd.TinhTrang = 1;
                dbs.Entry(hd).State = System.Data.Entity.EntityState.Modified;
                dbs.SaveChanges();
            }
        }

    }
}
