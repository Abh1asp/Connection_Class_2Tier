using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_Tier
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    s = s + CheckBoxList1.Items[i].Text + ",";
                }
            }

            string path = "~/photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            string ins = "insert into Reg values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','" + DropDownList1.SelectedItem + "','" + TextBox5.Text + "','" + RadioButtonList1.SelectedItem + "','" + path + "','" + s + "','" + TextBox6.Text + "','" + TextBox7.Text + "')";
            int a = obj.Fn_nq(ins);
            if (a != 0)
            {
                Label1.Text = "Registeration Successfull";
            }
        }
    }
}