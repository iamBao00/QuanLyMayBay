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

namespace QuanLyMayBay
{
    public partial class FormLai : Form
    {
        int dangThemMoi = 0;
        public FormLai()
        {
            InitializeComponent();
        }

        private void pHICONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormLai_Load(object sender, EventArgs e)
        {
            
            dS.EnforceConstraints = false;
            this.pHICONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHICONGTableAdapter.Fill(this.dS.PHICONG);
            this.lOAIMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOAIMAYBAYTableAdapter.Fill(this.dS.LOAIMAYBAY);
            this.cB_LOAIMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cB_LOAIMAYBAYTableAdapter.Fill(this.dS.CB_LOAIMAYBAY);

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            if (Program.mGroup == "NHANVIEN")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = false;
            }
            cmbLMB.Enabled = false;
        }
        private void cmbMALOAI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbLMB.SelectedValue != null) txtMALOAI.Text = cmbLMB.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Combobox Loai MB :" + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            dangThemMoi = 1;
            cmbLMB.Enabled = true;
            bdsLAI.AddNew();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (MessageBox.Show("Bạn có thực sự muốn xóa!", "Xác nhận", MessageBoxButtons.OKCancel)
                   == DialogResult.OK)
            {
                Int32 mapc = 0;
                try
                {
                    mapc = int.Parse(((DataRowView)bdsLAI[bdsLAI.Position])["MAPHICONG"].ToString());
                    bdsLAI.RemoveCurrent();
                    this.lAITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lAITableAdapter.Update(this.dS.LAI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.lAITableAdapter.Fill(this.dS.LAI);
                    bdsLAI.Position = bdsLAI.Find("MAPHICONG", mapc);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            cmbLMB.Enabled = true;

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLAI.CancelEdit();
            this.lAITableAdapter.Fill(this.dS.LAI);
            cmbLMB.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lAITableAdapter.Fill(this.dS.LAI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload !" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            cmbLMB.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAPC.Text.Trim() == "")
            {
                MessageBox.Show("Mã phi công không được thiếu!", "", MessageBoxButtons.OK);
                txtMAPC.Focus();
                return;
            }
            if (cmbLMB.Text.Trim() == "")
            {
                MessageBox.Show("Loại máy bay không được thiếu!", "", MessageBoxButtons.OK);
                cmbLMB.Focus();
                return;
            }
            try
            {
                bdsLAI.EndEdit();
                bdsLAI.ResetCurrentItem();
                this.lAITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lAITableAdapter.Update(this.dS.LAI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled  = false;
            cmbLMB.Enabled = false;
        }
    }
}
