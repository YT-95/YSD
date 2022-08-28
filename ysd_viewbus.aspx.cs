using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class ysd_viewbus : System.Web.UI.Page
{
   int  j=0;
    int[] seat = new int[37];
    int[] no = new int[37];
    int[] no2 = new int[37];
    public String busto;
    public String busfrom;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {



            String temp = HttpUtility.UrlDecode(Request.QueryString["Id"]);
            String con = ConfigurationManager.ConnectionStrings["ysd"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(con);
            String qry = "select BusTo, BusFrom, dep_time, arr_time, km from BusRoute where Id='" + temp + "'";
            SqlCommand cmd = new SqlCommand(qry, sqlcon);
            sqlcon.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                busto = rd["BusTo"].ToString();
                busfrom = rd["BusFrom"].ToString();
            }
            this.DataBind();
            if (Application["Date"] != null)
            {
                Label6.Text = Application["Date"].ToString();
            }
            sqlcon.Close();
        }
    }

  
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        seat[0]= 1; 
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        seat[1] = 2;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        seat[2] = 3;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        seat[3] = 4;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        seat[4] = 5;
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        seat[5] = 6;
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        seat[6] = 7;
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        seat[7] = 8;
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        seat[8] = 9;
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        seat[9] = 10;
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        seat[10] = 11;
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        seat[11] = 12;
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        seat[12] = 13;
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        seat[13] = 14;
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        seat[14] = 15;
    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        seat[15] = 16;
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        seat[16] = 17;
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        seat[17] = 18;
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        seat[18] = 19;
    }
    protected void Button20_Click(object sender, EventArgs e)
    {
        seat[19] = 20;
    }
    protected void Button21_Click(object sender, EventArgs e)
    {
        seat[20] = 21;
    }
    protected void Button22_Click(object sender, EventArgs e)
    {
        seat[21] = 22;
    }
    protected void Button23_Click(object sender, EventArgs e)
    {
        seat[22] = 23;
    }
    protected void Button24_Click(object sender, EventArgs e)
    {
        seat[23] = 24;

    }
    protected void Button25_Click(object sender, EventArgs e)
    {
        seat[24] = 25;
    }
    protected void Button26_Click(object sender, EventArgs e)
    {
        seat[25] = 26;
    }
    protected void Button27_Click(object sender, EventArgs e)
    {
        seat[26] = 27;
    }
    protected void Button28_Click(object sender, EventArgs e)
    {
        seat[27] = 28;
    }
    protected void Button29_Click(object sender, EventArgs e)
    {
        seat[28] = 29;
    }
    protected void Button30_Click(object sender, EventArgs e)
    {
        seat[29] = 30;
    }
    protected void Button31_Click(object sender, EventArgs e)
    {
        seat[30] = 31;
    }
    protected void Button32_Click(object sender, EventArgs e)
    {
        seat[31] = 32;
    }
    protected void Button33_Click(object sender, EventArgs e)
    {
        seat[32] = 33;
    }
    protected void Button34_Click(object sender, EventArgs e)
    {
        seat[33] = 34;
    }
    protected void Button35_Click(object sender, EventArgs e)
    {
        seat[34] = 35;
    }
    protected void Button36_Click(object sender, EventArgs e)
    {
        seat[35] = 36;
    }

    protected void btn_seatsave_Click(object sender, EventArgs e)
    { 
        for (int i = 0; i <= 35;i++ )
        {
            if(seat[i] != null)
            {
                    no[j] = seat[i];
                    j++;
            }
            else
            {
                Response.Write("<script>alert(' please select the seat ...');</script>");
            }
        }
        no2[0]=2;
        no2[1]=3;
        for (int k = 0; k <= no.Length;k++ )
        {
            Response.Write(no[0]);

        }
          
        
    }
}