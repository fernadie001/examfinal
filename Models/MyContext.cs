using Microsoft.EntityFrameworkCore;
namespace examfinal.Models
{
    public class Mycontext : DbContext
    {
        public Mycontext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users {get;set;}
        public DbSet<Actividad> Activity {get;set;}
        public DbSet<ActivityHistory> Orders {get;set;}
    }
}