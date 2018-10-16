using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Model;
namespace GalaxyMobile
{
    public partial class frmChiTietHoaDonNhapHang : Form
    {
        public frmChiTietHoaDonNhapHang(string idHd,string manv, bool isChange)
        {
            InitializeComponent();
            IDHDNH = idHd;
            IsChange = isChange;
        }
        private string IDHDNH;
        private HoaDonNhapHang hdn;
        private bool IsChange;
        private void frmChiTietHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            LoadCTHDNH();
            LoadComboBox();
        }
        #region methods
        void LoadCTHDNH()
        {
            chiTietHDNhapHangBindingSource.DataSource = ChiTietHoaDonNhapHangBUS.GetAllSanPham(IDHDNH);
            hdn = HoaDonNhapHangBUS.GetGetHoaDonNhapByID(IDHDNH);
            txtBoxMaHDNH.Text = hdn.MaHoaDonNH;
            txtBoxMaNVNH.Text = hdn.MaNV;
            dateNhapHang.Value = hdn.NgayNhapHang;
        }
        void LoadComboBox()
        {
            cmBoxDSP.DataSource = DongSanPhamBUS.GetAllDongSP();
            cmBoxDSP.DisplayMember = "TenDong";
            cmBoxDSP.ValueMember = "MaDSP";
            cmBoxNSX.DataSource = HSXBUS.GetAllHSX();
            cmBoxNSX.ValueMember = "MaHSX";
            cmBoxNSX.DisplayMember = "TenHSX";
            cmBoxLoaiSP.DataSource = LoaiSPBUS.GetAllLoaiSP();
            cmBoxLoaiSP.DisplayMember = "TenLSP";
            cmBoxLoaiSP.ValueMember = "MaLSP";
        }
        #endregion

        #region events
        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                int r = dgvNhapHang.CurrentCell.RowIndex;
                string id = dgvNhapHang.Rows[r].Cells[0].Value.ToString();
                USP_GETAllInfoSP_Result sp = ChiTietSPBUS.GetMaSPByMaKieuSP(id);
                cmBoxNSX.SelectedValue = sp.MaHSX;
                cmBoxDSP.SelectedValue = sp.MaDSP.ToString();
                
                cmBoxSP.DataSource = SanPhamBUS.GetSanPhamByMaDSP(sp.MaDSP);
                cmBoxSP.DisplayMember = "TenSP";
                cmBoxSP.ValueMember = "MaSP";
                cmBoxSP.SelectedValue = sp.MaSP;
                numUpDownSL.Value = sp.SoluongSP;
                txtboxGiaBan.Text = sp.Gia.ToString();
                cmBoxKieuSP.DataSource = ChiTietSPBUS.GetChiTietSPByIDSP(sp.MaSP);
                cmBoxKieuSP.ValueMember = "MaKieu";
                cmBoxKieuSP.DisplayMember = "MaKieu";
                cmBoxKieuSP.SelectedValue = sp.MaKieu;
                txtboxGiaNhap.Text= dgvNhapHang.Rows[r].Cells[2].Value.ToString();
               

            }
            catch { }
        }
        #endregion


    }
}
