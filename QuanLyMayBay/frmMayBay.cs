using DevExpress.LookAndFeel;
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
    public partial class frmMayBay : Form
    {
        int vitri = 0;
        public frmMayBay()
        {
            InitializeComponent();
        }
        private void mAYBAYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMB.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
        private void frmMayBay_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.mAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mAYBAYTableAdapter.Fill(this.DS.MAYBAY);
            this.dICHVUBAOTRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.dICHVUBAOTRITableAdapter.Fill(this.DS.DICHVUBAOTRI);
            this.sOHUUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sOHUUTableAdapter.Fill(this.DS.SOHUU);
            this.lOAIMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOAIMAYBAYTableAdapter.Fill(this.DS.LOAIMAYBAY);
            this.nHACHUAMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHACHUAMAYBAYTableAdapter.Fill(this.DS.NHACHUAMAYBAY);

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMB.Position;
            groupBox1.Enabled = true;
            bdsMB.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
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
        private void cmbLoaiMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaLoai.Text = cmbLoaiMB.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cmbNhaChua_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaNC.Text = cmbNhaChua.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dispose();
        }

        
    }
}
