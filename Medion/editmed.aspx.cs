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
    public partial class editmed : System.Web.UI.Page
    {
        CoClass objcls = new CoClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gridBind();
            }
        }
        public void gridBind()
        {
            string selall = "select * from pdt_tab";
            DataSet ds = objcls.dataset(selall);
            GridView2.DataSource = ds;
            GridView2.DataBind();
        }
        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //int i = e.RowIndex;
            //int getid = Convert.ToInt32(GridView2.DataKeys[i].Value);
            //string del = "delete from pdt_tab where pdt_id=" + getid + "";
            //objcls.query(del);
            //gridBind();

            try
            {
                int i = e.RowIndex;

                if (i >= 0 && i < GridView2.DataKeys.Count)
                {
                    int getid = Convert.ToInt32(GridView2.DataKeys[i].Value);
                    string del = "DELETE FROM pdt_tab WHERE pdt_id=" + getid;
                    objcls.query(del);
                    gridBind();
                }
                else
                {
                    // Handle the case where the index is out of range
                    System.Diagnostics.Debug.WriteLine($"Invalid index: {i}");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log or display an error message)
                System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
            }

        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            gridBind();
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            gridBind();
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView2.DataKeys[i].Value);
            TextBox txtname = (TextBox)GridView2.Rows[i].Cells[0].Controls[0];
            TextBox txtdesc = (TextBox)GridView2.Rows[i].Cells[1].Controls[0];
            TextBox txtprice = (TextBox)GridView2.Rows[i].Cells[2].Controls[0];
            TextBox txtstock = (TextBox)GridView2.Rows[i].Cells[3].Controls[0];
            string upd = "update pdt_tab set pdt_name='" + txtname.Text + "',pdt_desc='" + txtdesc.Text + "',pdt_price='"+txtprice+"',pdt_stock='"+txtstock.Text+"' where pdt_id=" + getid + "";
            objcls.query(upd);
            gridBind();
        }

        
    }
}