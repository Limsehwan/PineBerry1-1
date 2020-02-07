using Microsoft.EntityFrameworkCore;
using PineBerry01.Models;

namespace PineBerry01.DataContext
{
    public class MainContext : DbContext
    {
        public DbSet<Berry> Berries { get; set; }

        public DbSet<BerrySubject> BerrySubjects { get; set; }

        public DbSet<BerrySuggest> BerrySuggests { get; set; }

        public DbSet<Notice> Notices { get; set; }

        public DbSet<QnASubject> QnASubjects { get; set; }

        public DbSet<User> Users { get; set; }

        //TODO: 나중에 SA에서 적절한 권한으로 바꾸기
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=PineBerry;User Id=sa;Password=martin03110170@;");
        }
    }
}
