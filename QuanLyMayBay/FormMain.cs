﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyMayBay;
using DevExpress.XtraBars;
using DevExpress.XtraRichEdit.Model;
using System.Threading.Tasks;

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
                ribbonNhanVien.Visible = false;
                ribbonPage2.Visible = true;
            };
            if(Program.mGroup == "NHANVIEN") { 
                ribbonNhanVien.Visible = true;
                ribbonAdmin.Visible = false;
                ribbonThongKe.Visible = false;
                btnTaoTaiKhoan.Enabled = false;
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
            ribbonThongKe.Visible = false;
            ribbonPage2.Visible = false;
        }

        private void barButtonItemDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangXuat();
            barButtonItemDangXuat.Enabled = btnTaoTaiKhoan.Enabled = false;
            btnDangNhap.Enabled = true;
            ribbonAdmin.Visible=false;
            ribbonNhanVien.Visible = false;
            ribbonThongKe.Visible =false;
            ribbonPage2.Visible = false;
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
            Form form = CheckExists(typeof(FormNhanVien));
            {
                if (form != null) form.Activate();
                else
                {
                    FormNhanVien f = new FormNhanVien();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void btnPhiCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormPhiCong));
            {
                if (form != null) form.Activate();
                else
                {
                    FormPhiCong f = new FormPhiCong();
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

        private void btnChuDN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(frmChuDN));
            {
                if (form != null) form.Activate();
                else
                {
                    frmChuDN f = new frmChuDN();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void btnDVBT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(frmDVBaoTri));
            {
                if (form != null) form.Activate();
                else
                {
                    frmDVBaoTri f = new frmDVBaoTri();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void btnDSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormreportnhanVien));
            if (frm != null) frm.Activate();
            else
            {
                FormreportnhanVien f = new FormreportnhanVien();
                f.Show();
            }

        }

        private void btnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(frmTaoTaiKhoan));
            {
                if (form != null) form.Activate();
                else
                {
                    frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void btnDSPC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmReportPhiCong));
            if (frm != null) frm.Activate();
            else
            {
                frmReportPhiCong f = new frmReportPhiCong();
                f.Show();
            }
        }

        private void btnDSDoanhNghiep_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmReportDSDoanhNghiep));
            if (frm != null) frm.Activate();
            else
            {
                frmReportDSDoanhNghiep f = new frmReportDSDoanhNghiep();
                f.Show();
            }
        }

        private void btnDSDVBT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmReportDSDVBaoTri));
            if (frm != null) frm.Activate();
            else
            {
                frmReportDSDVBaoTri f = new frmReportDSDVBaoTri();
                f.Show();
            }
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormChuyenVe));
            if (frm != null) frm.Activate();
            else
            {
                FormChuyenVe f = new FormChuyenVe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void L_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormChuyenVe));
            if (frm != null) frm.Activate();
            else
            {
                FormChuyenVe f = new FormChuyenVe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLai));
            if (frm != null) frm.Activate();
            else
            {
                FormLai f = new FormLai();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnFormBackUp_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBackUp));
            if (frm != null) frm.Activate();
            else
            {
                FormBackUp f = new FormBackUp();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmRestore));
            if (frm != null) frm.Activate();
            else
            {
                frmRestore f = new frmRestore();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmReportChuCaNhan));
            if (frm != null) frm.Activate();
            else
            {
                frmReportChuCaNhan f = new frmReportChuCaNhan();
                
                f.Show();
            }
        }
    }
}
