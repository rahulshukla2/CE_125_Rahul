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
    public partial class Insert : System.Web.UI.Page
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
                    string query = "Insert Into Student(name,sem,mob_no,email_id)values(@name,@sem,@mob_no,@email_id)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@name", txt1.Text);
                    cmd.Parameters.AddWithValue("@sem", txt2.Text);
                    cmd.Parameters.AddWithValue("@mob_no", txt3.Text);
                    cmd.Parameters.AddWithValue("@email_id", txt4.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    lbl1.Text = "1 row inserted";
                    lbl1.Visible = true;

                }

            }
            catch(Exception err)
            {
                lbl1.Text = err.Message;
                lbl1.Visible = true;
            }
        }
    }
}