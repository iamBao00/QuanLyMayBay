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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (teUserName.Text.Trim() == "" || tePassword.Text.Trim() == "")
            {
                MessageBox.Show("Username và password không được trống", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = teUserName.Text.Trim();
            Program.password = tePassword.Text.Trim();

            if (Program.KetNoi() == 0) return;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            string strLenh = "EXEC LAY_THONG_TIN '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            Program.username = Program.myReader.GetInt32(0).ToString();

            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu " +
                    "\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
            }
            Program.mHoTen = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();

            Program.conn.Close();

            Program.formChinh.MANV.Text = "Mã NV : " + Program.username;
            Program.formChinh.HOTEN.Text = "Họ tên : " + Program.mHoTen;
            Program.formChinh.NHOM.Text = "Nhóm : " + Program.mGroup;
            Program.formChinh.HienThiMenu();
            this.Close();
        
    }
    }
}
