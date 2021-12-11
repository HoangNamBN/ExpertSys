using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BTL_HeChuyenGia_N02.ThuVien
{
    class XuLyDuLieu
    {
        private String strConn;
        private SqlConnection conn;
        private String loi;

        public String Loi
        {
            get { return loi; }
            set { loi = value; }
        }

        public XuLyDuLieu()
        {
            strConn = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=ChuanDoanBenh;Integrated Security=True";
            conn = new SqlConnection(strConn);
        }

        public bool MoKetNoi()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                loi = ex.Message;
                return false;
            }
        }

        public void DongKetNoi()
        {
            if (conn != null)
                conn.Close();
        }

        public DataTable LayDt(String strSql)
        {
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public SqlDataAdapter LayDa(String strSql)
        {
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            return da;
        }

        public bool ThucHienCauLenh(String strSql)
        {
            int kq = 0;
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(strSql, conn);
                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                loi = ex.Message;
                kq = 0;
            }
            finally
            {
                DongKetNoi();
            }
            return kq > 0;
        }

        public int LenhVoHuong(String strSql)
        {
            int kq = 0;
            try
            {
                loi = "";
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(strSql, conn);
                kq = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                loi = ex.Message;
            }
            finally
            {
                DongKetNoi();
            }
            return kq;
        }

    }
}
