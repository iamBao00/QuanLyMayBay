﻿using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyMayBay
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source= MSI;Initial Catalog= QUANLYSANBAY; Integrated Security = True";
        public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static String servername = "MSI";
        public static String username = "";
        public static String password = "";
        public static String database = "QUANLYSANBAY";

        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mHoTen = "";
        public static String mGroup = "";
        public static String mlogin = "";

        public static int mChinhanh = 0;
        public static string maNhanVienDuocChon = "";


        public static FormMain formChinh;

        public static int KetNoi()
        {
            try
            {
                if (Program.conn.State == ConnectionState.Open) Program.conn.Close();
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Console.WriteLine(Program.servername);
                Console.WriteLine(Program.database);
                Console.WriteLine(Program.mlogin);
                Console.WriteLine(Program.password);
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            //Program.conn = new SqlConnection(connectionstring);

            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String strlenh)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            da = new SqlDataAdapter(strlenh, conn);
            da.Fill(dt);
            conn.Close();
            return dt;

        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;
            // 10 Phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {

                Sqlcmd.ExecuteNonQuery(); conn.Close(); return 1;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formChinh = new FormMain();
            Application.Run(formChinh);
        }
    }
}
