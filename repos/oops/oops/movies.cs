using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Movies
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Actor { get; set; }
        public string Actress { get; set; }

        public void showdetails()
        {
            Console.WriteLine($"MovieId-{MovieId}");
            Console.WriteLine($"MovieName- {MovieName}");
            Console.WriteLine($"Actor-{Actor}");
            Console.WriteLine($"Actress-{Actress}");
        }
    }
}
