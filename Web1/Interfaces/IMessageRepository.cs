using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web1
{
  public interface IMessageRepository
  {
    Task<Message> SendMessageAsync(string username, MessageDto messageDto);
    Task<IEnumerable<dynamic>> GetMessagesAsync(string username);
  }
}
