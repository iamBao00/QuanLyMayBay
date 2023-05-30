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
            panelControl2.Enabled = false;
            bdsNguoi.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNguoi.Position;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcNguoi.Enabled = false;

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

            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (dangThemMoi)
                {
                    dangThemMoi = false;
                    string strLenh = "declare @result int exec @result = sp_KiemTraMaDonDatHang '" + txtSCMND.Text + "' select @result";

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
            gcNguoi.Enabled = true;

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
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;

            bdsNV.AddNew();
            txtSCMNDNV.Text = txtSCMND.Text;

            btnThemNV.Enabled = btnXoaNV.Enabled = btnHieuChinhNV.Enabled = false;
            btnGhiNV.Enabled = btnPhucHoiNV.Enabled = true;

        }

        private void btnHieuChinhNV_Click(object sender, EventArgs e)
        {
            panelControl2.Enabled = true;
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

            btnThemNV.Enabled = btnXoaNV.Enabled = btnHieuChinhNV.Enabled = true;
            btnGhiNV.Enabled = btnPhucHoiNV.Enabled = false;
            btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = true;

        }

        private void btnPhucHoiNV_Click(object sender, EventArgs e)
        {
            bdsNV.CancelEdit();
            reload();
            gcNhanVien.Enabled = true;
            btnThemNV.Enabled = btnXoaNV.Enabled = btnHieuChinhNV.Enabled = true;
            btnGhiNV.Enabled = btnPhucHoiNV.Enabled = false;
            btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }
    }
}
