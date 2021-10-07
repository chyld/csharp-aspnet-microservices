using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Web1
{
  public class MessageRepository : IMessageRepository
  {
    private Database _db;

    public MessageRepository(Database db)
    {
      _db = db;
    }

    public async Task<IEnumerable<string>> GetAllUsernamesAsync()
    {
      await _db.Messages.ToListAsync();
      return new[] { "a", "b" };
    }
  }
}
