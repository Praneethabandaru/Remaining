using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Onlineshop.Models;

namespace Onlineshop
{
    public partial class Login : System.Web.UI.Page
    {
        myshopEntities ob = new myshopEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //this function is called when login button is clicked
            var res = (from t in ob.Registers
                      where t.uname == Login1.UserName && t.password == Login1.Password
                      select t).Count();
            if (res > 0) 
            {
                //redirect to products page

                Response.Redirect("products.aspx");
            }
            else
            {
                Login1.FailureText = "Invalid Credentials";
            }
        }
    }
}