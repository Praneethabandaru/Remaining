using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    //primary job of properties is to accept data from the user 
    //primary job of methods is to validate data and then interact with the databse
    //this demonstrate even encapsulation
    internal class login
    {
        //properties
        public string uname;
        public string password;

        //behaviour
        public void Validate()
        {
            if(uname == "mphasis" && password == "india")
            {
                Console.WriteLine("valid user");
            }
            else
            {
                Console.WriteLine("invalid user");
            }
        }
    }
}
