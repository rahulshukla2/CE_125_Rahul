using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (IsPostBack)
            {

                if (State.SelectedItem.Text.Equals("Gujarat"))
                {
                    ListItem l1 = new ListItem("Ahmedabad");
                    ListItem l2 = new ListItem("Vadodara");
                    City.Items.Clear();
                    if (City.Items.Contains(l1) && (City.Items.Contains(l2)))
                    { }
                    else
                    {
                        City.Items.Add(l1);
                        City.Items.Add(l2);
                    }
                }
                if (State.SelectedItem.Text.Equals("Maharashtra"))
                {
                    ListItem l3 = new ListItem("Mumbai");
                    ListItem l4 = new ListItem("Pune");
                    City.Items.Clear();
                    if (City.Items.Contains(l3) && (City.Items.Contains(l4)))
                    { }
                    else
                    {
                        City.Items.Add(l3);
                        City.Items.Add(l4);

                    }
                }
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("User_details");

            if (Page.IsValid)
            {

                StringBuilder check = new System.Text.StringBuilder();


                for (int i = 0; i < hobbies.Items.Count; i++)
                {

                    if (hobbies.Items[i].Selected)
                    {

                        check.Append(hobbies.Items[i].Text + ",");

                    }

                }



                /*if (t_cookie.Text.Equals("Save as temporary cookies"))
                {
                    cookie["fullname"]=fullname.Text;
                    cookie["age"]=age.Text;
                    cookie["gender"]=gender.Text;
                    cookie["mobileno"]=mobileno.Text;
                    cookie["hobbies"]=check.ToString();
                    cookie["state"]=State.Text;
                    cookie["city"]=City.Text;

                    Response.Cookies.Add(cookie);
                }*/

                //if (t_cookie.Text.Equals("Save as Permanant Cookies"))
                //{
                cookie["fullname"] = fullname.Text;
                cookie["age"] = age.Text;
                cookie["gender"] = gender.Text;
                cookie["mobileno"] = mobileno.Text;
                cookie["hobbies"] = check.ToString();
                cookie["state"] = State.Text;
                cookie["city"] = City.Text;


                cookie.Expires = System.DateTime.Now.AddMinutes(2);
                Response.Cookies.Add(cookie);
                //}

                Response.Redirect("Home.aspx");
            
            }
        }
    }
}