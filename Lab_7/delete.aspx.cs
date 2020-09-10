using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_applab7
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SampleDataContext dbcontext = new SampleDataContext())
            {
                Student s1 = dbcontext.Students.SingleOrDefault(x => x.sid == Convert.ToInt32(txt1.Text));


                dbcontext.Students.DeleteOnSubmit(s1);
                dbcontext.SubmitChanges();
            }
        }
    }
}