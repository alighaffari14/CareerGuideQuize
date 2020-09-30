using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SelfAwareness
{
    public class Connection
    {
        public static SqlConnection authorize()
        {
            //string constring = @"Data Source=.\MSSQLSERVER01;Initial Catalog=FundingSystem;Integrated Security=True";
            //SqlConnection con = new SqlConnection(constring);
            //con.Open();
            //return con;
            string constring = "data source=DESKTOP-TUAHA\\SQL2014;Initial Catalog=CareerGuide;Persist Security Info=True;User ID=sa; Password=viftech";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            return con;
        }
    }
}