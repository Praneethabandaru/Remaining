using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Client
    {
        Servercls s = new Servercls();

        public Client()
        {
            ob.myevt +=Ob_myevt;
        }
        private void Ob_myevt(string s)
        {
            Console.WriteLine("event raised" + s);
        }
        public  void execute()
        {
            s.sendMsg("hello world");
        }
    }
}
