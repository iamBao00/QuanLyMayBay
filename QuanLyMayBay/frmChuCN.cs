using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;


namespace QuanLyMayBay
{
    public partial class frmChuCN : Form
    {
        int vitri = 0;
        bool dangThemMoi = false;
        public frmChuCN()
        {
            InitializeComponent();
        }

        private void cHUMAYBAYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCMB.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChu_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.nGUOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.nGUOITableAdapter.Fill(this.DS.NGUOI);
            this.cHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHUMAYBAYTableAdapter.Fill(this.DS.CHUMAYBAY);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            vitri = bdsCMB.Position;
            dangThemMoi = true;
            panelControl1.Enabled = true;
            panelControl2.Enabled = false;
            gcChu.Enabled = false;
            gcNguoi.Enabled = false;
            bdsCMB.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            /*try
            {
                String strLenh = "DECLARE @ma int = DBO.UDF_TangMaChu() " + "SELECT @MA";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                txtMaChu.Text = Program.myReader.GetDouble(0).ToString();
                Program.myReader.Close();
                Program.conn.Close();

            }
            catch (Exception ex)
            {
                bdsCMB.EndEdit();
                bdsCMB.RemoveCurrent();
                MessageBox.Show("Không thể kết nối. " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }*/
            String strLenh = "DECLARE @ma int = DBO.UDF_TangMaChu() " + "SELECT @MA";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            txtMaChu.Text = Program.myReader.GetInt32(0).ToString();
            Program.myReader.Close();
            Program.conn.Close();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa mã chủ này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String machu = ((DataRowView)bdsCMB[bdsCMB.Position])["MACHU"].ToString();
                try
                {

                    bdsCMB.RemoveCurrent();
                    this.cHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cHUMAYBAYTableAdapter.Update(this.DS.CHUMAYBAY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.cHUMAYBAYTableAdapter.Fill(this.DS.CHUMAYBAY);
                    bdsCMB.Position = bdsCMB.Find("MACHU", machu);
                    return;
                }
                panelControl1.Enabled = true;
                panelControl2.Enabled = true;
                gcChu.Enabled = true;
                gcNguoi.Enabled = true;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsCMB.EndEdit();
                bdsCMB.ResetCurrentItem();
                this.cHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cHUMAYBAYTableAdapter.Update(this.DS.CHUMAYBAY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi.\n" + ex.Message, "", MessageBoxButtons.OK);
                this.cHUMAYBAYTableAdapter.Fill(this.DS.CHUMAYBAY);
            }
            panelControl1.Enabled = true;
            panelControl2.Enabled = true;
            gcNguoi.Enabled = true;
            gcChu.Enabled = true;
            btnThemN.Enabled = btnXoaN.Enabled = btnHieuChinhN.Enabled = true;
            btnGhiN.Enabled = btnPhucHoiN.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }
        private void reload()
        {

            try
            {
                vitri = bdsCMB.Position;
                this.nGUOITableAdapter.Fill(this.DS.NGUOI);
                this.cHUMAYBAYTableAdapter.Fill(this.DS.CHUMAYBAY);
                bdsNguoi.Position = vitri;
                panelControl1.Enabled = true;
                panelControl2.Enabled = true;
                gcChu.Enabled = true;
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
            bdsCMB.CancelEdit();
            if (btnThem.Enabled == false)
            {
                reload();
            }

            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
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

        private void btnThemN_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled =  btnGhi.Enabled = false;
            btnPhucHoi.Enabled = btnThoat.Enabled = true;
            
            bdsNguoi.AddNew();
            txtMaChuN.Text = txtMaChu.Text;
            panelControl1.Enabled = false;
            panelControl2.Enabled = true;
            gcNguoi.Enabled =true;
            gcChu.Enabled = false;
            btnThemN.Enabled = btnXoaN.Enabled = btnHieuChinhN.Enabled = false;
            btnGhiN.Enabled = btnPhucHoiN.Enabled = true;
        }

        private void btnHieuChinhN_Click(object sender, EventArgs e)
        {
            panelControl1.Enabled = false;
            panelControl2.Enabled = true;
            gcNguoi.Enabled = true;
            gcChu.Enabled = false;
            btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = false;

            btnThemN.Enabled = btnXoaN.Enabled = btnHieuChinhN.Enabled = false;
            btnGhiN.Enabled = btnPhucHoiN.Enabled = true;
        }

        private void btnXoaN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa người này không ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsNguoi.RemoveCurrent();
                    this.nGUOITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nGUOITableAdapter.Update(this.DS.NGUOI);
                    panelControl1.Enabled = true;
                    panelControl2.Enabled = true;
                    gcNguoi.Enabled = true;
                    gcChu.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nGUOITableAdapter.Fill(this.DS.NGUOI);
                    return;
                }

            }
        }

        private void btnGhiN_Click(object sender, EventArgs e)
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
                if(txtMaChuN.Text != "")
                {
                    string checkMaChu = "exec [dbo].[sp_CheckTonTai] 'NGUOI', 'MACHU'," + txtMaChuN.Text;

                    Program.myReader = Program.ExecSqlDataReader(checkMaChu);
                    if (Program.myReader == null) { return; }
                    Program.myReader.Read();
                    if (Program.myReader.GetInt32(0) == 1)
                    {
                        MessageBox.Show("Mã chủ đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        btnThemN.Enabled = btnXoaN.Enabled = btnHieuChinhN.Enabled = true;
                        btnGhiN.Enabled = btnPhucHoiN.Enabled = false;
                        return;
                    }
                    else
                    {
                        Program.myReader.Close();
                    }
                }

                bdsNguoi.EndEdit();
                bdsNguoi.ResetCurrentItem();
                this.nGUOITableAdapter.Connection.ConnectionString = Program.connstr;
                this.nGUOITableAdapter.Update(this.DS.NGUOI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi.\n" + ex.Message, "", MessageBoxButtons.OK);
                this.nGUOITableAdapter.Fill(this.DS.NGUOI);
            }
            panelControl1.Enabled = true;
            panelControl2.Enabled = true;
            gcNguoi.Enabled = true;
            gcChu.Enabled = true;
            btnThemN.Enabled = btnXoaN.Enabled = btnHieuChinhN.Enabled = true;
            btnGhiN.Enabled = btnPhucHoiN.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;          
        }

        private void btnPhucHoiN_Click(object sender, EventArgs e)
        {
            bdsNguoi.CancelEdit();
            reload();
            btnThemN.Enabled = btnXoaN.Enabled = btnHieuChinhN.Enabled = true;
            btnGhiN.Enabled = btnPhucHoiN.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }
    }
}
