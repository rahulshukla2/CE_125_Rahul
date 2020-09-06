using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web.Configuration;


namespace WebApplication5
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (Session["User-id"] == null)
                Response.Redirect("~/Login.aspx");

            StringBuilder list = new System.Text.StringBuilder();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;
            
            try
            {
                using (con)
                {
                    string query = "select pname,cost from Product join [Order] on Product.pid = [Order].pid where userid=@userid";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userid",Session["User-id"]);
                   

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    int total_sum = 0;
                    if (rdr.HasRows)
                    {
                       while(rdr.Read())
                        {
                            total_sum += Convert.ToInt32(rdr["cost"].ToString());
                            list.Append(rdr["pname"].ToString()+"\t\t\t\t"+ rdr["cost"].ToString()+"<br/>");
                        }

                        lbl1.Text = list.ToString();

                        lbl2.Text = total_sum.ToString()+" Rs";
                    }
                    else
                    {
                        lbl1.Text = "No productfound!!!";
                        lbl1.Visible = true;
                    }
                    con.Close();

                    string query1 = "delete from [Order] where userid=@userid";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.Parameters.AddWithValue("@userid", Session["User-id"]);

                    con.Open();
                    cmd1.ExecuteNonQuery();
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