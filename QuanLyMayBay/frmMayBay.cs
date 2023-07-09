using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMayBay
{
    public partial class frmMayBay : Form
    {
        int vitri = 0;
        public frmMayBay()
        {
            InitializeComponent();
        }

        private void frmMayBay_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.mAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mAYBAYTableAdapter.Fill(this.DS.MAYBAY);
            this.cB_NHACHUAMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cB_NHACHUAMAYBAYTableAdapter.Fill(this.DS.CB_NHACHUAMAYBAY);
            this.cB_LOAIMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cB_LOAIMAYBAYTableAdapter.Fill(this.DS.CB_LOAIMAYBAY);
            this.cHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHUMAYBAYTableAdapter.Fill(this.DS.CHUMAYBAY);
            this.sOHUUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sOHUUTableAdapter.Fill(this.DS.SOHUU);
            groupBox2.Enabled = groupBox1.Enabled = false;
            gcSOHUU.Enabled = true;
            btnGHISH.Enabled = btnHUYSH.Enabled = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcMayBay.Enabled = false;
            groupBox1.Enabled = true;
            bdsMB.AddNew();

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMB.Position;
            groupBox1.Enabled = true;
            gcMayBay.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaDK.Text.Trim() == "")
            {
                MessageBox.Show("Mã đăng ký không được thiếu!", "", MessageBoxButtons.OK);
                txtMaDK.Focus();
                return;
            }
            if (txtMaLoai.Text.Trim() == "")
            {
                MessageBox.Show("Mã loại không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLoai.Focus();
                return;
            }
            if (txtMaNC.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhà chứa không được thiếu!", "", MessageBoxButtons.OK);
                txtMaNC.Focus();
                return;
            }
            try
            {
                bdsMB.EndEdit();
                bdsMB.ResetCurrentItem();
                this.mAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mAYBAYTableAdapter.Update(this.DS.MAYBAY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcMayBay.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsMB.Count == 0)
            {
                MessageBox.Show("Không còn máy bay để xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa máy bay này!", "Xác nhận", MessageBoxButtons.OKCancel)
                   == DialogResult.OK)
            {
                Int32 madk = 0;
                try
                {
                    madk = int.Parse(((DataRowView)bdsMB[bdsMB.Position])["MADANGKY"].ToString());
                    bdsMB.RemoveCurrent();
                    this.mAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mAYBAYTableAdapter.Update(this.DS.MAYBAY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.mAYBAYTableAdapter.Fill(this.DS.MAYBAY);
                    bdsMB.Position = bdsMB.Find("MADANGKY", madk);
                    return;
                }
            }
            if (bdsMB.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMB.CancelEdit();
            if (btnThem.Enabled == false) bdsMB.Position = vitri;
            gcMayBay.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mAYBAYTableAdapter.Fill(this.DS.MAYBAY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);

            }
        }


        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dispose();
        }

        private void cB_NHACHUAMAYBAYBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lOAIComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_LoaiMB.SelectedValue != null) txtMaLoai.Text = cmb_LoaiMB.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Combobox Loai MB :" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void cmbNhaChuaMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_NhaChuaMB.SelectedValue != null) txtMaNC.Text = cmb_NhaChuaMB.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Combobox Nha Chua MB :" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void cmbMACHU_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbMACHU.SelectedValue != null) txtMACHU.Text = cmbMACHU.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Combobox Ma Chu :" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void nGAYBATDAULabel_Click(object sender, EventArgs e)
        {

        }

        private void btnThemSH_Click_1(object sender, EventArgs e)
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = false;

            bdsSOHUU.AddNew();
            txtMDKSOHUU.Text = txtMaDK.Text;
            groupBox2.Enabled = true;
            gcSOHUU.Enabled = true;
            btnTHEMSH.Enabled = btnXOASH.Enabled = btnSUASH.Enabled = false;
            btnGHISH.Enabled = btnHUYSH.Enabled = true;

           
        }

        private void btnXOASH_Click_1(object sender, EventArgs e)
        {
            if (bdsSOHUU.Count == 0)
            {
                MessageBox.Show("Không còn gì để xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa!", "Xác nhận", MessageBoxButtons.OKCancel)
                   == DialogResult.OK)
            {
                Int32 madk = 0;
                try
                {
                    madk = int.Parse(((DataRowView)bdsMB[bdsMB.Position])["MADANGKY"].ToString());
                    bdsSOHUU.RemoveCurrent();
                    this.sOHUUTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sOHUUTableAdapter.Update(this.DS.SOHUU);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.sOHUUTableAdapter.Fill(this.DS.SOHUU);
                    bdsSOHUU.Position = bdsSOHUU.Find("MADANGKY", madk);
                    return;
                }
            }
            if (bdsSOHUU.Count == 0) btnXOASH.Enabled = false;
            groupBox2.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

        }

        private void btnGHISH_Click(object sender, EventArgs e)
        {
            if (cmbMACHU.Text.Trim() == "")
            {
                MessageBox.Show("Mã chủ không được thiếu!", "", MessageBoxButtons.OK);
                cmbMACHU.Focus();
                return;
            }

            if (txtNGAYBD.Text.Trim() == "")
            {
                MessageBox.Show("Ngày bắt đầu không được thiếu!", "", MessageBoxButtons.OK);
                txtNGAYBD.Focus();
                return;
            }
            if (txtNGAYBD.DateTime > DateTime.Now)
            {
                MessageBox.Show("Ngày bắt đầu không được trong tương lai!", "", MessageBoxButtons.OK);
                txtNGAYBD.Focus();
                return;
            }
            try
            {
                bdsSOHUU.EndEdit();
                bdsSOHUU.ResetCurrentItem();
                this.sOHUUTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sOHUUTableAdapter.Update(this.DS.SOHUU);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi\n" + ex.Message, "", MessageBoxButtons.OK);
                this.sOHUUTableAdapter.Fill(this.DS.SOHUU);
            }

            groupBox2.Enabled = false;
            btnXOASH.Enabled = btnSUASH.Enabled = btnTHEMSH.Enabled = true;
            btnGHISH.Enabled = btnHUYSH.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled  = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnSUASH_Click(object sender, EventArgs e)
        {
            gcSOHUU.Enabled = true;
            groupBox2.Enabled = true;
            btnTHEMSH.Enabled = btnXOASH.Enabled = btnSUASH.Enabled = false;
            btnGHISH.Enabled = btnHUYSH.Enabled = true;
        }

        private void btnHUYSH_Click(object sender, EventArgs e)
        {
            bdsSOHUU.CancelEdit();
            this.sOHUUTableAdapter.Fill(this.DS.SOHUU);
            bdsSOHUU.Position = vitri;
            btnTHEMSH.Enabled = btnXOASH.Enabled = btnSUASH.Enabled = true;
            btnGHISH.Enabled = btnHUYSH.Enabled = false;
            gcSOHUU.Enabled = true;
            groupBox2.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }
    }
}
