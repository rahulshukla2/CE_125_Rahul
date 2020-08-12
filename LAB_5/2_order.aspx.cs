using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace WebApplication4
{
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> list1 = (List<Product>)Session["order"];
            int total_p = 0;
            StringBuilder check = new System.Text.StringBuilder();
            
            if (list1 == null)
            {
                Label1.Text = "Listbox is empty";
            }
            else
            {
                for (int i=0; i< list1.Count; i++)
                {

                    check.Append(list1[i].name + "  "+ list1[i].price+ "<br/>");

                    
                    total_p += Convert.ToInt32(list1[i].price);

                }
            }
            Label1.Text +=  check.ToString()+"</br>";

            total.Text = " Total amount payable is :" + total_p;

        }
    }
}