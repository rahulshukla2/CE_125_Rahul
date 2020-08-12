using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace WebApplication4
{
    
    public class Product
    {
        public String name;
        public String price;

        public Product(String n1, String p1)
        {
            name = n1;
            price = p1;
        }
    }
    
    
    
    
    
    
    
    public partial class Home : System.Web.UI.Page
    {
        List<Product> list = new List<Product>();
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                Label1.Text = "Welcome " + Session["Username"] + "<br/>";


            }
            if (IsPostBack)
            {

                if (Items1.SelectedItem == null)
                {
                    Label2.Text = "Listbox is empty";
                }
                else
                {
                    Cart.Items.Add(Items1.SelectedItem);
                    String name = Items1.SelectedItem.Text;
                    String price = Items1.SelectedItem.Value;
                    Product p1 = new Product(name, price);
                    list.Add(p1);
                    Label2.Text = "Came";
                }
            }
                
                
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Order"] =list;
            Response.Redirect("~/order.aspx");
        }

        protected void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category.Text.Equals("Electronics"))
            {
                ListItem l1 = new ListItem("Laptop", "40000");
                ListItem l2 = new ListItem("TV", "23000");
                ListItem l3 = new ListItem("Smartphone", "14999");
                ListItem l4 = new ListItem("Pendrive", "562");
                ListItem l5 = new ListItem("Mobile Charger", "210");
                ListItem l6 = new ListItem("Bulb", "80");
                ListItem l7 = new ListItem("Earphone", "250");

                Items1.Items.Clear();
                Items1.Items.Add(l1);
                Items1.Items.Add(l2);
                Items1.Items.Add(l3);
                Items1.Items.Add(l4);
                Items1.Items.Add(l5);
                Items1.Items.Add(l6);
                Items1.Items.Add(l7);



            }
            if (Category.Text.Equals("Books"))
            {
                ListItem l1 = new ListItem("The alchemist", "750");
                ListItem l2 = new ListItem("Shiva triology", "900");
                ListItem l3 = new ListItem("Ulysses", "500");
                ListItem l4 = new ListItem("War and Peace", "1200");
                ListItem l5 = new ListItem("Lolita", "300");
                ListItem l6 = new ListItem("Hamlet", "800");
                ListItem l7 = new ListItem("The Odyssey", "600");

                Items1.Items.Clear();
                Items1.Items.Add(l1);
                Items1.Items.Add(l2);
                Items1.Items.Add(l3);
                Items1.Items.Add(l4);
                Items1.Items.Add(l5);
                Items1.Items.Add(l6);
                Items1.Items.Add(l7);

            }
        }

        protected void Items1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                
            
        }
    }
}