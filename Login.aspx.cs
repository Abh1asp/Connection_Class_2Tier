using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_Tier
{
    public partial class Login : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select count(Id) from Reg where UserName='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string cid = obj.Fn_scalar(sel);
            if (cid == "1")
            {
                string sel1 = "select Id from Reg where UserName='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string id = obj.Fn_scalar(sel1);
                Session["uid"] = id;
                Response.Redirect("Profile.aspx");
            }
            else
            {
                Label1.Text = "Please Register";
            }
        }
    }
}