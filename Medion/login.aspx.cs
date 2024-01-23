using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Medion
{
    public partial class login : System.Web.UI.Page
    {
        CoClass objcls = new CoClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(reg_id) from login where username='"+TextBox1.Text+"' and password='"+TextBox2.Text+"'";
            string cid = objcls.scalar(str);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string selid = "select reg_id from login where username ='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
                string regid = objcls.scalar(selid);
                Session["userid"] = regid;
                string sellt = "select log_type from login where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
                string logtype = objcls.scalar(sellt);

                if (logtype == "admin")
                {
                    Response.Redirect("admin_page.aspx");
                }
                else if (logtype == "user")

                {
                    Response.Redirect("user_home.aspx");
                }
            }
        }
    }
}