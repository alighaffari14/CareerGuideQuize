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
    public partial class AddQuestion : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadAllLevels();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        private void LoadAllLevels()
        {
            con = Connection.authorize();
            string query = "select * from Tbl_Quize";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataValueField = "Quize_Id";
            DropDownList1.DataTextField = "Title";
            DropDownList1.DataBind();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = Connection.authorize();
            string query = "insert into Tbl_QuizeQuestions(Quize_Id,Question)values('" + int.Parse(DropDownList1.SelectedValue) + "','" + textBox1.Text.ToString() + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            int a = cmd.ExecuteNonQuery();
            con.Close();
            if (a > 0)
            {
                getLastInsertedQuestionID();
                Response.Write("<script>alert('Question has been added to Level Succesfully')</script>");
                Response.Redirect("Questions.aspx");
            }
        }

        private void getLastInsertedQuestionID()
        {
            int questionid = 0;
            con = Connection.authorize();
            string query = "SELECT TOP 1 QuizeQuestion_Id FROM Tbl_QuizeQuestions ORDER BY QuizeQuestion_Id DESC";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                questionid = int.Parse(reader["QuizeQuestion_Id"].ToString());
            }
            con.Close();
            if (insertingOptionsToDB(questionid) == true)
            {
                Response.Write("<script>alert('Question has been Added Successfully!')</script>");
            }
        }

        private bool insertingOptionsToDB(int questionid)
        {
            bool myvalue = false;
            int a = 0;
            string query = "";
            for (int i = 0; i < 4; i++)
            {
                if (CheckBox1.Checked)
                {
                    if (i == 1)
                    {
                        con = Connection.authorize();
                         query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option1.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                    else if (i == 2)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option2.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                    else if (i == 3)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option3.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                    else if (i == 4)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option4.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                    
                }
                else if (CheckBox2.Checked)
                {
                    if (i == 1)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option1.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                    else if (i == 2)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option2.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                    else if (i == 3)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option3.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                    else if (i == 4)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option4.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                }
                else if (CheckBox3.Checked)
                {
                    if (i == 1)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option1.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                    else if (i == 2)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option2.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                    else if (i == 3)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option3.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                    else if (i == 4)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option4.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    if (i == 1)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option1.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                    else if (i == 2)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option2.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                    else if (i == 3)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option3.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                    else if (i == 4)
                    {
                        con = Connection.authorize();
                        query = "insert into Tbl_QuizeQuestionsOptions(QuizeQuestion_Id,optionText,is_Correct)values('" + questionid + "','" + option4.Text.ToString() + "','" + true + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        a = cmd.ExecuteNonQuery();
                    }
                }
            }
            if (a > 0)
            {
                myvalue = true;
            }

            return myvalue;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox2.Visible = false;
            CheckBox3.Visible = false;
            CheckBox4.Visible = false;
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox4.Visible = false;
            CheckBox3.Visible = false;
            CheckBox1.Visible = false;
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox2.Visible = false;
            CheckBox4.Visible = false;
            CheckBox1.Visible = false;
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox2.Visible = false;
            CheckBox3.Visible = false;
            CheckBox1.Visible = false;
        }
    }
}