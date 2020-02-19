using Microsoft.EntityFrameworkCore;
using PineBerry01.Models;

namespace PineBerry01.DataContext
{
    public class MainContext : DbContext
    {
        public DbSet<Berries> Berries { get; set; }

        public DbSet<BerrySubject> BerrySubjects { get; set; }

        public DbSet<Notice> Notices { get; set; }

        public DbSet<Calendar> Calendars { get; set; }

        public DbSet<QnA> QnAs { get; set; }

        public MainContext(DbContextOptions<MainContext> options)
            : base(options)
        {
        }

        public MainContext()
        { }


    }
}
