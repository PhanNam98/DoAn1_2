using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;
namespace BUS
{
    public class HoaDonBUS
    {
        static HoaDonDAO db;
        static HoaDonBUS()
        {
            db = new HoaDonDAO();
        }
        public static List<HoaDon> GetAllHoaDon()
        {
            return db.GetAllHoaDon();
        }
        public static List<HoaDon> GetAllHoaDonByMaCH(string maCH)
        {
            return db.GetAllHoaDonByMaCH(maCH);
        }
        public static void ThemHoaDon(HoaDon hd)
        {
            db.ThemHoaDon(hd);
        }
        public static void XoaHoaDon(HoaDon hd)
        {
            db.XoaHoaDon(hd);
        }
        public static void ThanhToanHoaDon(string idhd, string idch)
        {
            db.ThanhToanHoaDon(idhd, idch);
        }
        public static void LayHangHoaDon(string idhd, string idch)
        {
            db.LayHangHoaDon(idhd, idch);

        }
        public static void TraHangHoaDon(string idhd, string idch)
        {
            db.TraHangHoaDon(idhd, idch);

        }
        public static void DaThanhToan(string idhd, string idch)
        {
            db.DaThanhToan(idhd, idch);
        }
    }
}
