using Microsoft.EntityFrameworkCore;

namespace Web1
{
  public class Database : DbContext
  {
    public DbSet<Message> Messages { get; set; }
    public Database(DbContextOptions<Database> options) : base(options) { }
  }
}
