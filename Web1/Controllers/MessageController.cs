using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text.Json;

namespace Web1
{

  [ApiController]
  [Route("api/messages")]
  public class MessageController : ControllerBase
  {
    private IMessageRepository _repository;

    public MessageController(IMessageRepository repository)
    {
      _repository = repository;
    }

    //  GET http://localhost:5001/api/messages/usernames
    [HttpGet("usernames")]
    public async Task<IActionResult> GetAllUsernames()
    {
      var usernames = await _repository.GetAllUsernamesAsync();
      return Ok(usernames);
    }
  }
}
