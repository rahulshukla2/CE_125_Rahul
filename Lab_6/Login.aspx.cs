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
    public partial class Login : System.Web.UI.Page
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
                    string query = "select * from [User] where (userid=@userid and password=@password)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userid", utxt.Text);
                    cmd.Parameters.AddWithValue("@password",ptxt.Text);
                    

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                   
                   if(rdr.HasRows)
                    {
                        Session["User-id"] = utxt.Text;
                        Response.Redirect("~/Product.aspx");
                    }
                    else
                    {
                        lbl1.Text = "Incorrect Credentials!!!";
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