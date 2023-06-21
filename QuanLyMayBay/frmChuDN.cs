using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMayBay
{
    public partial class frmChuDN : Form
    {
        int vitri = 0;
        bool dangThemMoi = false;
        public frmChuDN()
        {
            InitializeComponent();
        }

        private void cHUMAYBAYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCMB.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChuDN_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.cHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHUMAYBAYTableAdapter.Fill(this.DS.CHUMAYBAY);
            this.dOANHNGHIEPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dOANHNGHIEPTableAdapter.Fill(this.DS.DOANHNGHIEP);
            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsCMB.Position;
            dangThemMoi = true;
            panelControl1.Enabled = true;
            panelControl2.Enabled = false;
            gcChu.Enabled = false;
            gcDoanhNghiep.Enabled = false;
            bdsCMB.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa mã chủ này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String machu = ((DataRowView)bdsCMB[bdsCMB.Position])["MACHU"].ToString();
                try
                {

                    bdsCMB.RemoveCurrent();
                    this.cHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cHUMAYBAYTableAdapter.Update(this.DS.CHUMAYBAY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.cHUMAYBAYTableAdapter.Fill(this.DS.CHUMAYBAY);
                    bdsCMB.Position = bdsCMB.Find("MACHU", machu);
                    return;
                }
                panelControl1.Enabled = true;
                panelControl2.Enabled = true;
                gcChu.Enabled = true;
                gcDoanhNghiep.Enabled = true;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsCMB.EndEdit();
                bdsCMB.ResetCurrentItem();
                this.cHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cHUMAYBAYTableAdapter.Update(this.DS.CHUMAYBAY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi.\n" + ex.Message, "", MessageBoxButtons.OK);
                this.cHUMAYBAYTableAdapter.Fill(this.DS.CHUMAYBAY);
            }
            panelControl1.Enabled = true;
            panelControl2.Enabled = true;
            gcDoanhNghiep.Enabled = true;
            gcChu.Enabled = true;
            btnThemDN.Enabled = btnXoaDN.Enabled = btnHieuChinhDN.Enabled = true;
            btnGhiDN.Enabled = btnPhucHoiDN.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }
        private void reload()
        {

            try
            {
                vitri = bdsCMB.Position;
                this.dOANHNGHIEPTableAdapter.Fill(this.DS.DOANHNGHIEP);
                this.cHUMAYBAYTableAdapter.Fill(this.DS.CHUMAYBAY);
                bdsDN.Position = vitri;
                panelControl1.Enabled = true;
                panelControl2.Enabled = true;
                gcChu.Enabled = true;
                gcDoanhNghiep.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi)
            {
                dangThemMoi = false;
            }
            bdsCMB.CancelEdit();
            if (btnThem.Enabled == false)
            {
                reload();
            }

            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dispose();
        }

        private void btnThemDN_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled = false;
            btnThoat.Enabled = true;

            bdsDN.AddNew();
            txtMaChuDN.Text = txtMaChu.Text;
            panelControl1.Enabled = false;
            panelControl2.Enabled = true;
            gcDoanhNghiep.Enabled = true;
            gcChu.Enabled = false;
            btnThemDN.Enabled = btnXoaDN.Enabled = btnHieuChinhDN.Enabled = false;
            btnGhiDN.Enabled = btnPhucHoiDN.Enabled = true;
        }

        private void btnXoaDN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa doanh nghiệp này không ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsDN.RemoveCurrent();
                    this.dOANHNGHIEPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dOANHNGHIEPTableAdapter.Update(this.DS.DOANHNGHIEP);
                    panelControl1.Enabled = true;
                    panelControl2.Enabled = true;
                    gcDoanhNghiep.Enabled = true;
                    gcChu.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.dOANHNGHIEPTableAdapter.Fill(this.DS.DOANHNGHIEP);
                    return;
                }

            }
        }

        private void btnHieuChinhDN_Click(object sender, EventArgs e)
        {
            panelControl1.Enabled = false;
            panelControl2.Enabled = true;
            gcDoanhNghiep.Enabled = true;
            gcChu.Enabled = false;
            btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = false;

            btnThemDN.Enabled = btnXoaDN.Enabled = btnHieuChinhDN.Enabled = false;
            btnGhiDN.Enabled = btnPhucHoiDN.Enabled = true;
        }

        private void btnGhiDN_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text.Trim() == "")
            {
                MessageBox.Show("Tên doanh nghiệp không được thiếu!", "", MessageBoxButtons.OK);
                txtTenDN.Focus();
                return;
            }
            if (txtTenNDD.Text.Trim() == "")
            {
                MessageBox.Show("Tên người đại diện không được thiếu!", "", MessageBoxButtons.OK);
                txtTenNDD.Focus();
                return;
            }
            if (txtMaDN.Text.Trim() == "")
            {
                MessageBox.Show("Mã doanh nghiệp không được thiếu!", "", MessageBoxButtons.OK);
                txtMaDN.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu!", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }
            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được thiếu!", "", MessageBoxButtons.OK);
                txtSDT.Focus();
                return;
            }
            try
            {
                bdsDN.EndEdit();
                bdsDN.ResetCurrentItem();
                this.dOANHNGHIEPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dOANHNGHIEPTableAdapter.Update(this.DS.DOANHNGHIEP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi.\n" + ex.Message, "", MessageBoxButtons.OK);
                this.dOANHNGHIEPTableAdapter.Fill(this.DS.DOANHNGHIEP);
            }
            panelControl1.Enabled = true;
            panelControl2.Enabled = true;
            gcDoanhNghiep.Enabled = true;
            gcChu.Enabled = true;
            btnThemDN.Enabled = btnXoaDN.Enabled = btnHieuChinhDN.Enabled = true;
            btnGhiDN.Enabled = btnPhucHoiDN.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnPhucHoiDN_Click(object sender, EventArgs e)
        {
            bdsDN.CancelEdit();
            reload();
            btnThemDN.Enabled = btnXoaDN.Enabled = btnHieuChinhDN.Enabled = true;
            btnGhiDN.Enabled = btnPhucHoiDN.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }
    }
}
