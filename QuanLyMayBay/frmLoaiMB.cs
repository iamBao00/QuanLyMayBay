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
    public partial class frmLoaiMB : Form
    {
        int vitri = 0;
        public frmLoaiMB()
        {
            InitializeComponent();
        }

        private void lOAIMAYBAYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLMB.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmLoaiMB_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.lOAIMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOAIMAYBAYTableAdapter.Fill(this.DS.LOAIMAYBAY);
            this.cHUYENVETableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHUYENVETableAdapter.Fill(this.DS.CHUYENVE);
            this.lAITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lAITableAdapter.Fill(this.DS.LAI);
            this.mAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mAYBAYTableAdapter.Fill(this.DS.MAYBAY);
            
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            
            

        }
        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLMB.Position;
            groupBox1.Enabled = true;
            bdsLMB.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnHieuChinh_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLMB.Position;
            groupBox1.Enabled = true;
            gcLoaiMB.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnXoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 mal = 0;
            try
            {
                mal = int.Parse(((DataRowView)bdsLMB[bdsLMB.Position])["MALOAI"].ToString());
                bdsLMB.RemoveCurrent();
                this.lOAIMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOAIMAYBAYTableAdapter.Update(this.DS.LOAIMAYBAY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                this.lOAIMAYBAYTableAdapter.Fill(this.DS.LOAIMAYBAY);
                bdsLMB.Position = bdsLMB.Find("MALOAI", mal);
                return;
            }
            if (bdsLMB.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLoai.Text.Trim() == "")
            {
                MessageBox.Show("Mã loại không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLoai.Focus();
                return;
            }
            if (txtSucChua.Text.Trim() == "")
            {
                MessageBox.Show("Sức chứa không được thiếu!", "", MessageBoxButtons.OK);
                txtSucChua.Focus();
                return;
            }
            if (txtKieuDang.Text.Trim() == "")
            {
                MessageBox.Show("Kiểu dáng không được thiếu!", "", MessageBoxButtons.OK);
                txtKieuDang.Focus();
                return;
            }
            if (txtTrongLuong.Text.Trim() == "")
            {
                MessageBox.Show("Trọng lượng không được thiếu!", "", MessageBoxButtons.OK);
                txtTrongLuong.Focus();
                return;
            }
            try
            {
                bdsLMB.EndEdit();
                bdsLMB.ResetCurrentItem();
                this.lOAIMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOAIMAYBAYTableAdapter.Update(this.DS.LOAIMAYBAY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi loại máy bay\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcLoaiMB.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnPhucHoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLMB.CancelEdit();
            if (btnThem.Enabled == false) bdsLMB.Position = vitri;
            gcLoaiMB.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

        }

        private void btnReload_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOAIMAYBAYTableAdapter.Fill(this.DS.LOAIMAYBAY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);

            }
        }

        private void btnThoat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dispose();
        }

        private void mAYBAYBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
