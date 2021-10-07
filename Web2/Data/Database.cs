using Microsoft.EntityFrameworkCore;

namespace Web2
{
  public class Database : DbContext
  {
    public DbSet<User> Users { get; set; }
    public Database(DbContextOptions<Database> options) : base(options) { }
  }
}
