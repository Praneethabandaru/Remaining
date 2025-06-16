using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Server
    {
        //create events
        //create delegates
        //raise an event
        //sender code
        public delegate void serverdel(string s);
        public event serverdel myevt; //event declaration
        public void sendMsg(string s)
        {
           myevt("hello world");
            //Console.WriteLine("event raised" + s);

        }
    }
}
