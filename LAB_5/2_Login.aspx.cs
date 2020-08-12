using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
            {
                Session["Username"] = TextBox1.Text;
                Response.Redirect("~/Home.aspx");

            }
            else
            {
                Label1.Text = "Incorrect credentials";
                Label1.Visible = true;
            }
        }
    }
}