﻿namespace GalaxyMobile
{
    partial class frmChiTietHoaDonNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlCTHDNH = new System.Windows.Forms.Panel();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemSPHDNH = new System.Windows.Forms.Button();
            this.btnLuuSPHDNH = new System.Windows.Forms.Button();
            this.btnXoaSPHDNH = new System.Windows.Forms.Button();
            this.btnThemDSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.cmBoxKieuSP = new System.Windows.Forms.ComboBox();
            this.cmBoxSP = new System.Windows.Forms.ComboBox();
            this.cmBoxDSP = new System.Windows.Forms.ComboBox();
            this.cmBoxLoaiSP = new System.Windows.Forms.ComboBox();
            this.cmBoxNSX = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateNhapHang = new System.Windows.Forms.DateTimePicker();
            this.txtBoxMaNVNH = new System.Windows.Forms.TextBox();
            this.txtBoxMaHDNH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numUpDownSL = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtboxGiaNhap = new System.Windows.Forms.TextBox();
            this.txtboxGiaBan = new System.Windows.Forms.TextBox();
            this.maKieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietHDNhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtboxHSX = new System.Windows.Forms.TextBox();
            this.txtBoxLSP = new System.Windows.Forms.TextBox();
            this.txtBoxDSP = new System.Windows.Forms.TextBox();
            this.txtBoxKieuSP = new System.Windows.Forms.TextBox();
            this.pnlCTHDNH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDNhapHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCTHDNH
            // 
            this.pnlCTHDNH.Controls.Add(this.dgvNhapHang);
            this.pnlCTHDNH.Controls.Add(this.groupBox2);
            this.pnlCTHDNH.Controls.Add(this.groupBox1);
            this.pnlCTHDNH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCTHDNH.Location = new System.Drawing.Point(0, 0);
            this.pnlCTHDNH.Name = "pnlCTHDNH";
            this.pnlCTHDNH.Size = new System.Drawing.Size(882, 457);
            this.pnlCTHDNH.TabIndex = 0;
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.AllowUserToAddRows = false;
            this.dgvNhapHang.AllowUserToDeleteRows = false;
            this.dgvNhapHang.AutoGenerateColumns = false;
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKieuDataGridViewTextBoxColumn,
            this.soLuongNhapDataGridViewTextBoxColumn,
            this.giaNSXDataGridViewTextBoxColumn});
            this.dgvNhapHang.DataSource = this.chiTietHDNhapHangBindingSource;
            this.dgvNhapHang.Location = new System.Drawing.Point(30, 246);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.ReadOnly = true;
            this.dgvNhapHang.Size = new System.Drawing.Size(404, 190);
            this.dgvNhapHang.TabIndex = 1;
            this.dgvNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHang_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxKieuSP);
            this.groupBox2.Controls.Add(this.txtBoxDSP);
            this.groupBox2.Controls.Add(this.txtBoxLSP);
            this.groupBox2.Controls.Add(this.txtboxHSX);
            this.groupBox2.Controls.Add(this.txtboxGiaBan);
            this.groupBox2.Controls.Add(this.txtboxGiaNhap);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numUpDownSL);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnThemSPHDNH);
            this.groupBox2.Controls.Add(this.btnLuuSPHDNH);
            this.groupBox2.Controls.Add(this.btnXoaSPHDNH);
            this.groupBox2.Controls.Add(this.btnThemDSP);
            this.groupBox2.Controls.Add(this.btnThemSP);
            this.groupBox2.Controls.Add(this.cmBoxKieuSP);
            this.groupBox2.Controls.Add(this.cmBoxSP);
            this.groupBox2.Controls.Add(this.cmBoxDSP);
            this.groupBox2.Controls.Add(this.cmBoxLoaiSP);
            this.groupBox2.Controls.Add(this.cmBoxNSX);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(469, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 422);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Hàng Nhập";
            // 
            // btnThemSPHDNH
            // 
            this.btnThemSPHDNH.Location = new System.Drawing.Point(207, 369);
            this.btnThemSPHDNH.Name = "btnThemSPHDNH";
            this.btnThemSPHDNH.Size = new System.Drawing.Size(75, 44);
            this.btnThemSPHDNH.TabIndex = 2;
            this.btnThemSPHDNH.Text = "Thêm";
            this.btnThemSPHDNH.UseVisualStyleBackColor = true;
            // 
            // btnLuuSPHDNH
            // 
            this.btnLuuSPHDNH.Location = new System.Drawing.Point(126, 369);
            this.btnLuuSPHDNH.Name = "btnLuuSPHDNH";
            this.btnLuuSPHDNH.Size = new System.Drawing.Size(75, 44);
            this.btnLuuSPHDNH.TabIndex = 2;
            this.btnLuuSPHDNH.Text = "Lưu";
            this.btnLuuSPHDNH.UseVisualStyleBackColor = true;
            // 
            // btnXoaSPHDNH
            // 
            this.btnXoaSPHDNH.Location = new System.Drawing.Point(297, 369);
            this.btnXoaSPHDNH.Name = "btnXoaSPHDNH";
            this.btnXoaSPHDNH.Size = new System.Drawing.Size(75, 44);
            this.btnXoaSPHDNH.TabIndex = 2;
            this.btnXoaSPHDNH.Text = "Xóa";
            this.btnXoaSPHDNH.UseVisualStyleBackColor = true;
            // 
            // btnThemDSP
            // 
            this.btnThemDSP.Location = new System.Drawing.Point(310, 131);
            this.btnThemDSP.Name = "btnThemDSP";
            this.btnThemDSP.Size = new System.Drawing.Size(62, 23);
            this.btnThemDSP.TabIndex = 4;
            this.btnThemDSP.Text = "Thêm";
            this.btnThemDSP.UseVisualStyleBackColor = true;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(310, 175);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(62, 23);
            this.btnThemSP.TabIndex = 4;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            // 
            // cmBoxKieuSP
            // 
            this.cmBoxKieuSP.FormattingEnabled = true;
            this.cmBoxKieuSP.Location = new System.Drawing.Point(157, 223);
            this.cmBoxKieuSP.Name = "cmBoxKieuSP";
            this.cmBoxKieuSP.Size = new System.Drawing.Size(147, 21);
            this.cmBoxKieuSP.TabIndex = 3;
            // 
            // cmBoxSP
            // 
            this.cmBoxSP.FormattingEnabled = true;
            this.cmBoxSP.Location = new System.Drawing.Point(157, 177);
            this.cmBoxSP.Name = "cmBoxSP";
            this.cmBoxSP.Size = new System.Drawing.Size(147, 21);
            this.cmBoxSP.TabIndex = 3;
            // 
            // cmBoxDSP
            // 
            this.cmBoxDSP.FormattingEnabled = true;
            this.cmBoxDSP.Location = new System.Drawing.Point(157, 131);
            this.cmBoxDSP.Name = "cmBoxDSP";
            this.cmBoxDSP.Size = new System.Drawing.Size(147, 21);
            this.cmBoxDSP.TabIndex = 3;
            // 
            // cmBoxLoaiSP
            // 
            this.cmBoxLoaiSP.FormattingEnabled = true;
            this.cmBoxLoaiSP.Location = new System.Drawing.Point(157, 86);
            this.cmBoxLoaiSP.Name = "cmBoxLoaiSP";
            this.cmBoxLoaiSP.Size = new System.Drawing.Size(147, 21);
            this.cmBoxLoaiSP.TabIndex = 3;
            // 
            // cmBoxNSX
            // 
            this.cmBoxNSX.FormattingEnabled = true;
            this.cmBoxNSX.Location = new System.Drawing.Point(157, 39);
            this.cmBoxNSX.Name = "cmBoxNSX";
            this.cmBoxNSX.Size = new System.Drawing.Size(147, 21);
            this.cmBoxNSX.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kiểu Sản Phẩm;";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sản Phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại Sản Phẩm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dòng Sản Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhà Cung Cấp:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateNhapHang);
            this.groupBox1.Controls.Add(this.txtBoxMaNVNH);
            this.groupBox1.Controls.Add(this.txtBoxMaHDNH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhập Hàng";
            // 
            // dateNhapHang
            // 
            this.dateNhapHang.CustomFormat = "dd/MM/yyyy";
            this.dateNhapHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNhapHang.Location = new System.Drawing.Point(160, 139);
            this.dateNhapHang.Name = "dateNhapHang";
            this.dateNhapHang.Size = new System.Drawing.Size(173, 20);
            this.dateNhapHang.TabIndex = 2;
            // 
            // txtBoxMaNVNH
            // 
            this.txtBoxMaNVNH.Location = new System.Drawing.Point(160, 87);
            this.txtBoxMaNVNH.Name = "txtBoxMaNVNH";
            this.txtBoxMaNVNH.ReadOnly = true;
            this.txtBoxMaNVNH.Size = new System.Drawing.Size(173, 20);
            this.txtBoxMaNVNH.TabIndex = 1;
            // 
            // txtBoxMaHDNH
            // 
            this.txtBoxMaHDNH.Location = new System.Drawing.Point(160, 47);
            this.txtBoxMaHDNH.Name = "txtBoxMaHDNH";
            this.txtBoxMaHDNH.ReadOnly = true;
            this.txtBoxMaHDNH.Size = new System.Drawing.Size(173, 20);
            this.txtBoxMaHDNH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn Nhập:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Số Lượng Tồn:";
            // 
            // numUpDownSL
            // 
            this.numUpDownSL.Location = new System.Drawing.Point(158, 261);
            this.numUpDownSL.Name = "numUpDownSL";
            this.numUpDownSL.Size = new System.Drawing.Size(146, 20);
            this.numUpDownSL.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Giá Bán:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Giá Nhập:";
            // 
            // txtboxGiaNhap
            // 
            this.txtboxGiaNhap.Location = new System.Drawing.Point(157, 295);
            this.txtboxGiaNhap.Name = "txtboxGiaNhap";
            this.txtboxGiaNhap.Size = new System.Drawing.Size(147, 20);
            this.txtboxGiaNhap.TabIndex = 8;
            // 
            // txtboxGiaBan
            // 
            this.txtboxGiaBan.Location = new System.Drawing.Point(157, 333);
            this.txtboxGiaBan.Name = "txtboxGiaBan";
            this.txtboxGiaBan.Size = new System.Drawing.Size(147, 20);
            this.txtboxGiaBan.TabIndex = 8;
            // 
            // maKieuDataGridViewTextBoxColumn
            // 
            this.maKieuDataGridViewTextBoxColumn.DataPropertyName = "MaKieu";
            this.maKieuDataGridViewTextBoxColumn.HeaderText = "Mã Kiểu Sản Phẩm";
            this.maKieuDataGridViewTextBoxColumn.Name = "maKieuDataGridViewTextBoxColumn";
            this.maKieuDataGridViewTextBoxColumn.ReadOnly = true;
            this.maKieuDataGridViewTextBoxColumn.Width = 150;
            // 
            // soLuongNhapDataGridViewTextBoxColumn
            // 
            this.soLuongNhapDataGridViewTextBoxColumn.DataPropertyName = "SoLuongNhap";
            this.soLuongNhapDataGridViewTextBoxColumn.HeaderText = "Số Lượng Nhập";
            this.soLuongNhapDataGridViewTextBoxColumn.Name = "soLuongNhapDataGridViewTextBoxColumn";
            this.soLuongNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaNSXDataGridViewTextBoxColumn
            // 
            this.giaNSXDataGridViewTextBoxColumn.DataPropertyName = "GiaNSX";
            this.giaNSXDataGridViewTextBoxColumn.HeaderText = "Giá Nhà Sản Xuất";
            this.giaNSXDataGridViewTextBoxColumn.Name = "giaNSXDataGridViewTextBoxColumn";
            this.giaNSXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chiTietHDNhapHangBindingSource
            // 
            this.chiTietHDNhapHangBindingSource.DataSource = typeof(Model.ChiTietHDNhapHang);
            // 
            // txtboxHSX
            // 
            this.txtboxHSX.Location = new System.Drawing.Point(158, 60);
            this.txtboxHSX.Name = "txtboxHSX";
            this.txtboxHSX.Size = new System.Drawing.Size(146, 20);
            this.txtboxHSX.TabIndex = 9;
            // 
            // txtBoxLSP
            // 
            this.txtBoxLSP.Location = new System.Drawing.Point(157, 114);
            this.txtBoxLSP.Name = "txtBoxLSP";
            this.txtBoxLSP.Size = new System.Drawing.Size(147, 20);
            this.txtBoxLSP.TabIndex = 10;
            // 
            // txtBoxDSP
            // 
            this.txtBoxDSP.Location = new System.Drawing.Point(157, 151);
            this.txtBoxDSP.Name = "txtBoxDSP";
            this.txtBoxDSP.Size = new System.Drawing.Size(147, 20);
            this.txtBoxDSP.TabIndex = 10;
            // 
            // txtBoxKieuSP
            // 
            this.txtBoxKieuSP.Location = new System.Drawing.Point(157, 204);
            this.txtBoxKieuSP.Name = "txtBoxKieuSP";
            this.txtBoxKieuSP.Size = new System.Drawing.Size(147, 20);
            this.txtBoxKieuSP.TabIndex = 11;
            // 
            // frmChiTietHoaDonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 457);
            this.Controls.Add(this.pnlCTHDNH);
            this.Name = "frmChiTietHoaDonNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Hóa Đơn Nhập Hàng";
            this.Load += new System.EventHandler(this.frmChiTietHoaDonNhapHang_Load);
            this.pnlCTHDNH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDNhapHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCTHDNH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource chiTietHDNhapHangBindingSource;
        private System.Windows.Forms.Button btnThemSPHDNH;
        private System.Windows.Forms.Button btnLuuSPHDNH;
        private System.Windows.Forms.Button btnXoaSPHDNH;
        private System.Windows.Forms.Button btnThemDSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.ComboBox cmBoxKieuSP;
        private System.Windows.Forms.ComboBox cmBoxSP;
        private System.Windows.Forms.ComboBox cmBoxDSP;
        private System.Windows.Forms.ComboBox cmBoxLoaiSP;
        private System.Windows.Forms.ComboBox cmBoxNSX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateNhapHang;
        private System.Windows.Forms.TextBox txtBoxMaNVNH;
        private System.Windows.Forms.TextBox txtBoxMaHDNH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown numUpDownSL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxGiaBan;
        private System.Windows.Forms.TextBox txtboxGiaNhap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxKieuSP;
        private System.Windows.Forms.TextBox txtBoxDSP;
        private System.Windows.Forms.TextBox txtBoxLSP;
        private System.Windows.Forms.TextBox txtboxHSX;
    }
}