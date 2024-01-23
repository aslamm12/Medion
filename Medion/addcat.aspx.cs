using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Medion
{
    public partial class addcat : System.Web.UI.Page
    {
        CoClass objcls = new CoClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/catimg/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string str = "insert into cat_tab values('" + TextBox1.Text + "','" + p + "','" + TextBox2.Text + "','available')";
            int i = objcls.query(str);
            if (i != 0)
            {
                Label2.Visible = true;
                Label2.Text = "category added successfully";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
           
            Label2.Text = " ";
        }
    }
}