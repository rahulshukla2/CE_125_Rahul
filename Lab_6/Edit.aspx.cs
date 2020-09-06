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
    public partial class Edit : System.Web.UI.Page
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
                    string query = "select * from student where id=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txt1.Text);

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Read();

                    if (rdr.HasRows)
                    {

                        txt5.Text = rdr["name"].ToString();
                        txt2.Text = rdr["sem"].ToString();
                        txt3.Text = rdr["mob_no"].ToString();
                        txt4.Text = rdr["email_id"].ToString();

                        txt5.Visible = true;
                        txt2.Visible = true;
                        txt3.Visible = true;
                        txt4.Visible = true;

                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;

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
                errlbl.Text = err.Message+txt1.Text;
                errlbl.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;

            try
            {
                using (con)
                {
                    string query = "update student set name=@name,sem=@sem,mob_no=@mob_no,email_id=@email_id  where id=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txt1.Text);
                    cmd.Parameters.AddWithValue("@name", txt5.Text);
                    cmd.Parameters.AddWithValue("@sem", txt2.Text);
                    cmd.Parameters.AddWithValue("@mob_no", txt3.Text);
                    cmd.Parameters.AddWithValue("@email_id", txt4.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    errlbl.Text = "1 row updated!!!";
                    errlbl.Visible = true;



                }

            }
            catch (Exception err)
            {
                errlbl.Text = err.Message;
                errlbl.Visible = true;
            }
        }
    }
    
    
}