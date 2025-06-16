using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Onlineshop.Models;
namespace Onlineshop
{
    public partial class Register : System.Web.UI.Page
    {
        myshopEntities ob = new myshopEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Onlineshop.Models.Register r = new Models.Register();
            r.uname = TextBox1.Text;
            r.password = TextBox2.Text;
            r.Age=int.Parse(TextBox4.Text);
            r.email = TextBox5.Text;
            r.nationality = TextBox6.Text;

            if(RadioButton1.Checked)
            {
                r.gender = true;
            }
            if(RadioButton2.Checked)
            {
                r.gender = false;
            }
            ob.Registers.Add(r);
            int i = ob.SaveChanges();
            if(i>0)
            {
                Label1.Text = "Congrats New User Created!";
            }
             


        }

        //protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        //{
        //    //country has to be india , canada and japan

        //    if(args.Value == "india" || args.Value == "canada" || args.Value == "japan")
        //    {
        //        args.IsValid = true;
        //    }
        //    else
        //    {
        //        args.IsValid = false;
        //    }
        //}

    }
}