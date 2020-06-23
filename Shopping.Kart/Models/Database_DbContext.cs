using Microsoft.EntityFrameworkCore;
using Shopping.Kart.Models;
using static Shopping.Kart.Models.DataClass;

namespace Shopping.Kart.Models
{
    public class Database_DbContext : DbContext
    {
        public Database_DbContext()
        { 
        }
        public Database_DbContext(DbContextOptions<Database_DbContext> _dbContext) : base(_dbContext)
        { 
        }

        public DbSet<tbl_UserDetail> UserDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //builder.UseSqlServer("Server=VED\\SQLEXPRESS;Database=SSCMS;Trusted_Connection=True;MultipleActiveResultSets=True;");
            builder.UseSqlServer("Server=VED\\SQLEXPRESS;Database=SSCMS;Integrated Security=SSPI;");
            base.OnConfiguring(builder);
        }
    }
}
