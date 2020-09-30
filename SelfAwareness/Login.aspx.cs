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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }



        protected void Button1_Click1(object sender, EventArgs e)
        {
            con = Connection.authorize();
            string query = "select * from Tbl_Users where E_Mail='" + TextBox1.Text.ToString() + "' and Password='" + TextBox2.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {

                Session["E_Mail"] = TextBox1.Text.ToString();
                Response.Redirect("Dashboard.aspx");

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

    }
}