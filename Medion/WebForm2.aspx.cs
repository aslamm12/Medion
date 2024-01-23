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
    public partial class WebForm2 : System.Web.UI.Page
    {
        CoClass objcls = new CoClass();

        public void gridBind()
        {
            string selall = "select * from cat_tab";
            DataSet ds = objcls.dataset(selall);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                gridBind();
            }
           

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from cat_tab where cat_id=" + getid + "";
            objcls.query(del);
            gridBind();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex= -1;
            gridBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtname = (TextBox)GridView1.Rows[i].Cells[0].Controls[0];
            TextBox txtdesc = (TextBox)GridView1.Rows[i].Cells[0].Controls[0];
            string upd="update cat_tab set cat_name='"+txtname.Text+"',cat_desc='"+txtdesc.Text+"'where cat_id="+getid+"";
            objcls.query(upd);
            gridBind();
        }
    }
}