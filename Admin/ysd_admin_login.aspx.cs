using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class Admin_ysd_admin_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_login_Click(object sender, EventArgs e)
    {
         SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ysd"].ConnectionString);
        con.Open();
        string chkuser = "select count(*) from Admin where username ='" + txt_un.Text + "'";
        SqlCommand com = new SqlCommand(chkuser, con);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        con.Close();
        if(temp == 1)
        {
            con.Open();
            string chkpass = "select password from Admin where username ='" + txt_un.Text + "'";
            SqlCommand compass = new SqlCommand(chkpass, con);
            string password = compass.ExecuteScalar().ToString();
            if(password==txt_pass.Text)
            {
                Session["admin"] = txt_un.Text;
               
                Response.Redirect("Default1.aspx");
            }
            else
            {
                Response.Write("Password is not correct");
            }

        }
        else
        {
            Response.Write("Username is not correct");
        }

    }
    }
