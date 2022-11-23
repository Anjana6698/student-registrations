using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace student_registration.Faculty
{
    public partial class FacReg : System.Web.UI.Page
    {
        DbOperation db = new DbOperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                Ddlday.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                Ddlmonth.Items.Add(i.ToString());
            }

            for (int i = 1998; i <= DateTime.Now.Year; i++)
            {
                Ddlyear.Items.Add(i.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            object ob = db.exescalar("insert into login values('" + TextBox4.Text + "','" + TextBox5.Text + "','faculty','Not confirmed');select @@IDENTITY");
            string gender = string.Empty;
            if (RadioButton1.Checked)
            {
                gender = "Male";
            }
            else if (RadioButton2.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Others";
            }
            string dob = Ddlday.SelectedValue + "/" + Ddlmonth.SelectedValue + "/" + Ddlyear.SelectedValue;

            int j = db.exenonquery("insert into Faculty_Details values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + gender + "','" + ddlcollege.SelectedValue + "','" + dob + "','" + ob + "')");
            if (j == 1)
            {
                Response.Write("success");
                Response.Redirect("../Guest/Firstform.aspx");
            }
            }
    }
}