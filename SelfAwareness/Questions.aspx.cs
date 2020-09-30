using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SelfAwareness
{
    public partial class Questions : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["E_Mail"]!=null)
            {
                LoadAllQuestions();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }

        private void LoadAllQuestions()
        {
            con = Connection.authorize();
            string query = @"select l.Title, q.Question from Tbl_QuizeQuestions q
inner join Tbl_Quize l on l.Quize_Id = q.Quize_Id";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
            con.Close();
        }
    }
}