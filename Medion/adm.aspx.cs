using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Medion
{
    public partial class adm : System.Web.UI.Page
    {
        CoClass objcls = new CoClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)

        {
            string sel = "select max(reg_id) from login";
            string regid = objcls.scalar(sel);
            int rg_id = 0;

            if (regid == "")
            {
                rg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                rg_id = newregid + 1;
            }
            string ins = "insert into admin values(" + rg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','"+TextBox3.Text+"')";
            int i = objcls.query(ins);
            string inslog = "insert into login values(" + rg_id + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','admin','active')";
            int j = objcls.query(inslog);

      

        }
    }
}