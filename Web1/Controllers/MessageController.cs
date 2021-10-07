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

    //  POST http://localhost:5001/api/messages/sara
    [HttpPost("{username}")]
    public async Task<IActionResult> SendMessage(string username, MessageDto messageDto)
    {
      var message = await _repository.SendMessageAsync(username, messageDto);
      if (message is null) return NotFound();
      return Ok(message);
    }

    //  GET http://localhost:5001/api/messages/sara
    [HttpGet("{username}")]
    public async Task<IActionResult> GetMessages(string username)
    {
      var messages = await _repository.GetMessagesAsync(username);
      return Ok(messages);
    }
  }
}
