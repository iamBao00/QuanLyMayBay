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
    public partial class FormPhiCong : Form
    {
        int vitri = 0;
        int dangThemMoi = 0;
        public FormPhiCong()
        {
            InitializeComponent();
        }

        private void thongTinPhiCongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_ThongTinPhiCong.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormPhiCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.LOAIMAYBAY' table. You can move, or remove it, as needed.
            this.lOAIMAYBAYTableAdapter.Fill(this.dS.LOAIMAYBAY);
            // TODO: This line of code loads data into the 'dS.LAI' table. You can move, or remove it, as needed.

            dS.EnforceConstraints = false;


            this.thongTinPhiCongTableAdapter.Connection.ConnectionString = Program.connstr;
            this.thongTinPhiCongTableAdapter.Fill(this.dS.ThongTinPhiCong);
            this.lAITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lAITableAdapter.Fill(this.dS.LAI);
            GC_TTPC.Enabled = true;
            panelControl1.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = 1;
            txtMaPC.Enabled = true;
            txtCMND.Enabled = true;
            vitri = bds_ThongTinPhiCong.Position;
            panelControl1.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            GC_TTPC.Enabled = false;
            bds_ThongTinPhiCong.AddNew();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_ThongTinPhiCong.CancelEdit();
            this.thongTinPhiCongTableAdapter.Fill(this.dS.ThongTinPhiCong);
            bds_ThongTinPhiCong.Position = vitri;
            panelControl1.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            GC_TTPC.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.thongTinPhiCongTableAdapter.Fill(this.dS.ThongTinPhiCong);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload !" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bds_ThongTinPhiCong.Position;
            txtMaPC.Enabled = false;
            txtCMND.Enabled = false;
            panelControl1.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            GC_TTPC.Enabled = false;
            dangThemMoi = 0;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaPC.Text.Trim() == "")
            {
                MessageBox.Show("Mã Phi Công không được thiếu!", "", MessageBoxButtons.OK);
                txtMaPC.Focus();
                return;
            }
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Số CMND không được thiếu!", "", MessageBoxButtons.OK);
                txtCMND.Focus();
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
            if (txtMaSoBang.Text.Trim() == "")
            {
                MessageBox.Show("Mã Số bằng không được thiếu!", "", MessageBoxButtons.OK);
                txtMaSoBang.Focus();
                return;
            }
            if (txtNgayCap.Text.Trim() == "")
            {
                MessageBox.Show("Lương không được thiếu!", "", MessageBoxButtons.OK);
                txtNgayCap.Focus();
                return;
            }

            try
            {
                if (dangThemMoi == 1)
                {
                    // Kiem Tra Neu CMND da ton tai
                    string strLenh = "declare @result int exec @result = sp_CheckNguoiTonTai  '" + txtCMND.Text + "' select @result";

                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close();

                    if (result == 1)
                    {
                        MessageBox.Show("Số CMND của người này đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                    else
                    {
                        Program.myReader.Close();
                    }
                    // KIEM TRA MA NV TON TAI (CHUA LAM)
                    string checkMaPC = "exec [dbo].[sp_CheckTonTai] 'PHICONG', 'MAPC'," + txtMaPC.Text;

                    Program.myReader = Program.ExecSqlDataReader(checkMaPC);
                    if (Program.myReader == null) { return; }
                    Program.myReader.Read();
                    if (Program.myReader.GetInt32(0) == 1)
                    {
                        MessageBox.Show("Mã phi công đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                    else
                    {
                        Program.myReader.Close();
                    }

                    // THEM VAO TABLE NHANVIEN va TABLE NGUOI
                    string themNguoi = "EXEC [dbo].[sp_ThemNguoi] @CMND =" + txtCMND.Text + ", @HoTen = N'" + txtHoTen.Text + "', @DiaChi = N'" + txtDiaChi.Text + "', @SoDienThoai = " + txtSDT.Text + ", @MaChu = null";
                    Program.ExecSqlNonQuery(themNguoi);
                    string themNV = "EXEC [dbo].[sp_ThemPhiCong] @CMND =" + txtCMND.Text + ", @MaSoBang = " + txtMaSoBang.Text + ", @NgayCap = '" + txtNgayCap.Text + "', @MaPC = " + txtMaPC.Text;
                    Program.ExecSqlNonQuery(themNV);
                    this.thongTinPhiCongTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.thongTinPhiCongTableAdapter.Fill(this.dS.ThongTinPhiCong);
                }
                else
                {
                    // SUa TABLE NHANVIEN va TABLE NGUOI
                    string suaNguoi = "EXEC [dbo].[sp_SuaNguoi] @CMND =" + txtCMND.Text + ", @HoTen = N'" + txtHoTen.Text + "', @DiaChi = N'" + txtDiaChi.Text + "', @SoDienThoai = " + txtSDT.Text + ", @MaChu = null";
                    Program.ExecSqlNonQuery(suaNguoi);
                    string suaNV = "EXEC [dbo].[sp_SuaPhiCong] @CMND =" + txtCMND.Text + ", @MaSoBang = " + txtMaSoBang.Text + ", @NgayCap = '" + txtNgayCap.Text + "', @MaPC = " + txtMaPC.Text;
                    Program.ExecSqlNonQuery(suaNV);
                    this.thongTinPhiCongTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.thongTinPhiCongTableAdapter.Fill(this.dS.ThongTinPhiCong);
                }
                bds_ThongTinPhiCong.EndEdit();
                bds_ThongTinPhiCong.ResetCurrentItem();
                this.thongTinPhiCongTableAdapter.Connection.ConnectionString = Program.connstr;
                this.thongTinPhiCongTableAdapter.Update(this.dS.ThongTinPhiCong);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi\n" + ex.Message, "", MessageBoxButtons.OK);
                this.thongTinPhiCongTableAdapter.Fill(this.dS.ThongTinPhiCong);
                bds_ThongTinPhiCong.Position = vitri;
            }


            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnSua.Enabled = true;
            btnHuy.Enabled = btnGhi.Enabled = false;
            panelControl1.Enabled = false;
            GC_TTPC.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa phi công này!", "Xác nhận", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                string xoaNV = "EXEC [dbo].[sp_XoaPhiCong] @MaPC =" + txtMaPC.Text;
                Program.ExecSqlNonQuery(xoaNV);
                string xoaNguoi = "EXEC [dbo].[sp_XoaNguoi] @CMND =" + txtCMND.Text;
                Program.ExecSqlNonQuery(xoaNguoi);

                bds_ThongTinPhiCong.RemoveCurrent();
                this.thongTinPhiCongTableAdapter.Connection.ConnectionString = Program.connstr;
                this.thongTinPhiCongTableAdapter.Update(this.dS.ThongTinPhiCong);

            }
        }

        private void mAPHICONGLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mAPHICONGTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

    }
}
