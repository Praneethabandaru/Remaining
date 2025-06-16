using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Myteam
    {
        public int Teamid { get; set; }

        public string[] TeamNames { get; set; }

        public void printteamdetails()
        {
            Console.WriteLine($"Teamid:{Teamid}");
            Console.WriteLine($"Team Names: {string.Join(", ", TeamNames)}");
        }
    }
}
