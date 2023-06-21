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
    public partial class frmNhanVien : Form
    {
        int vitri = 0;
        bool dangThemMoi = false;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nGUOIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNguoi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            
            DS.EnforceConstraints = false;
            this.nGUOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.nGUOITableAdapter.Fill(this.DS.NGUOI);
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            this.cHUYENVETableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHUYENVETableAdapter.Fill(this.DS.CHUYENVE);
            this.dICHVUBAOTRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.dICHVUBAOTRITableAdapter.Fill(this.DS.DICHVUBAOTRI);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNguoi.Position;
            dangThemMoi = true;
            panelControl1.Enabled = true;
            panelControl2.Enabled = false;
            gcNhanVien.Enabled = false;
            gcNguoi.Enabled = false;
            bdsNguoi.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNguoi.Position;
            panelControl1.Enabled = true;
            panelControl2.Enabled = false;
            gcNhanVien.Enabled = false;
            gcNguoi.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa người này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String socmnd = ((DataRowView)bdsNguoi[bdsNguoi.Position])["SOCMND"].ToString();
                try
                {

                    bdsNguoi.RemoveCurrent();
                    this.nGUOITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nGUOITableAdapter.Update(this.DS.NGUOI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nGUOITableAdapter.Fill(this.DS.NGUOI);
                    bdsNguoi.Position = bdsNguoi.Find("SOCMND", socmnd);
                    return;
                }
                panelControl1.Enabled = true;
                panelControl2.Enabled = true;
                gcNhanVien.Enabled = true;
                gcNguoi.Enabled = true;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtSCMND.Text.Trim() == "")
            {
                MessageBox.Show("Số CMND không được thiếu!", "", MessageBoxButtons.OK);
                txtSCMND.Focus();
                return;
            }
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên không được thiếu!", "", MessageBoxButtons.OK);
                txtHoTen.Focus();
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
                if (dangThemMoi)
                {
                    dangThemMoi = false;
                    string strLenh = "declare @result int exec @result = sp_CheckNguoiTonTai  '" + txtSCMND.Text + "' select @result";

                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close();

                    if (result == 1)
                    {
                        throw new Exception("Số CMND đã được sử dụng! Vui lòng nhập lại Số CMND khác");
                    }


                }

                bdsNguoi.EndEdit();
                bdsNguoi.ResetCurrentItem();
                this.nGUOITableAdapter.Connection.ConnectionString = Program.connstr;
                this.nGUOITableAdapter.Update(this.DS.NGUOI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi\n" + ex.Message, "", MessageBoxButtons.OK);
                this.nGUOITableAdapter.Fill(this.DS.NGUOI);
                bdsNguoi.Position = vitri;
            }
            panelControl1.Enabled = true;
            panelControl2.Enabled = true;
            gcNhanVien.Enabled = true;
            gcNguoi.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;

        }
        private void reload()
        {

            try
            {
                vitri = bdsNguoi.Position;
                this.nGUOITableAdapter.Fill(this.DS.NGUOI);
                this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                bdsNguoi.Position = vitri;
                panelControl1.Enabled = true;
                panelControl2.Enabled = true;
                gcNhanVien.Enabled = true;
                gcNguoi.Enabled = true;

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
            bdsNguoi.CancelEdit();
            if (btnThem.Enabled == false)
            {
                reload();
            }

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
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

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled = btnReload.Enabled = false; 
            btnThoat.Enabled = true;
            
            bdsNV.AddNew();
            txtSCMNDNV.Text = txtSCMND.Text;
            panelControl1.Enabled = false;
            panelControl2.Enabled = true;
            gcNguoi.Enabled = false;
            gcNhanVien.Enabled = true;
            btnThemNV.Enabled = btnXoaNV.Enabled = btnHieuChinhNV.Enabled = false;
            btnGhiNV.Enabled = btnPhucHoiNV.Enabled = true;

        }

        private void btnHieuChinhNV_Click(object sender, EventArgs e)
        {
            panelControl1.Enabled = false;
            panelControl2.Enabled = true;
            gcNguoi.Enabled = false;
            gcNhanVien.Enabled = true;
            btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = false;

            btnThemNV.Enabled = btnXoaNV.Enabled = btnHieuChinhNV.Enabled = false;
            btnGhiNV.Enabled = btnPhucHoiNV.Enabled = true;

        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsNV.RemoveCurrent();
                    this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nHANVIENTableAdapter.Update(this.DS.NHANVIEN);
                    panelControl1.Enabled = true;
                    panelControl2.Enabled = true;
                    gcNguoi.Enabled = true;
                    gcNhanVien.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                    return;
                }

            }
        }

        private void btnGhiNV_Click(object sender, EventArgs e)
        {
            if (txtLuong.Text.Trim() == "")
            {
                MessageBox.Show("Lương không được thiếu!", "", MessageBoxButtons.OK);
                txtLuong.Focus();
                return;
            }
            if (txtCa.Text.Trim() == "")
            {
                MessageBox.Show("Ca không được thiếu!", "", MessageBoxButtons.OK);
                txtCa.Focus();
                return;
            }
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            try
            {
                bdsNV.EndEdit();
                bdsNV.ResetCurrentItem();
                this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nHANVIENTableAdapter.Update(this.DS.NHANVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi nhân viên\n" + ex.Message, "", MessageBoxButtons.OK);
                this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            }
            panelControl1.Enabled = true;
            panelControl2.Enabled = true;
            gcNguoi.Enabled = true;
            gcNhanVien.Enabled = true;
            btnThemNV.Enabled = btnXoaNV.Enabled = btnHieuChinhNV.Enabled = true;
            btnGhiNV.Enabled = btnPhucHoiNV.Enabled = false;
            btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = true;

        }

        private void btnPhucHoiNV_Click(object sender, EventArgs e)
        {
            bdsNV.CancelEdit();
            reload();
            btnThemNV.Enabled = btnXoaNV.Enabled = btnHieuChinhNV.Enabled = true;
            btnGhiNV.Enabled = btnPhucHoiNV.Enabled = false;
            btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }
    }
}
