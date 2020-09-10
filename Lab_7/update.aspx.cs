using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_applab7
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SampleDataContext dbcontext = new SampleDataContext();
            var output = dbcontext.Students.SingleOrDefault(x => x.sid == Convert.ToInt32(txt1.Text));

            txt5.Text = output.name;
            txt2.Text = output.sem;
            txt3.Text = output.contactno;
            txt4.Text = output.emailid;
            txt6.Text = output.cpi;

            txt5.Visible = true;
            txt2.Visible = true;
            txt3.Visible = true;
            txt4.Visible = true;
            txt6.Visible = true;

            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SampleDataContext dbcontext = new SampleDataContext())
            {
                Student s1 = dbcontext.Students.SingleOrDefault(x => x.sid == Convert.ToInt32(txt1.Text));
                s1.name = txt5.Text;
                s1.sem = txt2.Text;
                s1.contactno = txt3.Text;
                s1.emailid = txt4.Text;
                s1.cpi = txt6.Text;
                
               
                dbcontext.SubmitChanges();
            }
        }
    }
}