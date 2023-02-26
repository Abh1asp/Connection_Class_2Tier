using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace _2_Tier
{
    public partial class Profile : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select Name,Email,Photo from Reg where Id=" + Session["uid"] + "";
            SqlDataReader dr = obj.Fn_read(sel);
            while (dr.Read())
            {
                Label1.Text = dr["Name"].ToString();
                Label2.Text = dr["Email"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }
        }
    }
}