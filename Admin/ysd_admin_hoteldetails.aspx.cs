using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_ysd_admin_hoteldetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ysd"].ConnectionString);
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("ysd_admin_login.aspx");
        }
        con.Open();
        cmd = new SqlCommand();
        cmd.Connection = con;
    }
    protected void btn_save_Click(object sender, EventArgs e)
    {
        String h_name = hotel_name.Text;
        String stat = state.Text;
        String ct = city.Text;
        String add = address.Text;
        String h_rate = rate.Text;
        String h_no = help_no.Text;


        cmd.CommandText = "insert into hotel values('" + h_name + "','" + stat + "','" + ct + "','" + add + "','" + h_rate + "','" + h_no + "',NULL,NULL,NULL,NULL)";
        int x = cmd.ExecuteNonQuery();
        if (x > 0)
        {
            Response.Write("<script>alert('Hotel  added! ');</script>");
            //Response.Redirect("ysd_admin_hoteldetails.aspx");

        }
        else
        {
            Response.Write("<script>alert('Hotel not added! try agin.');</script>");

        }
        con.Close();
    }
}