using System;
using System.Data;
using System.Data.SqlClient;

namespace diagnosisAnimal.General
{
    class DataProcess
    {
        private String strConn;
        private SqlConnection conn;
        private String error;

        public string Error { get => error; set => error = value; }

        public DataProcess()
        {
            strConn = @"Data Source=DESKTOP-HE9DPLI\SQLEXPRESS;Initial Catalog=diagnosisAnimal;Integrated Security=True";
            conn = new SqlConnection(strConn);
        }

        public bool openConnect(){
            try{
                conn.Open();
                return true;
            }catch(Exception e) {
                error = e.Message;
                return false;
            }
        }

        public void closeConnect()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        public DataTable getData(String sql)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, conn);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            return data;
        }

        public SqlDataAdapter getDa(String sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            return adapter;
        }

        public bool ExecuteCommand(String strSql)
        {
            int result = 0;
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand(strSql, conn);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                result = 0;
            }
            finally
            {
                closeConnect();
            }
            return result > 0;
        }

        public int LenhVoHuong(String strSql)
        {
            int result = 0;
            try
            {
                error = "";
                openConnect();
                SqlCommand cmd = new SqlCommand(strSql, conn);
                result = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                closeConnect();
            }
            return result;
        }
    }
}
