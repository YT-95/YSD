using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class Admin_ysd_admin_busdetails : System.Web.UI.Page
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
        String to = txt_to.Text;
        String from = txt_from.Text;
        String dep = dep_time.Text;
        String arr= arr_time.Text;
        String b_km = km.Text;
        String b_rate = rate.Text;


        cmd.CommandText = "insert into BusRoute values('" + to + "','" + from + "','" + dep + "','" + arr + "','" + b_km + "','" + b_rate + "')";
        int x = cmd.ExecuteNonQuery();
        if (x > 0)
        {
            Response.Write("<script>alert('Bus  added! ');</script>");
            //Response.Redirect("ysd_admin_busdetails.aspx");

        }
        else
        {
            Response.Write("<script>alert('Bus not added! try agin.');</script>");

        }
        con.Close();
     
    }

}