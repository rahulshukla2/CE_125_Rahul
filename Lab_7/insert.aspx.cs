using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_applab7
{
  
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            using (SampleDataContext dbcontext = new SampleDataContext())
            {
                Student n1 = new Student
                {
                   
                    name = txt1.Text,
                    sem = txt2.Text,
                    contactno = txt3.Text,
                    emailid = txt4.Text,
                    cpi = txt5.Text
                };
                dbcontext.Students.InsertOnSubmit(n1);
                dbcontext.SubmitChanges();
            }
           

            

        }
    }
}