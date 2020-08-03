using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class home : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            int count1 = 0;
            int count2 = 0;
            if (IsPostBack)
            {
               
                if (State.SelectedItem.Text.Equals("Gujarat") && count1==0)
                {
                    ListItem l1 = new ListItem("Ahmedabad", "1");
                    ListItem l2 = new ListItem("Vadodara", "2");
                    City.Items.Add(l1);
                    City.Items.Add(l2);
                    count1++;
                }
               if (State.SelectedItem.Text.Equals("Maharashtra")&& count2==0)
                {
                    ListItem l3 = new ListItem("Mumbai");
                    ListItem l4 = new ListItem("Pune");
                    City.Items.Add(l3);
                    City.Items.Add(l4);
                    count2++;
                }
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {

                StringBuilder check = new System.Text.StringBuilder();


                for (int i = 0; i < hobbies.Items.Count; i++)
                {

                    if (hobbies.Items[i].Selected)
                    {

                        check.Append(hobbies.Items[i].Text + ",");

                    }

                }




                Label1.Text = "Full name: " +fullname.Text;
                Label1.Visible = true;

                Label2.Text ="Age: " +age.Text;
                Label2.Visible = true;

                Label3.Text ="Gender: " +gender.Text;
                Label3.Visible = true;

                Label4.Text = "Mobile no: " +mobileno.Text;
                Label4.Visible = true;

                Label5.Text ="Hobbies: " +check.ToString() ;
                Label5.Visible = true;

                Label6.Text ="State: " +State.Text;
                Label6.Visible = true;

                Label7.Text ="City: " +City.Text;
                Label7.Visible = true;

                Label8.Text = "Pan no: " +pan.Text;
                Label8.Visible = true;










            }
        }
    }
}