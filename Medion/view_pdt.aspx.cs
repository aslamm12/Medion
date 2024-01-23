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
    public partial class view_pdt : System.Web.UI.Page
    {
        CoClass obj = new CoClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string selall = "select pdt_image,pdt_name,pdt_price from pdt_tab where pdt_id='"+Session["pdtid"] +"'";
            SqlDataReader dr = obj.reader(selall);
            while(dr.Read())
            {
                Image1.ImageUrl = dr["pdt_image"].ToString();
                Label1.Text = dr["pdt_name"].ToString();
                Label2.Text = dr["pdt_price"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select max(cart_id) from cart_tab";
            string cartid = obj.scalar(s);
            int cart_id = 0;
            if (cartid == "")
            {
                cart_id = 1;

            }
            else
            {
                int newregid = Convert.ToInt32(cartid);
                cart_id = newregid + 1;
            }

            string selprice = "select pdt_price from pdt_tab where pdt_id=" + Session["pdtid"] + "";
            string str = obj.scalar(selprice);
            int tprice = Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(str);
            string inscart = "insert into cart_tab tab values('" + cart_id + "','" + Session["userid"] + "','" + Session["pdtid"] + "','" + TextBox1.Text + "','" + tprice + "')";
            int i = obj.query(inscart);
            if(i==1)
            {
                Label3.Visible = true;
                Label3.Text = "Added to cart Successfully";

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("user_home.aspx");
        }
    }
}