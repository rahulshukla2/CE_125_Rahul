using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.Configuration;

namespace WebApplication2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            Label1.Text = " ";
            Label2.Text = " ";
            Label3.Text = " "; 
            Label4.Text = " "; 
            Label5.Text = " "; 
            Label6.Text = " ";
            Label7.Text = " ";
            Label8.Text = " ";



        }

       

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["User_details"];

            if (cookie != null)
            {
                Label1.Text = "Full name: " + cookie["fullname"];
                Label1.Visible = true;

                Label2.Text = "Age: " + cookie["age"];
                Label2.Visible = true;

                Label3.Text = "Gender: " + cookie["gender"];
                Label3.Visible = true;

                Label4.Text = "Mobile no: " + cookie["mobileno"];
                Label4.Visible = true;

                Label5.Text = "Hobbies: " + cookie["hobbies"];
                Label5.Visible = true;

                Label6.Text = "State: " + cookie["state"];
                Label6.Visible = true;

                Label7.Text = "City: " + cookie["city"];
                Label7.Visible = true;

            }
            else
            {
                Label8.Text = "Temporary cookies not found";
                Label8.Visible = true;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
          
            Response.Cookies["User_details"].Expires = DateTime.Now.AddMinutes(-1);
        }
    }
}