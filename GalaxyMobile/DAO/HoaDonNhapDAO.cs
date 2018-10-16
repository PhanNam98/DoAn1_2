using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAO
{
    public class HoaDonNhapDAO
    {
        public HoaDonNhapHang GetHoaDonNhap(string id)
        {
            using (GalaxyMobileEntities db = new GalaxyMobileEntities())
            {
                return db.HoaDonNhapHangs.Where(p => p.MaHoaDonNH == id).Single();
            }
        }
        public List<HoaDonNhapHang> GetAllHoaDonNhap()
        {
            using (GalaxyMobileEntities db = new GalaxyMobileEntities())
            {
                return db.HoaDonNhapHangs.ToList();
            }
        }
    }
}
