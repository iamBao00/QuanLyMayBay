using System;
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
            };
            if(Program.mGroup == "NHANVIEN") { 
                ribbonNhanVien.Visible = true;
                ribbonAdmin.Visible = false;
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
    }
}
