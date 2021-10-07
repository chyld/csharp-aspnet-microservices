using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web1
{
  public interface IMessageRepository
  {
    Task<IEnumerable<string>> GetAllUsernamesAsync();
  }
}
