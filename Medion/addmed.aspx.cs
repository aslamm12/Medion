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

    public partial class addmed : System.Web.UI.Page
    {
        CoClass objcls = new CoClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select cat_id,cat_name from cat_tab";
            DataSet ds = objcls.dataset(s);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "cat_name";
            DropDownList1.DataValueField = "cat_id";
            DropDownList1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/pdtimg/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string str = "insert into pdt_tab values("+DropDownList1.SelectedValue+",'" + TextBox1.Text + "','" + p + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','availiable')";
            int i = objcls.query(str);
            if (i != 0)
            {
                Label1.Visible = true;
                Label1.Text = "inserted";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("editmed.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            Label1.Text = " ";
         
        }
    }
}