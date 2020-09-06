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
    public partial class Order : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                
                if (Session["User-id"] == null)
                    Response.Redirect("~/Login.aspx");

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;

                    try
                    {
                        using (con)
                        {
                            string query = "select pid,pname,cost from Product";
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
                                lbl1.Text = "No productfound!!!";
                                lbl1.Visible = true;
                            }
                        rdr.Close();
                            SqlDataReader rdr1 = cmd.ExecuteReader();
                            while (rdr1.Read())
                            {
                                ListItem item = new ListItem();
                                item.Text = rdr1["pname"].ToString();
                                ListBox1.Items.Add(item);
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

        protected void Button1_Click(object sender, EventArgs e)
        {

            

            Response.Redirect("~/Order.aspx");
            cart.Items.Clear();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (ListBox1.SelectedIndex != -1)
            {

                cart.Items.Add(ListBox1.SelectedItem);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;

                try
                {
                    using (con)
                    {

                        string query = "select pid from Product where pname=@pname";
                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@pname", ListBox1.SelectedItem.Text);
                        

                        con.Open();
                        SqlDataReader rdr = cmd.ExecuteReader();
                        rdr.Read();
                        string pid1 = rdr["pid"].ToString();
                        con.Close();

                        string query1 = "Insert Into [Order](userid,pid)values(@userid,@pid)";
                        SqlCommand cmd1 = new SqlCommand(query1, con);
                        

                       
                        cmd1.Parameters.AddWithValue("@userid", Session["User-id"]);
                        cmd1.Parameters.AddWithValue("@pid", pid1);
                       
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
}