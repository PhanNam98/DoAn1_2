﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BUS;
namespace GalaxyMobile
{
    public partial class frmMainClient : Form
    {
        public frmMainClient(TaiKhoan username, int matruycap)
        {
            InitializeComponent();
            User = username;
            MaTruyCap = matruycap;
        }

        private TaiKhoan User;
        private int MaTruyCap;
        private CuaHang CH;

        private void frmMainClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'galaxyMobileDataSet1.KhachHang' table. You can move, or remove it, as needed.
            //this.khachHangTableAdapter.Fill(this.galaxyMobileDataSet1.KhachHang);
            PhanQuyen();
            CH = CuaHangBUS.GetThongTinCuaHang(User.MaCuaHang);
            this.Text = CH.TenCuaHang;
        }

        #region Event
        private void btnChiTietTK_Click(object sender, EventArgs e)
        {
            frmChiTietTaiKhoan frm = new frmChiTietTaiKhoan(User);
            frm.ShowDialog();
        }
        #endregion

        #region methods
        public void PhanQuyen()
        {
            if (MaTruyCap == 3)
            {
                tabControlMainClient.Controls.Remove(tabNhanVien);
                tabControlMainClient.Controls.Remove(tabThongKe);
                tabControlMainClient.Controls.Remove(tabCuaHang);
            }
            if (MaTruyCap == 4)
            {
                tabControlMainClient.Controls.Remove(tabNhanVien);
                tabControlMainClient.Controls.Remove(tabThongKe);
                tabControlMainClient.Controls.Remove(tabCuaHang);
            }
            lbUser.Text = User.UserName;

        }
        #endregion

        #region HoaDon
        private void btnLoadHD_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }
        void LoadHoaDon()
        {
            hoaDonBindingSource.DataSource = HoaDonBUS.GetAllHoaDonByMaCH(CH.MaCuaHang);
        }
        private void btnCTHD_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon hd = new frmChiTietHoaDon((hoaDonBindingSource.Current as HoaDon),User.MaCuaHang,User.UserName,false);
            hd.Show();
            LoadHoaDon();

        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon hd = new frmChiTietHoaDon(null, User.MaCuaHang, User.UserName,true);
            hd.Show();
            LoadHoaDon();
        }
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                
                try
                {
                    HoaDonBUS.XoaHoaDon((hoaDonBindingSource.Current as HoaDon));
                    MessageBox.Show("Xóa Thành Công!", "Thông Báo");

                    LoadHoaDon();
                }
                catch { MessageBox.Show("Không Thể Thực Hiện Thao Tác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if ((hoaDonBindingSource.Current as HoaDon) == null)
                return;
            if ((hoaDonBindingSource.Current as HoaDon).TinhTrang == 0)
            {
                frmChiTietHoaDon hd = new frmChiTietHoaDon((hoaDonBindingSource.Current as HoaDon), User.MaCuaHang, User.UserName,true);
                hd.Show();
            }
            else
            {
                frmChiTietHoaDon hd = new frmChiTietHoaDon((hoaDonBindingSource.Current as HoaDon), User.MaCuaHang, User.UserName, false);
                hd.Show();
            }
            LoadHoaDon();
        }
        #endregion

        #region Kho Hang
        #endregion
        #region Dong SP
        void LoadDSP()
        {
            dongSanPhamBindingSource.DataSource = DongSanPhamBUS.GetAllDongSP();
            cmBoxHSX.DataSource = HSXBUS.GetAllHSX();
            cmBoxHSX.DisplayMember = "TenHSX";
            cmBoxHSX.ValueMember = "MaHSX";
            cmBoxLoaiSP.DataSource = LoaiSPBUS.GetAllLoaiSP();
            cmBoxLoaiSP.DisplayMember = "TenLSP";
            cmBoxLoaiSP.ValueMember = "MaLSP";
        }
        private void btnLoadDSP_Click(object sender, EventArgs e)
        {
            LoadDSP();
        }
        private void dgvDongSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvDongSP.CurrentCell.RowIndex;
                string id = dgvDongSP.Rows[r].Cells[0].Value.ToString();
                txtboxMaDongSP.Text = id;
                txtboxTenDongSP.Text = dgvDongSP.Rows[r].Cells[1].Value.ToString();
                cmBoxHSX.SelectedValue = dgvDongSP.Rows[r].Cells[2].Value.ToString();
                cmBoxLoaiSP.SelectedValue = dgvDongSP.Rows[r].Cells[3].Value.ToString();
            }
            catch { }
        }
        #endregion
        #region San Pham

        private void btnLoadSP_Click(object sender, EventArgs e)
        {
            LoadSP();
        }
        void LoadSP()
        {
            sanPhamBindingSource.DataSource = SanPhamBUS.GetAllSanPham();
        }

        #endregion

        #region Nha san xuat

        #endregion

        private void label14_Click(object sender, EventArgs e)
        {

        }
        #region Khach Hang 
        bool Them = false;
        public void LoadKH()
        {
            khachHangBindingSource.DataSource = KHBUS.GetKH();
            dgvKH_CellClick(null, null);
            // Xóa trống các đối tượng trong Panel 
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy 
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            panel.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        #endregion

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thứ tự record hiện hành 
            int r = dgvKH.CurrentCell.RowIndex;
            txtMaKH.Text = dgvKH.Rows[r].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKH.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKH.Rows[r].Cells[2].Value.ToString();
            txtSDT.Text= dgvKH.Rows[r].Cells[3].Value.ToString();

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadKH();
            dgvKH_CellClick(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgvKH.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strMAKH =
                dgvKH.Rows[r].Cells[0].Value.ToString();
                KHBUS.DelKH(strMAKH);
                LoadKH();
                //dgvNV_CellClick(null, null);
                MessageBox.Show("Đã xóa xong!");
            }
            catch
            {
                MessageBox.Show("Không được phép xóa nhân viên này");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            dgvKH_CellClick(null, null);
            //dgvKH_CellClick(null, null);
            // Cho phép thao tác trên Panel 
            panel.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField txtTenNV         
            txtMaKH.Enabled = false;
            txtTenKH.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaKH.Enabled = true;
            // Xóa trống các đối tượng trong Panel 
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaKH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                if (NhanVienBUS.KtMaNV(txtMaKH.Text) > 0)
                {
                    MessageBox.Show("Mã khách hàng tồn tai. Nhập Mã nhân viên khác !");
                    txtMaKH.ResetText();
                    txtTenKH.ResetText();
                    txtSDT.ResetText();
                    txtDiaChi.ResetText();
                    txtMaKH.Focus();
                }
                else
                {
                    KHBUS.ThemKH(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                    LoadKH();
                    // Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                }
            }
            else
            {
                int r = dgvKH.CurrentCell.RowIndex;
                // MaNV hiện hành 

                string strMaKH = dgvKH.Rows[r].Cells[0].Value.ToString();
                KHBUS.SuaKH(strMaKH, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                LoadKH();
                // Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            panel.Enabled = false;
        }

        private void btnChiTietSP_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvSP.CurrentCell.RowIndex;
                string id = dgvSP.Rows[r].Cells[0].Value.ToString();
                frmChiTietSanPham ctsp = new frmChiTietSanPham(id, User.MaCuaHang, null, false);
                ctsp.ShowDialog();
            }
            catch { }
        }

        private void dgvHSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadHSX_Click(object sender, EventArgs e)
        {
            try
            {
                hSXBindingSource.DataSource = HSXBUS.GetAllHSX();
            }
            catch { }
        }

       
       
        
       
    }
}
