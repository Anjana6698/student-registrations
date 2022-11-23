using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace student_registration.Admin
{
    public partial class Confirmuser : System.Web.UI.Page
    {
        DbOperation db = new DbOperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                db.fillgrid("select s.*,l.* from Student_Details s inner join login l on s.lid=l.lid where l.status='not confirmed' and type='student'", GridView1);
            }

        }

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            string s = GridView1.DataKeys[e.RowIndex].Value.ToString();

            db.exenonquery("update login set status='confirmed' where lid=" + s + "");
            db.fillgrid("select s.*,l.* from Student_Details s inner join login l on s.lid=l.lid where l.status='not confirmed' and type='student'", GridView1);

        }
    }
}