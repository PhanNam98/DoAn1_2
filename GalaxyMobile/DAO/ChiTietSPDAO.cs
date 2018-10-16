using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAO
{
    public class ChiTietSPDAO
    {
        public List<MauSP> GetAllMauSP()
        {
            using (GalaxyMobileEntities db = new GalaxyMobileEntities())
            {
                return db.MauSPs.ToList();
            }
        }
        public List<ChiTietSP> GetChiTietSPByIDSP(string id)
        {
            using (GalaxyMobileEntities db = new GalaxyMobileEntities())
            {
                return db.ChiTietSPs.Where(p=>p.MaSP==id).ToList();
            }
        }
        public ChiTietSP Get1ChiTietSPByIDKieuSP(string id)
        {
            using (GalaxyMobileEntities db = new GalaxyMobileEntities())
            {
                return db.ChiTietSPs.Where(p => p.MaKieu == id).SingleOrDefault();
            }
        }
        public SanPham GetMaSPByIDKieuSP(string id)
        {
            using (GalaxyMobileEntities db = new GalaxyMobileEntities())
            {
                string idsp = db.ChiTietSPs.Where(p => p.MaKieu == id).Select(o => o.MaSP).Single();
                return db.SanPhams.Where(p => p.MaSP == idsp).Single();
                             
            }
        }
        public USP_GETAllInfoSP_Result GetMaSPByMaKieuSP(string id)
        {
            using (GalaxyMobileEntities db = new GalaxyMobileEntities())
            {
                return db.USP_GETAllInfoSP(id).Single();
            }
        }


    }

}
