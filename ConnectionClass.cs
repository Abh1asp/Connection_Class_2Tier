using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace _2_Tier
{
    public class ConnectionClass
    {
        SqlCommand cmd;
        SqlConnection con;
        public ConnectionClass()
        {
            con = new SqlConnection(@"server=DESKTOP-IFK5AR1\SQLEXPRESS;database=Test;integrated security=true");
        }
        public int Fn_nq(string sql)
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            con.Close();
            return a;
        }
        public string Fn_scalar(string sql)
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
        public SqlDataReader Fn_read(string sql)
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public DataSet Fn_ds(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataTable Fn_dt(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}