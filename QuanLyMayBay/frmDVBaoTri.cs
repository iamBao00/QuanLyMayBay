using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyMayBay
{
    public partial class frmDVBaoTri : Form
    {
        int vitri = 0;
        bool dangThemMoi = false;
        public frmDVBaoTri()
        {
            InitializeComponent();
        }

        private void dICHVUBAOTRIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDVBT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmDVBaoTri_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.dICHVUBAOTRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.dICHVUBAOTRITableAdapter.Fill(this.DS.DICHVUBAOTRI);
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            this.mAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mAYBAYTableAdapter.Fill(this.DS.MAYBAY);
            if (Program.mGroup == "NHANVIEN")
            {
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled =  btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnReload.Enabled = btnThoat.Enabled = true;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDVBT.Position;
            dangThemMoi = true;
            panelControl1.Enabled = true;
            gcDVBT.Enabled = false;
            bdsDVBT.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDVBT.Position;
            panelControl1.Enabled = true;
            gcDVBT.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dịch vụ này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String iddvbt = ((DataRowView)bdsDVBT[bdsDVBT.Position])["IDDVBT"].ToString();
                try
                {

                    bdsDVBT.RemoveCurrent();
                    this.dICHVUBAOTRITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dICHVUBAOTRITableAdapter.Update(this.DS.DICHVUBAOTRI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.dICHVUBAOTRITableAdapter.Fill(this.DS.DICHVUBAOTRI);
                    bdsDVBT.Position = bdsDVBT.Find("IDDVBT", iddvbt);
                    return;
                }
                panelControl1.Enabled = true;
                gcDVBT.Enabled = true;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbMaDK.Text.Trim() == "")
            {
                MessageBox.Show("Mã đăng ký không được thiếu!", "", MessageBoxButtons.OK);
                cmbMaDK.Focus();
                return;
            }
            if (cmbNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                cmbNV.Focus();
                return;
            }
            if (txtIDDVBT.Text.Trim() == "")
            {
                MessageBox.Show("ID dịch vụ bảo trì không được thiếu!", "", MessageBoxButtons.OK);
                txtIDDVBT.Focus();
                return;
            }
            if (dtpNgayGio.Text.Trim() == "")
            {
                MessageBox.Show("Ngày giờ không được thiếu!", "", MessageBoxButtons.OK);
                dtpNgayGio.Focus();
                return;
            }
            if (dtpNgayGio.DateTime < DateTime.Now)
            {
                MessageBox.Show("Ngày giờ không hợp lý!", "", MessageBoxButtons.OK);
                dtpNgayGio.Focus();
                return;
            }
            if (txtSoGioBT.Text.Trim() == "")
            {
                MessageBox.Show("Số giờ bảo trì không được thiếu!", "", MessageBoxButtons.OK);
                txtSoGioBT.Focus();
                return;
            }
            if (txtCongViec.Text.Trim() == "")
            {
                MessageBox.Show("Công việc không được thiếu!", "", MessageBoxButtons.OK);
                txtCongViec.Focus();
                return;
            }
            try
            {
                bdsDVBT.EndEdit();
                bdsDVBT.ResetCurrentItem();
                this.dICHVUBAOTRITableAdapter.Connection.ConnectionString = Program.connstr;
                this.dICHVUBAOTRITableAdapter.Update(this.DS.DICHVUBAOTRI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            panelControl1.Enabled = true;
            gcDVBT.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDVBT.CancelEdit();
            if (btnThem.Enabled == false) bdsDVBT.Position = vitri;
            gcDVBT.Enabled = true;
            panelControl1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dispose();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.dICHVUBAOTRITableAdapter.Fill(this.DS.DICHVUBAOTRI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);

            }
        }

        private void cmbNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaNV.Text = cmbNV.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cmbMaDK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaDK.Text = cmbMaDK.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
