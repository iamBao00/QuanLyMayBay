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
    public partial class FormChuyenVe : Form
    {
        int dangThemMoi = 0;
        public FormChuyenVe()
        {
            InitializeComponent();
        }

        private void FormChuyenVe_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.cB_LOAIMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cB_LOAIMAYBAYTableAdapter.Fill(this.dS.CB_LOAIMAYBAY);

            this.cHUYENVETableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHUYENVETableAdapter.Fill(this.dS.CHUYENVE);

            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);

            txtMaNV.Enabled = false;
            txtMaLoai.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            cmb_Loai.Enabled = false;
            if(Program.mGroup == "NHANVIEN")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = false;
            }
        }

        private void txtLoai_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Loai.SelectedValue != null) txtMaLoai.Text = cmb_Loai.SelectedValue.ToString();
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
            txtMaNV.Enabled = false;
            txtMaLoai.Enabled = false;
            panelControl1.Enabled = true;
            cmb_Loai.Enabled = true;
            bds_ChuyenVe.AddNew();
        }

        private void txtMaNV_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView dt = null;
            if (bds_NhanVien.Position != -1)
                 dt = ((DataRowView)bds_NhanVien[bds_NhanVien.Position]);
            if (dt != null)
                txtMaNV.Text = dt["MaNV"].ToString();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_ChuyenVe.CancelEdit();
            this.cHUYENVETableAdapter.Fill(this.dS.CHUYENVE);
            panelControl1.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.cHUYENVETableAdapter.Fill(this.dS.CHUYENVE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload !" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhan vien không được thiếu!", "", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            if (txtMaLoai.Text.Trim() == "")
            {
                MessageBox.Show("Mã loại không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLoai.Focus();
                return;
            }
            try
            {
                bds_ChuyenVe.EndEdit();
                bds_ChuyenVe.ResetCurrentItem();
                this.cHUYENVETableAdapter.Connection.ConnectionString = Program.connstr;
                this.cHUYENVETableAdapter.Update(this.dS.CHUYENVE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = cmb_Loai.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            cmb_Loai.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_ChuyenVe.Count == 0)
            {
                MessageBox.Show("Không có loại MB mà nhân viên này chuyên về để xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa loại máy bay nhân viên này chuyên về!", "Xác nhận", MessageBoxButtons.OKCancel)
                   == DialogResult.OK)
            {
                Int32 manv = 0;
                try
                {
                    manv = int.Parse(((DataRowView)bds_ChuyenVe[bds_ChuyenVe.Position])["MANV"].ToString());
                    bds_ChuyenVe.RemoveCurrent();
                    this.cHUYENVETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cHUYENVETableAdapter.Update(this.dS.CHUYENVE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.cHUYENVETableAdapter.Fill(this.dS.CHUYENVE);
                    bds_ChuyenVe.Position = bds_ChuyenVe.Find("MANV", manv);
                    return;
                }
            }
        }
    }
}
