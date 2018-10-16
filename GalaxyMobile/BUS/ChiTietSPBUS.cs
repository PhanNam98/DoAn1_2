using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;
namespace BUS
{
    public class ChiTietSPBUS
    {
        static ChiTietSPDAO db;
        static ChiTietSPBUS()
        {
            db = new ChiTietSPDAO();
        }
        public static List<MauSP> GetAllMauSP()
        {
            return db.GetAllMauSP();
        }
        public static List<ChiTietSP> GetChiTietSPByIDSP(string id)
        {
            return db.GetChiTietSPByIDSP(id);
        }
        public static ChiTietSP Get1ChiTietSPByIDMaKieu(string id)
        {
            return db.Get1ChiTietSPByIDKieuSP(id);
        }
        public static SanPham GetMaSPByIDKieuSP(string id)
        {
            return db.GetMaSPByIDKieuSP(id);
        }
        public static USP_GETAllInfoSP_Result GetMaSPByMaKieuSP(string id)
        {
            return db.GetMaSPByMaKieuSP(id);
        }
    }
}
