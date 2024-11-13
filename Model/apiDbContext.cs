using Microsoft.EntityFrameworkCore;

namespace FullStackWithFlutterUsingDotNet8.Model
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<users> users { get; set; }
    }
}
