using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SelfAwareness
{
    public partial class AddLevels : System.Web.UI.Page
    {
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["E_Mail"] != null)
            {

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            con = Connection.authorize();
            string query = "insert into Tbl_Quize(Title)values('"+textBox1.Text.ToString()+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Response.Write("<script>alert('Level has been added Succesfully')</script>");
                Response.Redirect("Levels.aspx");
            }
        }
    }
}