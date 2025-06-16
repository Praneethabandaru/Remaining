﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPattern
{
    //firsttime 
    internal class login
    {
        public void checkuser()
        {
            Console.WriteLine("login method called");
        }
    }
    internal class product
    {
        public void addtocart()
        {
            Console.WriteLine("item is added to cart");
        }

    }
    internal class makepayment
    {
        public void processpayment()
        {
            Console.WriteLine("payment is processing");
        }
    }
    internal class sendmail
    {
        public void mailtouser()
        {
            Console.WriteLine("send email to user");
        }
    }
    class facadepattern
    {
        login l;
        product p;
        makepayment m;
        sendmail s;

        public facadepattern()
        {
            l =new login();
            p= new product();
            m = new makepayment();
            s = new sendmail();
        }

        public void buyproduct()
        {
            l.checkuser();
            p.addtocart();
            m.processpayment();
            s.mailtouser(); 
        }

    }
}
