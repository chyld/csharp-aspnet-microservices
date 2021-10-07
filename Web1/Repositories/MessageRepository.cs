using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Net.Http.Json;

namespace Web1
{
  public class MessageRepository : IMessageRepository
  {
    private Database _db;

    public MessageRepository(Database db)
    {
      _db = db;
    }

    public async Task<Message> SendMessageAsync(string username, MessageDto messageDto)
    {
      var client = new HttpClient();
      Message message = null;

      try
      {
        var from = await client.GetFromJsonAsync<UserDto>($"http://localhost:5002/api/users/search?username={username}");
        var to = await client.GetFromJsonAsync<UserDto>($"http://localhost:5002/api/users/search?username={messageDto.ToUsername}");
        message = new Message() { FromUsername = from.Username, ToUsername = to.Username, Text = messageDto.Text };
        await _db.AddAsync(message);
        await _db.SaveChangesAsync();
      }
      catch (Exception ex)
      {
        Console.WriteLine($"error : {ex.Message}");
      }

      return message;
    }

    public async Task<IEnumerable<dynamic>> GetMessagesAsync(string username)
    {
      return await _db.Messages.Where(m => m.ToUsername == username).Select(m => new { m.Text }).ToListAsync();
    }
  }
}
