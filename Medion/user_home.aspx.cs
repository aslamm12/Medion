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
    public partial class user_home : System.Web.UI.Page
    {
        CoClass objcls = new CoClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                datalistBind();
            }

        }

        public void datalistBind()
        {
            string selall = "select * from cat_tab";
            DataSet ds = objcls.dataset(selall);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int cat_id = Convert.ToInt32(e.CommandArgument);
            Session["cat_id"] = cat_id;
            Response.Redirect("dis_product.aspx");

        }

       
    }
}