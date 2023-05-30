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
    public partial class frmNhaChuaMB : Form
    {
        int vitri = 0;
        public frmNhaChuaMB()
        {
            InitializeComponent();
        }

        private void nHACHUAMAYBAYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhaChuaMB_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.nHACHUAMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHACHUAMAYBAYTableAdapter.Fill(this.DS.NHACHUAMAYBAY);
            this.mAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mAYBAYTableAdapter.Fill(this.DS.MAYBAY);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNC.Position;
            groupBox1.Enabled = true;
            bdsNC.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNC.Position;
            groupBox1.Enabled = true;
            gcNhaChuaMB.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 manc = 0;
            if (MessageBox.Show("Bạn có muốn xóa nhà chứa này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manc = int.Parse(((DataRowView)bdsNC[bdsNC.Position])["MANHACHUA"].ToString());
                    bdsNC.RemoveCurrent();
                    this.nHACHUAMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nHACHUAMAYBAYTableAdapter.Update(this.DS.NHACHUAMAYBAY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhà chứa này. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nHACHUAMAYBAYTableAdapter.Fill(this.DS.NHACHUAMAYBAY);
                    bdsNC.Position = bdsNC.Find("MANHACHUA", manc);
                    return;
                }
                if (bdsNC.Count == 0) btnXoa.Enabled = false;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaNC.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhà chứa không được thiếu!", "", MessageBoxButtons.OK);
                txtMaNC.Focus();
                return;
            }
            if (txtSucChua.Text.Trim() == "")
            {
                MessageBox.Show("Sức chứa không được thiếu!", "", MessageBoxButtons.OK);
                txtSucChua.Focus();
                return;
            }
            if (txtViTri.Text.Trim() == "")
            {
                MessageBox.Show("Vị trí không được thiếu!", "", MessageBoxButtons.OK);
                txtViTri.Focus();
                return;
            }
            try
            {
                bdsNC.EndEdit();
                bdsNC.ResetCurrentItem();
                this.nHACHUAMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nHACHUAMAYBAYTableAdapter.Update(this.DS.NHACHUAMAYBAY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcNhaChuaMB.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            groupBox1.Enabled = false;

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNC.CancelEdit();
            if (btnThem.Enabled == false) bdsNC.Position = vitri;
            gcNhaChuaMB.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nHACHUAMAYBAYTableAdapter.Fill(this.DS.NHACHUAMAYBAY);
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
    }
}
