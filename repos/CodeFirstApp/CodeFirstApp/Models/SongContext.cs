using Microsoft.EntityFrameworkCore;

namespace CodeFirstApp.Models
{
    public class SongContext : DbContext
    {
        //attaching connectionstring to song contex class
        public SongContext(DbContextOptions<SongContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=WKSBAN36SUHTR15\\SQLEXPRESS;Initial Catalog=songsdb;Integrated Security=True;Encrypt=False");
        //}
        public DbSet<Song> Songs { get; set; }

    }
}
