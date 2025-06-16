using System.ComponentModel.DataAnnotations;

namespace CodeFirstApp.Models
{
    public class Song
    {
        [Key]
        public int id { get; set; }
        public string songname { get; set; }
        public string singer { get; set; }
        public string Moviename { get; set; }
        public int YOR { get; set; }
        public string musicdirector { get; set; }

    }
}
