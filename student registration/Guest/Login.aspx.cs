using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace student_registration.Guest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DbOperation db = new DbOperation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NTP-LAP-642\\SQL_SERVER;Initial Catalog=student;Integrated Security=True;Pooling=False";

            con.Open();
            string qry = "select * from login where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "' and status='confirmed'";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Connection = con;
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {

                Response.Redirect("userlogin.aspx");
            }
            else
            {
                Response.Write("Invalid Credentials");
            }



            /* string sql = "select * from login where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "' and status='confirmed'";
           int i = db.exenonquery(sql);
           if (i == 1)
           {
               Response.Redirect("userlogin.aspx");
           }
           else
           {
               Response.Write("Invalid Credentials");
           } */
        }
    }
}