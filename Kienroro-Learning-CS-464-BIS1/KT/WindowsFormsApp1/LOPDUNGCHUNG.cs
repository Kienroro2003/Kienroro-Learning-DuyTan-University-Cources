using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class LOPDUNGCHUNG
    {
//        CREATE TABLE[dbo].[NHANVIEN]
//        (

//   [MSNV] NVARCHAR (50) NOT NULL,

//[HOTEN]    NVARCHAR(50) NULL,
//    [DIACHI] NVARCHAR(50) NULL,
//    [NGAYSINH]
//        DATETIME NULL,
//    [CHUCVU]   NCHAR(10)    NULL,
//    PRIMARY KEY CLUSTERED([MSNV] ASC)
//);
        string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\WindowsFormsApp1\WindowsFormsApp1\CSDL.mdf;Integrated Security=True";
        SqlConnection conn;
        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(chuoikn);
        }
        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public object LayGT(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
    }
}
