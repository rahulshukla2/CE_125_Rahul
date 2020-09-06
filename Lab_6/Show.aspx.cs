using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web.Configuration;

namespace WebApplication5
{
    public partial class Show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;

            try
            {
                using (con)
                {
                    string query = "select * from Student";
                    SqlCommand cmd = new SqlCommand(query, con);

                    
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        GridView1.DataSource = rdr;
                        GridView1.DataBind();
                    }
                    else
                    {
                        lbl1.Text = "No records found!!!";
                        lbl1.Visible = true;
                    }

                }

            }
            catch (Exception err)
            {
                lbl1.Text = err.Message;
                lbl1.Visible = true;
            }
        }
    }
    
}