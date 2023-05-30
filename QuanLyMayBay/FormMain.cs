﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyMayBay
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void HienThiMenu()
        {
            MANV.Text = "Mã NV: " + Program.username;
            HOTEN.Text = "Họ tên nhân viên: " + Program.mHoTen;
            NHOM.Text = "Nhóm: " + Program.mGroup;

            barButtonItemDangXuat.Enabled = true;
            btnDangNhap.Enabled = false;
            // Phân quyền
            if (Program.mGroup == "ADMIN") {
                ribbonAdmin.Visible = true;
                btnTaoTaiKhoan.Enabled = true;
                ribbonThongKe.Visible = true;
            };
            if(Program.mGroup == "NHANVIEN") { 
                ribbonNhanVien.Visible = true;
                ribbonAdmin.Visible = false;
                ribbonThongKe.Visible = false;
            }

        }

        private void DangXuat()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
                f.Dispose();
            }
            MANV.Text = "MANV";
            HOTEN.Text = "HOTEN";
            NHOM.Text = "NHOM";
            Program.conn.Close();
            GC.Collect();
            GC.WaitForFullGCApproach();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            GC.Collect();

        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormDangNhap));
            {
                if (form != null) form.Activate();
                else
                {

                    FormDangNhap f = new FormDangNhap();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ribbonAdmin.Visible = false;
            ribbonNhanVien.Visible = false;
        }

        private void barButtonItemDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangXuat();
            barButtonItemDangXuat.Enabled = btnTaoTaiKhoan.Enabled = false;
            btnDangNhap.Enabled = true;
        }

        private void btnLoaiMB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(frmLoaiMB));
            {
                if (form != null) form.Activate();
                else
                {

                    frmLoaiMB f = new frmLoaiMB();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void btnNCMB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form form = CheckExists(typeof(frmNhaChuaMB));
            {
                if (form != null) form.Activate();
                else
                {

                    frmNhaChuaMB f = new frmNhaChuaMB();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void btnMayBay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(frmMayBay));
            {
                if (form != null) form.Activate();
                else
                {

                    frmMayBay f = new frmMayBay();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(frmNhanVien));
            {
                if (form != null) form.Activate();
                else
                {
                    frmNhanVien f = new frmNhanVien();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void btnPhiCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(frmPhiCong));
            {
                if (form != null) form.Activate();
                else
                {
                    frmPhiCong f = new frmPhiCong();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void btnChuCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(frmChuCN));
            {
                if (form != null) form.Activate();
                else
                {
                    frmChuCN f = new frmChuCN();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }
    }
}
