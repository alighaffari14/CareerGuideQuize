using SelfAwareness;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FundingMaktab
{
    public partial class Dashboard : System.Web.UI.Page
    {
        SqlConnection con;
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["E_Mail"] != null)
            {
                loadTotalQuestions();
                loadTotalLevels();
                loadTotalUsers();
            }
        }

        private void loadTotalUsers()
        {
            con = Connection.authorize();
            string query = "select count(User_Id) as Total from Tbl_Users";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Label3.Text = reader["Total"].ToString();
            }
        }

        private void loadTotalLevels()
        {
            con = Connection.authorize();
            string query = "select count(Quize_Id) as Total from Tbl_Quize";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Label4.Text = reader["Total"].ToString();
            }
        }

        private void loadTotalQuestions()
        {
            con = Connection.authorize();
            string query = "select count(QuizeQuestion_Id) as Total from Tbl_QuizeQuestions";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Label1.Text = reader["Total"].ToString();
            }
        }
    }
}