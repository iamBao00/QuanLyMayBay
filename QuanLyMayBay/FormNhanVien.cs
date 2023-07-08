using DevExpress.DataAccess.Wizard.Model;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
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
    public partial class FormNhanVien : Form
    {
        int vitri = 0;
        int dangThemMoi = 0;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.thongTinNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.thongTinNhanVienTableAdapter.Fill(this.dS.ThongTinNhanVien);

            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);

            this.nGUOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.nGUOITableAdapter.Fill(this.dS.NGUOI);

            panelControl1.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void cATextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void sODIENTHOAILabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = 1;
            txtMaNV.Enabled = true;
            txtCMND.Enabled = true;
            vitri = bds_ThongTinNhanVien.Position;
            panelControl1.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            GC_TTNV.Enabled = false;
            bds_ThongTinNhanVien.AddNew();
        }


        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_ThongTinNhanVien.CancelEdit();
            this.thongTinNhanVienTableAdapter.Fill(this.dS.ThongTinNhanVien);
            bds_ThongTinNhanVien.Position = vitri;
            panelControl1.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            GC_TTNV.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.thongTinNhanVienTableAdapter.Fill(this.dS.ThongTinNhanVien);
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
                MessageBox.Show("Mã Nhân Viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMaNV.Focus();
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
            if (txtCa.Text.Trim() == "")
            {
                MessageBox.Show("Ca không được thiếu!", "", MessageBoxButtons.OK);
                txtCa.Focus();
                return;
            }
            if (txtLuong.Text.Trim() == "")
            {
                MessageBox.Show("Lương không được thiếu!", "", MessageBoxButtons.OK);
                txtLuong.Focus();
                return;
            }
            try
            {
                if (dangThemMoi==1)
                {
                    // Kiem Tra Neu CMND da ton tai
                    string strLenh = "declare @result int exec @result = sp_CheckNguoiTonTai  '" + txtCMND.Text + "' select @result";

                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close();

                    if (result == 1)
                    {
                        throw new Exception("Số CMND đã tồn tại!");
                    }
                    // KIEM TRA MA NV TON TAI (CHUA LAM)

                    // THEM VAO TABLE NHANVIEN va TABLE NGUOI
                    string themNguoi = "EXEC [dbo].[sp_ThemNguoi] @CMND =" + txtCMND.Text + ", @HoTen = N'" + txtHoTen.Text + "', @DiaChi = N'" + txtDiaChi.Text + "', @SoDienThoai = " + txtSDT.Text + ", @MaChu = null";
                    Program.ExecSqlNonQuery(themNguoi);
                    string themNV = "EXEC [dbo].[sp_ThemNhanVien] @CMND ="+ txtCMND.Text + ", @Luong = "+ txtLuong.Text + ", @Ca = "+ txtCa.Text + ", @MaNV = "+ txtMaNV.Text;
                    Program.ExecSqlNonQuery(themNV);
                    this.thongTinNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.thongTinNhanVienTableAdapter.Fill(this.dS.ThongTinNhanVien);
                }
                else
                {
                    // SUa TABLE NHANVIEN va TABLE NGUOI
                    string suaNguoi = "EXEC [dbo].[sp_SuaNguoi] @CMND =" + txtCMND.Text + ", @HoTen = N'" + txtHoTen.Text + "', @DiaChi = N'" + txtDiaChi.Text + "', @SoDienThoai = " + txtSDT.Text + ", @MaChu = null";
                    Program.ExecSqlNonQuery(suaNguoi);
                    string suaNV = "EXEC [dbo].[sp_SuaNhanVien] @CMND =" + txtCMND.Text + ", @Luong = " + txtLuong.Text + ", @Ca = " + txtCa.Text + ", @MaNV = " + txtMaNV.Text;
                    Program.ExecSqlNonQuery(suaNV);
                    this.thongTinNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.thongTinNhanVienTableAdapter.Fill(this.dS.ThongTinNhanVien);
                }
                bds_ThongTinNhanVien.EndEdit();
                bds_ThongTinNhanVien.ResetCurrentItem();
                this.thongTinNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.thongTinNhanVienTableAdapter.Update(this.dS.ThongTinNhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi\n" + ex.Message, "", MessageBoxButtons.OK);
                this.thongTinNhanVienTableAdapter.Fill(this.dS.ThongTinNhanVien);
                bds_ThongTinNhanVien.Position = vitri;
            }
            
            
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnSua.Enabled = true;
            btnHuy.Enabled = btnGhi.Enabled = false;
            panelControl1.Enabled = false;
            GC_TTNV.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bds_ThongTinNhanVien.Position;
            txtMaNV.Enabled = false;
            txtCMND.Enabled = false;
            panelControl1.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            GC_TTNV.Enabled = false;
            dangThemMoi = 0;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này!", "Xác nhận", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                bds_ThongTinNhanVien.RemoveCurrent();
                this.thongTinNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.thongTinNhanVienTableAdapter.Update(this.dS.ThongTinNhanVien);

                string xoaNV = "EXEC [dbo].[sp_XoaNhanVien] @MaNV =" + txtMaNV.Text;
                Program.ExecSqlNonQuery(xoaNV);
                string xoaNguoi = "EXEC [dbo].[sp_XoaNguoi] @CMND =" + txtCMND.Text ;
                Program.ExecSqlNonQuery(xoaNguoi);
                
            }
        }
    }
}
